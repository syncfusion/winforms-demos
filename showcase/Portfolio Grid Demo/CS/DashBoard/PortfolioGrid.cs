#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
#endregion

namespace PortfolioManager
{
    #region Enum
    /// <summary>
    /// Portfolio Grid's View
    /// </summary>
    public enum GridViewType
    {
        Overview,
        DetailView,
        SectorIndustryView,
        CountryView
    }
    #endregion
    /// <summary>
    /// Portfolio Grid Helper class
    /// </summary>
    public class PortfolioGrid
    {
        # region Variable Declaration

        GridGroupingControl grid;
        ImageListAdv imageList;
        ImageList images16;
        ImageList images24;
        private GridViewType gridView;
        int captionCoverCols;
        #endregion

        #region Method
        public PortfolioGrid(GridGroupingControl Grid, IBindingList dataSource, ImageListAdv imageList, ImageList images16, ImageList images24)
        {
            this.imageList = imageList;
            this.images16 = images16;
            this.images24 = images24;
            this.grid = Grid;
            this.SetDataSource(dataSource);
            captionCoverCols = 4;

            //Configure Grid
            WireEvents();
            CustomizeLookAndFeel();
            SetFilter();
            SetupMarketValueExpression();
            InitializeTableDescriptor();
            AddSummariesToCaption();

            this.grid.TableControl.EnableDoubleBufferSurface();

            GridView = GridViewType.Overview;
        }

        /// <summary>
        /// Sets / Gets the current Grid View
        /// </summary>
        public GridViewType GridView
        {
            get
            {
                return this.gridView;
            }
            set
            {
                gridView = value;
                RefreshView();
            }
        }

        #region Enumeration - StockIcons
        enum StockIcons16
        {
            BasicMaterials = 0,
            ConsumerGoods,
            Financial,
            Healthcare,
            IndustrialGoods,
            Services,
            Technology,
            Utilities,
            AgriculturalChemicals,
            Aluminum,
            Copper,
            Gold,
            OilGas,
            Silver,
            SteelIron,
            Appliances,
            AutomotiveManufacturers,
            BusinessEquipment,
            ElectronicEquipment,
            SportingGoods,
            ToysGames,
            AccidentHealthInsurance,
            AssetManagement,
            InsuranceBrokers,
            InvestmentBrokerage,
            RealEstateDevelopment,
            LifeInsurance,
            Biotechnology,
            HealthCarePlans,
            Hospitals,
            MedicalAppliancesEquipment,
            MedicalInstrumentsSupplies,
            MedicalPractitioners,
            AerospaceDefenseProductsServices,
            Cement,
            GeneralBuildingMaterials,
            HeavyConstruction,
            ManufacturedHousing,
            MetalFabrication,
            TextileIndustrial,
            WasteManagement,
            ApparelStores,
            ConsumerServices,
            DepartmentStores,
            ElectronicsStores,
            FoodWholesale,
            Lodging,
            MajorAirlines,
            RegionalAirlines,
            BusinessSoftwareServices,
            ComputerBasedSystems,
            DataStorageDevices,
            HealthcareInformationServices,
            InformationTechnologyServices,
            PersonalComputers,
            WirelessCommunications,
            DiversifiedUtilities,
            ElectricUtilities,
            ForeignUtilities,
            GasUtilities,
            WaterUtilities
        };

        enum StockIcons24
        {
            AmericanFunds = 0,
            ChildrenCollegeSavings,
            DayTrading,
            FidelityFunds,
            RetirementSavings,
            SchwabFunds,
            VanguardFunds,
            AustralianStockExchange,
            BombayStockExchange,
            FrankfurtStockExchange,
            HongKongFuturesExchange,
            LondonStockExchange,
            NewYorkStockExchangeNYSE,
            ParisStockExchange,
            RussianStockExchange,
            SwissExchange,
            TokyoStockExchange
        };
        #endregion

        /// <summary>
        /// Set the DataSource
        /// </summary>        
        public void SetDataSource(IBindingList holdings)
        {
            if (holdings != null)
            {
                this.grid.DataSource = null;
                this.grid.ResetTableDescriptor();
                this.grid.DataSource = holdings;
            }
        }

        /// <summary>
        /// Initialized the look and feel of the Grid
        /// </summary>
        private void CustomizeLookAndFeel()
        {
            //Enable GroupDropArea
            this.grid.ShowGroupDropArea = false;
            this.grid.BackColor = Color.White;

            //// Creating summaries in caption
            this.grid.ChildGroupOptions.ShowCaptionSummaryCells = true;
            this.grid.ChildGroupOptions.ShowSummaries = false;
            this.grid.ChildGroupOptions.CaptionSummaryRow = "Sum";
            this.grid.ChildGroupOptions.CaptionText = "{Category}";

            ////// Providing a good look and enabling CaptionSummaryCells as RecordFieldCells
            this.grid.Appearance.GroupCaptionCell.BackColor = Color.White;
            this.grid.Appearance.GroupCaptionCell.Borders.Top = new GridBorder(GridBorderStyle.Standard);
            this.grid.Appearance.GroupCaptionCell.CellType = "Static";
            this.grid.Appearance.GroupCaptionCell.WrapText = false;

            this.grid.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.grid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.grid.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.grid.TopLevelGroupOptions.ShowCaption = false;
            this.grid.TableOptions.CaptionRowHeight = 30;
            this.grid.Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle;

            this.grid.Appearance.AnyRecordFieldCell.Enabled = false;
            this.grid.Appearance.AnyRecordFieldCell.BackColor = Color.White;
            this.grid.Appearance.AnyIndentCell.BackColor = Color.White;
            this.grid.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            this.grid.TableOptions.ListBoxSelectionCurrentCellOptions = GridListBoxSelectionCurrentCellOptions.HideCurrentCell;
            this.grid.TableOptions.ListBoxSelectionCurrentCellOptions = GridListBoxSelectionCurrentCellOptions.None;
            this.grid.Appearance.GroupCaptionPlusMinusCell.BackColor = Color.White;
        }

        /// <summary>
        /// Set the Filters
        /// </summary>
        void SetFilter()
        {
            this.grid.TableDescriptor.RecordFilters.Add(new Syncfusion.Grouping.RecordFilterDescriptor("Open", Syncfusion.Grouping.FilterLogicalOperator.Or, new Syncfusion.Grouping.FilterCondition[] { new Syncfusion.Grouping.FilterCondition(Syncfusion.Grouping.FilterCompareOperator.Equals, "True") }));
        }

        /// <summary>
        /// Initialize the Schema for the Grid
        /// </summary>
        private void InitializeTableDescriptor()
        {
            this.grid.TableDescriptor.VisibleColumns.Clear();

            GridVisibleColumnDescriptor[] visibleColumns = new GridVisibleColumnDescriptor[] { 
                new GridVisibleColumnDescriptor("Open"),
                new GridVisibleColumnDescriptor("Quotes_Symbol"), 
                new GridVisibleColumnDescriptor("Quote_CompanyName"),                 
                new GridVisibleColumnDescriptor("PricePaid"), 
                new GridVisibleColumnDescriptor("Quantity"),
                new GridVisibleColumnDescriptor("Quote_Change"),
                new GridVisibleColumnDescriptor("Quote___Change"),
                new GridVisibleColumnDescriptor("MarketValue"),
                new GridVisibleColumnDescriptor("TotalReturn"),
                new GridVisibleColumnDescriptor("Quote___Change"),                
            };

            this.grid.TableDescriptor.Columns["Quotes_Symbol"].HeaderText = "Symbol";
            this.grid.TableDescriptor.Columns["Quote_CompanyName"].HeaderText = "Name";
            this.grid.TableDescriptor.Columns["Quote_Change"].HeaderText = "$";
            this.grid.TableDescriptor.Columns["Quote___Change"].HeaderText = "%";

            //Resize cols to fit
            grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;
            grid.Engine.TableOptions.ColumnsMaxLengthFirstNRecords = 100;

            this.grid.TableDescriptor.Columns["Quote_Change"].Width = 100;
            this.grid.TableDescriptor.Columns["Quote___Change"].Width = 80;
            this.grid.TableDescriptor.Columns["Quote_CompanyName"].Width = 100;
            this.grid.TableDescriptor.Columns["Open"].Width = 30;
            this.grid.TableDescriptor.Columns["MarketValue"].Width = 125;
            this.grid.TableDescriptor.Columns["TotalReturn"].Width = 125;

            this.grid.TableDescriptor.Columns["Quote_CompanyName"].Appearance.AnyRecordFieldCell.Trimming = StringTrimming.EllipsisCharacter;

            this.grid.TableDescriptor.VisibleColumns.AddRange(visibleColumns);

            //Remove from visible columns
            this.grid.TableDescriptor.VisibleColumns.Remove("Quote_Industry_Sector_SectorName");
            this.grid.TableDescriptor.VisibleColumns.Remove("Quote_Industry_IndusrtyName");

            //Add Stacked header
            GridStackedHeaderDescriptor stockDetails = new GridStackedHeaderDescriptor("StockDetails", "StockDetails");
            stockDetails.VisibleColumns.Add(new GridStackedHeaderVisibleColumnDescriptor("Open"));
            stockDetails.VisibleColumns.Add(new GridStackedHeaderVisibleColumnDescriptor("Quotes_Symbol"));
            stockDetails.VisibleColumns.Add(new GridStackedHeaderVisibleColumnDescriptor("Quote_CompanyName"));
            stockDetails.VisibleColumns.Add(new GridStackedHeaderVisibleColumnDescriptor("PricePaid"));
            stockDetails.VisibleColumns.Add(new GridStackedHeaderVisibleColumnDescriptor("Quantity"));

            GridStackedHeaderDescriptor changePerDay = new GridStackedHeaderDescriptor("ChangePerDay", "Change(day)");
            changePerDay.VisibleColumns.Add(new GridStackedHeaderVisibleColumnDescriptor("Quote_Change"));
            changePerDay.VisibleColumns.Add(new GridStackedHeaderVisibleColumnDescriptor("Quote___Change"));

            GridStackedHeaderDescriptor returnsAndValue = new GridStackedHeaderDescriptor("Returns and Value", "Returns and Value");
            returnsAndValue.VisibleColumns.Add(new GridStackedHeaderVisibleColumnDescriptor("TotalReturn"));
            returnsAndValue.VisibleColumns.Add(new GridStackedHeaderVisibleColumnDescriptor("MarketValue"));

            GridStackedHeaderRowDescriptor shrd = new GridStackedHeaderRowDescriptor("Row1",
            new GridStackedHeaderDescriptor[] { changePerDay, stockDetails, returnsAndValue });

            this.grid.TableDescriptor.StackedHeaderRows.Add(shrd);

            this.grid.TableModel.CellModels.Add("ImageButton", new GridPushButtonImageCellModel(this.grid.TableModel));
            this.grid.TableDescriptor.Columns["Open"].HeaderText = "Delete";
            this.grid.TableDescriptor.Columns["Open"].Appearance.AnyRecordFieldCell.CellType = "ImageButton";

            this.grid.TableDescriptor.Columns["PricePaid"].Appearance.AnyRecordFieldCell.Format = "##.##";
            this.grid.TableDescriptor.Columns["PricePaid"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Right;
            this.grid.TableDescriptor.Columns["Quantity"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Right;
            this.grid.TableDescriptor.Columns["Quantity"].Appearance.AnyRecordFieldCell.Format = "##.##";
            this.grid.TableDescriptor.Columns["Quote_Change"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Right;
            this.grid.TableDescriptor.Columns["Quote_Change"].Appearance.AnyRecordFieldCell.Format = "##.##";
            this.grid.TableDescriptor.Columns["Quote___Change"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Right;
            this.grid.TableDescriptor.Columns["Quote___Change"].Appearance.AnyRecordFieldCell.Format = "##.##";
            this.grid.TableDescriptor.Columns["TotalReturn"].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Right;
            this.grid.TableDescriptor.Columns["TotalReturn"].Appearance.AnyRecordFieldCell.Format = "##.##";
            this.grid.Table.ExpandAllGroups();
            this.grid.TableOptions.ShowTreeLines = true;
        }

        /// <summary>
        /// Sets up the Expression column
        /// </summary>
        private void SetupMarketValueExpression()
        {
            ExpressionFieldDescriptor marketValue = new ExpressionFieldDescriptor("MarketValue", "([Quote_Price] * [Quantity])", "System.Double");
            this.grid.TableDescriptor.ExpressionFields.Add(marketValue);

            ExpressionFieldDescriptor totalReturn = new ExpressionFieldDescriptor("TotalReturn", "([Quote_Price] * [Quantity] - [PricePaid] * [Quantity])", "System.Double");
            this.grid.TableDescriptor.ExpressionFields.Add(totalReturn);
        }
        /// <summary>
        /// Sets up the summaries
        /// </summary>
        private void AddSummariesToCaption()
        {
            //SummaryColumn for MarketValue
            GridSummaryColumnDescriptor marketValue = new GridSummaryColumnDescriptor("MarketValue", SummaryType.DoubleAggregate, "MarketValue", "(${Sum:##.00})");

            //SummaryColumn for totalReturn
            GridSummaryColumnDescriptor totalReturn = new GridSummaryColumnDescriptor("TotalReturn", SummaryType.DoubleAggregate, "TotalReturn", "(${Sum:##.00})");

            //SummaryColumn for DayChange (Custom summary)
            GridSummaryColumnDescriptor dayChange = new GridSummaryColumnDescriptor("DayChange", SummaryType.Custom, "Quote_Change", "{DayChangeTotal:##.00}");

            //SummaryColumn for totalReturnPercent
            GridSummaryColumnDescriptor dayChangePercent = new GridSummaryColumnDescriptor("Quote___Change", SummaryType.DoubleAggregate, "Quote___Change", "{Average:##.00}%");

            this.grid.QueryCustomSummary += new GridQueryCustomSummaryEventHandler(gridGroupingControl1_QueryCustomSummary);

            //Create a summary row and add the summary columns
            GridSummaryRowDescriptor srd = new GridSummaryRowDescriptor("Sum", "$", new GridSummaryColumnDescriptor[] { marketValue, dayChange, totalReturn, dayChangePercent });
            srd.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right;

            //Add the summary row to the Grid
            this.grid.TableDescriptor.SummaryRows.Add(srd);
        }

        public void RefreshView()
        {
            this.grid.SuspendLayout();
            this.grid.BeginUpdate();
            this.grid.TableControl.BeginUpdate();

            switch (GridView)
            {
                case GridViewType.Overview:
                    this.grid.TableDescriptor.GroupedColumns.Clear();
                    this.grid.TableDescriptor.Columns["Quote_CompanyName"].Width = 150;
                    this.grid.TableDescriptor.GroupedColumns.Add("Account_AccountName");
                    this.grid.Table.CollapseAllRecords();
                    break;

                case GridViewType.DetailView:
                    this.grid.TableDescriptor.GroupedColumns.Clear();
                    this.grid.TableDescriptor.Columns["Quote_CompanyName"].Width = 100;
                    this.grid.TableDescriptor.GroupedColumns.Add("Account_AccountName");
                    //Group by sector and industry
                    this.grid.TableDescriptor.GroupedColumns.Add("Quote_Industry_Sector_SectorName");
                    this.grid.TableDescriptor.GroupedColumns.Add("Quote_Industry_IndusrtyName");
                    this.grid.Table.ExpandAllGroups();
                    break;

                case GridViewType.SectorIndustryView:
                    this.grid.TableDescriptor.GroupedColumns.Clear();
                    this.grid.TableDescriptor.Columns["Quote_CompanyName"].Width = 100;
                    //Group by sector and industry
                    this.grid.TableDescriptor.GroupedColumns.Add("Quote_Industry_Sector_SectorName");
                    this.grid.TableDescriptor.GroupedColumns.Add("Quote_Industry_IndusrtyName");
                    this.ExpandGroups(this.grid.Table.TopLevelGroup);
                    break;

                case GridViewType.CountryView:
                    this.grid.TableDescriptor.GroupedColumns.Clear();
                    this.grid.TableDescriptor.Columns["Quote_CompanyName"].Width = 100;
                    this.grid.TableDescriptor.GroupedColumns.Add("StockExchange_StockExchangeName");
                    break;

                default:
                    break;
            }

            this.grid.ResumeLayout();
            this.grid.EndUpdate(true);
            this.grid.TableControl.EndUpdate();
        }

        private void ExpandGroups(Group g)
        {
            if (g.Groups.Count > 0)
                g.IsExpanded = true;

            foreach (Record r in g.Records)
            {
                r.IsExpanded = false;
            }
            foreach (Group gr in g.Groups)
            {
                ExpandGroups(gr);
            }
        }

        private void WireEvents()
        {
            this.grid.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(QueryCellStyleInfoHandler);
            this.grid.QueryCoveredRange += new GridTableQueryCoveredRangeEventHandler(QueryCoveredRangeHandler);
            this.grid.TableControlPushButtonClick += new GridTableControlCellPushButtonClickEventHandler(grid_TableControlPushButtonClick);
        }

        private string GetEnum(string value)
        {
            string enumStr = "";

            for (int i = 0; i < value.Length; i++)
            {
                if ((value[i] >= 'A' && value[i] <= 'Z') || (value[i] >= 'a' && value[i] <= 'z'))
                    enumStr += value[i];
            }
            return enumStr;
        }
        #endregion

        #region Event handlers
        void grid_TableControlPushButtonClick(object sender, GridTableControlCellPushButtonClickEventArgs e)
        {
            Element el = this.grid.Table.DisplayElements[e.Inner.RowIndex];
            if (el.Kind == DisplayElementKind.Record)
                el.GetRecord().Delete();
        }

        void TableModel_QueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            GridTableModel gridModel = sender as GridTableModel;
            GridTableControl gridControl = (GridTableControl)gridModel.ActiveGridView;

            //Keep the Frozen columns size fixed
            if (gridModel != null && gridControl != null)
            {
                int fieldIndex = this.grid.TableDescriptor.ColIndexToField(e.Index);
                int indentCols = 0;
                if (fieldIndex > this.grid.TableDescriptor.GetFrozenColumnCount() - 1)
                {
                    int gridWidth = grid.ClientSize.Width;

                    int stockdetailsWidth = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        stockdetailsWidth += this.grid.TableDescriptor.Columns[i].Width;
                    }

                    int availableArea = gridControl.ClientSize.Width - indentCols - stockdetailsWidth;
                    e.Size = (int)availableArea / (grid.TableDescriptor.VisibleColumns.Count - 3);
                    e.Handled = true;
                }
            }
        }

        void QueryCoveredRangeHandler(object sender, GridTableQueryCoveredRangeEventArgs e)
        {
            GridTable thisTable = this.grid.Table;
            if (e.RowIndex < thisTable.DisplayElements.Count)
            {
                Element el = thisTable.DisplayElements[e.RowIndex];

                this.captionCoverCols = 4;

                switch (el.Kind)
                {
                    case DisplayElementKind.Caption:
                        {
                            // Cover some cells of the caption bar (specified with captionCover)
                            IGridGroupOptionsSource gs = el.ParentGroup as IGridGroupOptionsSource;
                            if (gs != null && gs.GroupOptions.ShowCaptionSummaryCells)
                            {
                                int startCol = el.GroupLevel + 1;

                                if (!gs.GroupOptions.ShowCaptionPlusMinus)
                                    startCol--;

                                this.captionCoverCols += (this.grid.TableDescriptor.GroupedColumns.Count - el.GroupLevel);

                                if (e.ColIndex >= startCol && e.ColIndex <= startCol + this.captionCoverCols)
                                {
                                    e.Range = GridRangeInfo.Cells(e.RowIndex, startCol, e.RowIndex, startCol + this.captionCoverCols);
                                    e.Handled = true;
                                }
                            }
                            break;

                        }
                }
            }
        }

        void gridGroupingControl1_QueryCustomSummary(object sender, GridQueryCustomSummaryEventArgs e)
        {
            if (e.SummaryColumn.Name == "DayChange")
            {
                e.SummaryDescriptor.CreateSummaryMethod = new CreateSummaryDelegate(DayChangeSummary.CreateSummaryMethod);
            }
        }

        void QueryCellStyleInfoHandler(object sender, GridTableCellStyleInfoEventArgs e)
        {
            if (e.TableCellIdentity.DisplayElement.Kind == DisplayElementKind.Caption)
            {
                if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupCaptionCell)
                {
                    if (e.TableCellIdentity.DisplayElement.ParentGroup.Category != null)
                    {
                        string AccountName = e.TableCellIdentity.DisplayElement.ParentGroup.Category.ToString();
                        if (this.GridView == GridViewType.Overview)
                        {
                            e.Style.CellType = "Static";
                            e.Style.Enabled = false;
                        }
                        string enumStr = GetEnum(AccountName);

                        if (Enum.IsDefined(typeof(StockIcons16), enumStr))
                        {
                            e.Style.ImageList = images16;
                            e.Style.ImageIndex = (int)Enum.Parse(typeof(StockIcons16), enumStr);
                        }
                        else
                        {
                            e.Style.ImageList = images24;
                            e.Style.ImageIndex = (int)Enum.Parse(typeof(StockIcons24), enumStr);
                        }
                    }
                }

                if (e.TableCellIdentity.TableCellType == GridTableCellType.GroupCaptionSummaryCell)
                {
                    GridTableCellStyleInfo style = e.Style as GridTableCellStyleInfo;

                    if (e.TableCellIdentity.SummaryColumn != null)
                    {
                        if (e.TableCellIdentity.SummaryColumn.Name == "TotalReturn" || e.TableCellIdentity.SummaryColumn.Name == "DayChange")
                        {
                            e.Style.ImageList = (ImageList)this.imageList;
                            e.Style.ImageSizeMode = GridImageSizeMode.CenterImage;
                            e.Style.VerticalAlignment = GridVerticalAlignment.Middle;
                            e.Style.HorizontalAlignment = GridHorizontalAlignment.Center;

                            //Get the summaries from other expression to compare
                            Double summaryValue = 0;
                            if (e.TableCellIdentity.SummaryColumn.Name == "TotalReturn")
                                Double.TryParse(GridEngine.GetSummaryText(e.TableCellIdentity.DisplayElement.ParentGroup, "Sum", "TotalReturn"), out summaryValue);
                            else
                                Double.TryParse(GridEngine.GetSummaryText(e.TableCellIdentity.DisplayElement.ParentGroup, "Sum", "DayChange"), out summaryValue);

                            if (summaryValue < 0)
                            {
                                e.Style.TextColor = Color.Red;
                                e.Style.ImageIndex = 2;
                            }
                            else
                            {
                                e.Style.TextColor = Color.Green;
                                e.Style.ImageIndex = 3;
                            }
                        }
                    }
                }
            }
        }
        #endregion
       
    }
}