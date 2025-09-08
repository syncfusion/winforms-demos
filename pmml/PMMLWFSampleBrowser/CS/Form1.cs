#region Copyright Syncfusion Inc. 2001 - 2014

// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.

#endregion Copyright Syncfusion Inc. 2001 - 2014

using Syncfusion.Grouping;
using Syncfusion.Install.Utils;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PMMLWFSampleBrowser
{
    public partial class Form1 : MetroForm
    {
        private BackgroundWorker bgWorker;
        private TreeMenuItemAdv treeMenuItemAdv;
        private bool IsExpanded;
        private IDisplayFeedback feedback = null;
        double result=0.0;
#if NETCORE
        private string ConfigPath = "Config.xml";
#else
        private string ConfigPath = "../../Config.xml";
#endif

        int _pageCount;
        int _maxRec;
        int _pageSize = 26;
        int _currentPage;
        int _recNo;
        private DataTable inputDataTable;
        private DataTable tempInputDataTable;
        private readonly Label _myLabel = new Label();
        private Engine _engine;
        string pmmlPath = string.Empty,
               outputPath = string.Empty,
               samplePath = string.Empty,
               inputpath = string.Empty,
               sourcePath = string.Empty,
               rScriptPath = string.Empty;
        string currentSampleName = string.Empty;
        string currentModelName = string.Empty;
        string currentPmmlPath = string.Empty;
        string prevSampleName = string.Empty;
        public Form1()
        {
            InitializeComponent();
            LoadTreeView();

            this.cSharpCode.Configurator.Open(ConfigPath);
            this.cSharpCode.ApplyConfiguration("C#");

            this.rCode.Configurator.Open(ConfigPath);
            this.rCode.ApplyConfiguration("R");

            this.pmmlCode.Configurator.Open(ConfigPath);
            this.pmmlCode.ApplyConfiguration("XML");
            this.tabControl1.Visible = false;
            this.treeNavigator.SelectionChanged += new SelectionStateChangedEventHandler(treeNavigator1_SelectionChanged);

            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += bgWorker_DoWork;
            bgWorker.RunWorkerCompleted += bgWorker_RunWorkerCompleted;
            PredictedResult.TableModel.QueryColWidth += TableModel_QueryColWidth;

            this.Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            var model = (TreeMenuItemAdv)treeNavigator.Items[0];

            var sample = (TreeMenuItemAdv)model.Items[0];
           
            this.treeNavigator.BeginInvoke(new System.Action(() =>
            {
                this.treeNavigator.SelectedItem = sample;
            }));
            this.LoadSample(sample.ModelName, sample.SampleName, sample.SamplePath);
            BeginInvoke(new System.Action(() =>
            {
                this.tabControl1.Visible = true;
            }));
       }

        private int totalWidth = 0;
        private void TableModel_QueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            if (e.Index == this.PredictedResult.TableDescriptor.VisibleColumns.Count)
            {
                int tempWidth = this.PredictedResult.TableModel.ColWidths.GetTotal(0,
                    this.PredictedResult.TableDescriptor.VisibleColumns.Count - 1);
                if (totalWidth > 0 && totalWidth <= this.PredictedResult.ClientSize.Width)
                {
                    if (this.PredictedResult.ClientSize.Width - tempWidth > 0)
                    {
                        e.Size = (this.PredictedResult.ClientSize.Width
                            - tempWidth) - 15;
                        e.Handled = true;
                    }
                }
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            feedback.Close();
            this.treeNavigator.SelectedItem = null;
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (this.treeMenuItemAdv != null)
            {
                if (treeMenuItemAdv.IsModel)
                {
                    if (IsExpanded)
                    {
                        var sample = (TreeMenuItemAdv)treeMenuItemAdv.Items[0];
                        this.treeNavigator.BeginInvoke(new System.Action(() =>
                            {
                                this.treeNavigator.SelectedItem = sample;
                            }));                        
                        this.LoadSample(sample.ModelName, sample.SampleName, sample.SamplePath);
                        BeginInvoke(new System.Action(() =>
                        {
                            this.tabControl1.Visible = true;
                        }));
                    }
                    else
                    {
                        BeginInvoke(new System.Action(() =>
                        {
                            treeMenuItemAdv.Selected = false;
                            this.tabControl1.Visible = true;
                        }));
                    }                    
                }
                else if (!string.IsNullOrEmpty(treeMenuItemAdv.SampleName))
                {
                    BeginInvoke(new System.Action(() =>
                    {
                        this.tabControl1.Visible = true;
                    }));
                    this.LoadSample(treeMenuItemAdv.ModelName, treeMenuItemAdv.SampleName, treeMenuItemAdv.SamplePath);
                }
            }
        }

        private void LoadTreeView()
        {
#if NETCORE
            var path = string.Format(@"..\..\..\..\..\Samples.xml");
#else
            var path = string.Format(@"..\..\..\..\Samples.xml");
#endif

            if (File.Exists(path))
            {
                StreamReader streamreader = new StreamReader(path);
                XDocument document = XDocument.Load(streamreader);
                int count = 0;

                foreach (XElement models in document.Descendants(XName.Get("Model")))
                {
                    string modelName = models.Attribute(XName.Get("Name")) != null ? models.Attribute(XName.Get("Name")).Value.ToString() : string.Empty;
                    string modelTag = models.Attribute(XName.Get("Tag")) != null ? models.Attribute(XName.Get("Tag")).Value.ToString() : string.Empty;
                    treeMenuItem = new TreeMenuItemAdv();
                    treeMenuItem.ModelName = modelName;
                    treeMenuItem.Name = modelName;
                    treeMenuItem.IsModel = true;
                    treeMenuItem.ModelTag = modelTag;
                    treeNavigator.Items.Add(treeMenuItem);

                    foreach (XElement samples in models.Descendants(XName.Get("Sample")))
                    {
                        string sampleName = samples.Attribute(XName.Get("Name")) != null ? samples.Attribute(XName.Get("Name")).Value.ToString() : string.Empty;
                        string samplePath = samples.Attribute(XName.Get("SamplePath")) != null ?
                           samples.Attribute(XName.Get("SamplePath")).Value.ToString() : string.Empty;
                        string sampleTag = samples.Attribute(XName.Get("Tag")) != null ? samples.Attribute(XName.Get("Tag")).Value.ToString() : string.Empty;
                        var subtreeMenuItem = new TreeMenuItemAdv();
                        subtreeMenuItem.SampleName = sampleName;
                        subtreeMenuItem.SamplePath = samplePath;
                        subtreeMenuItem.SampleTag = sampleTag;
                        subtreeMenuItem.ModelName = modelName;
                        subtreeMenuItem.Name = sampleName;
                        treeMenuItem.Items.Add(subtreeMenuItem);
                    }
                    count++;
                }
            }
        }    

        private void treeNavigator1_SelectionChanged(TreeNavigator sender, SelectionStateChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {                
                treeMenuItemAdv = e.SelectedItem as TreeMenuItemAdv;

                if(treeMenuItemAdv.SampleName !=null)
                {
                    PredictedResult.DataSource = null;
                    prevSampleName = treeMenuItemAdv.SampleName;
                }

                this.sampleName.Text = treeMenuItemAdv.SampleName != null ? treeMenuItemAdv.ModelName + " / " + treeMenuItemAdv.SampleName
                    : treeMenuItemAdv.ModelName + " / " + prevSampleName;

                IsExpanded = e.Expanded;
                if (!IsExpanded && feedback != null && !System.Threading.Thread.CurrentThread.IsAlive)
                {
                    feedback.Close();
                }
                if (!bgWorker.IsBusy)
                {
                    feedback = new FeedbackForm();
                    feedback.Show();
                    bgWorker.RunWorkerAsync();
                }
            }
        }

        private void LoadSample(string modelName, string sampleName, string selectedSamplePath)
        {
#if NETCORE
            var path = string.Format(@"..\..\..\..\..\..\Common\\Analytics");
#else
            var path = string.Format(@"..\..\..\..\..\Common\\Analytics");
#endif

            samplePath = string.Format("{0}\\{1}\\", path, selectedSamplePath);
            sourcePath = samplePath + "Program.cs";
            if (File.Exists(sourcePath))
            {
                BeginInvoke(new System.Action(() =>
                    {
                        cSharpCode.Text = File.ReadAllText(sourcePath);
                        this.cSharpCode.CurrentLine = 1;
                    }));
            }
            samplePath += "Model\\";
            outputPath = samplePath + "ROutput.csv";
            pmmlPath = string.Format("{0}{1}.pmml", samplePath, sampleName);
            rScriptPath = string.Format("{0}{1}.R", samplePath, sampleName);
            currentSampleName = sampleName;
            currentModelName = modelName;
            currentPmmlPath = pmmlPath;
            switch (modelName)
            {
                case "General Regression":
                    LoadGeneralRegressionSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Naive Bayes":
                    LoadNaiveBayesSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Random Forest":
                    LoadRandomForestSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Regression":
                    LoadRegressionSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Support Vector Machine":
                    LoadSupportVectorMachineSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Tree Model":
                    LoadTreeModelSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Clustering Model":
                    LoadClusteringSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Neural Networks":
                    LoadNeuralNetworksSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Multinomial Regression":
                    LoadMultinomialSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Cox Regression":
                    LoadCoxRegressionSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Gradient Boosting":
                    LoadGradientBoostingSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

                case "Association Rules":
                    LoadAssociationRulesSample(sampleName, samplePath, inputpath, pmmlPath, outputPath);
                    break;

            }
            if (File.Exists(rScriptPath))
            {
                BeginInvoke(new System.Action(() =>
                {
                    rCode.Text = File.ReadAllText(rScriptPath);
                    this.rCode.CurrentLine = 1;
                }));
            }
            
        }
       

        private Syncfusion.PMML.Table outputTable = null;
        private Syncfusion.PMML.Table inputTable = null;
        private Syncfusion.PMML.Table tempTable = null;

        /// <summary>
        /// Merge the DataSet input dataTable and outputTable
        /// </summary>
        /// <param name="inputDataTable"></param>
        /// <param name="outputTable"></param>
        /// <returns></returns>
        private DataTable MergeTable(DataTable inputDataTable, Syncfusion.PMML.Table outputTable)
        {
            var columnEnumarator = outputTable.ColumnNames.GetEnumerator();

            while (columnEnumarator.MoveNext())
            {
                var column = new DataColumn() { ColumnName = columnEnumarator.Current.ToString() };
                inputDataTable.Columns.Add(column);
            }

            for (int i = 0; i < inputDataTable.Rows.Count; i++)
            {
                for (int j = 0; j < outputTable.ColumnNames.Length; j++)
                {
                    inputDataTable.Rows[i].SetField(outputTable.ColumnNames[j], outputTable[i, j]);
                }
            }

            return inputDataTable;
        }

        /// <summary>
        /// Load the general regression model samples
        /// </summary>
        /// <param name="sampleName">sample name </param>
        /// <param name="samplePath">sample file path</param>
        /// <param name="inputPath">inut file path</param>
        /// <param name="pmmlPath">pmml file path</param>
        /// <param name="outputPath">output file path</param>
        private void LoadGeneralRegressionSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "WineLog":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WineIdentity":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TitanicLogit":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Titanic");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TitanicCloglog":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Titanic");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "GlassCloglog":
                    inputPath = samplePath + "Glass.csv";
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Glass");
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "GlassLogit":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Glass");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzoneLog":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzoneIdentity":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsIdentity":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsIdentity":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsIdentity":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerLogitRegression":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerCloglogRegression":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerCloglogClassification":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerLogitClassification":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "AuditLogitRegression":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Audit");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "AuditLogitClassification":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Audit");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "IrisLogit":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Iris");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "IrisCloglog":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Iris");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "AuditBinomialProbitClassification":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Audit");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "AuditQuasibinomialProbitRegression":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Audit");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerBinomialProbitClassification":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerGaussianInverseRegression":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerQuasiInverseRegression":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerQuasibinomialProbitRegression":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerQuasipoissonInverseRegression":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerQuasipoissonProbitRegression":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    currentPmmlPath = pmmlPath;
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsGammaInverse":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsInverseGaussian":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsQuasiInverse":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsQuasiSqrt":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "GlassBinomialProbit":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Glass");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "GlassQuasibinomialProbit":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Glass");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsGammaInverse":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsGaussianInverse":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsInverseGaussian":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsNegativeBinomialSqrt":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsPoissonSqrt":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsQuasiInverse":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsQuasiSqrt":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "IrisBinomialProbit":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Iris");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "IrisQuasibinomialProbit":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Iris");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzoneGammaInverse":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzoneGaussianInverse":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzonePoissonSqrt":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzoneQuasiInverse":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzoneQuasiSqrt":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzoneQuasipoissonSqrt":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsGammaInverse":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsGaussianInverse":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsInverseGaussian":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsQuasiInverse":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsQuasiSqrt":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsQuasipoissonProbit":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TitanicBinomialProbit":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Titanic");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TitanicQuasibinomialProbit":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                     pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Titanic");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WineGammaInverse":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                     rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WineInverseGaussian":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                     rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WinePoissonSqrt":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                     rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WineQuasiInverse":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                     rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WineQuasiSqrt":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                     rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WineQuasipoissonInverse":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WineQuasipoissonSqrt":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }
            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }

        /// <summary>
        /// Load the naive bayes model samples
        /// </summary>
        /// <param name="sampleName">sample name </param>
        /// <param name="samplePath">sample file path</param>
        /// <param name="inputPath">inut file path</param>
        /// <param name="pmmlPath">pmml file path</param>
        /// <param name="outputPath">output file path</param>
        private void LoadNaiveBayesSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "Audit":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancer":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Imports":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Iris":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Titanic":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Wine":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }
            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }

        /// <summary>
        /// Load the random forest model samples
        /// </summary>
        /// <param name="sampleName">sample name </param>
        /// <param name="samplePath">sample file path</param>
        /// <param name="inputPath">inut file path</param>
        /// <param name="pmmlPath">pmml file path</param>
        /// <param name="outputPath">output file path</param>
        private void LoadRandomForestSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "Audit":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancer":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Cars":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Glass":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Imports":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Iris":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Ozone":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Tips":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Titanic":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Wine":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }
            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }

        /// <summary>
        /// Load the regression model samples
        /// </summary>
        /// 
        /// <param name="sampleName">sample name </param>
        /// <param name="samplePath">sample file path</param>
        /// <param name="inputPath">inut file path</param>
        /// <param name="pmmlPath">pmml file path</param>
        /// <param name="outputPath">output file path</param>
        private void LoadRegressionSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "Cars":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Imports":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Ozone":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Tips":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }
            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }

        /// <summary>
        /// Load the support vector machine model samples
        /// </summary>
        /// <param name="sampleName">sample name </param>
        /// <param name="samplePath">sample file path</param>
        /// <param name="inputPath">inut file path</param>
        /// <param name="pmmlPath">pmml file path</param>
        /// <param name="outputPath">output file path</param>
        private void LoadSupportVectorMachineSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "AuditLinear":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Audit");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "AuditPolynomial":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Audit");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "AuditRadial":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Audit");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "AuditSigmoid":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Audit");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerLinear":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerPolynomial":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerRadial":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerSigmoid":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsLinear":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsPolynomial":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsRadial":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsSigmoid":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "GlassLinear":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Glass");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "GlassPolynomial":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Glass");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "GlassRadial":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Glass");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "GlassSigmoid":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Glass");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsLinear":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsPolynomial":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsRadial":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsSigmoid":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "IrisLinear":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Iris");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "IrisPolynomial":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Iris");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "IrisRadial":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Iris");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "IrisSigmoid":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Iris");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzoneLinear":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzonePolynomial":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzoneRadial":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "OzoneSigmoid":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Ozone");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsLinear":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsPolynomial":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsRadial":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsSigmoid":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TitanicLinear":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Titanic");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TitanicPolynomial":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Titanic");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TitanicRadial":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Titanic");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TitanicSigmoid":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Titanic");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WineLinear":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WinePolynomial":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WineRadial":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "WineSigmoid":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Wine");
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }

            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }

        /// <summary>
        /// Load the tree model samples
        /// </summary>
        /// <param name="sampleName">sample name </param>
        /// <param name="samplePath">sample file path</param>
        /// <param name="inputPath">inut file path</param>
        /// <param name="pmmlPath">pmml file path</param>
        /// <param name="outputPath">output file path</param>
        private void LoadTreeModelSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "Audit":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancer":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Cars":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Glass":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Imports":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Iris":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Ozone":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Tips":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Titanic":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Wine":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }

            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }

        /// <summary>
        /// Method to load Cox Regression Model Samples
        /// </summary>
        /// <param name="samplePath">sample path</param>
        /// <param name="inputPath">input path</param>
        /// <param name="pmmlPath">pmml path</param>
        /// <param name="outputPath">output path</param>
        private void LoadCoxRegressionSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "Aml":
                    inputPath = samplePath + "Aml.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Bfeed":
                    inputPath = samplePath + "Bfeed.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Larynx":
                    inputPath = samplePath + "Larynx.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Lung":
                    inputPath = samplePath + "Lung.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Ovarian":
                    inputPath = samplePath + "Ovarian.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Rats":
                    inputPath = samplePath + "Rats.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }
            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }
        
        /// <summary>
        /// Method to load Multinomial Regression Model Samples
        /// </summary>
        /// <param name="samplePath">sample path</param>
        /// <param name="inputPath">input path</param>
        /// <param name="pmmlPath">pmml path</param>
        /// <param name="outputPath">output path</param>
        private void LoadMultinomialSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "Audit":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancer":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Glass":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Iris":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Titanic":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Wine":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }
            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }

        /// <summary>
        /// Method to load Neural Network Samples
        /// </summary>
        /// <param name="samplePath">sample path</param>
        /// <param name="inputPath">input path</param>
        /// <param name="pmmlPath">pmml path</param>
        /// <param name="outputPath">output path</param>
        private void LoadNeuralNetworksSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "Audit":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancer":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Cars":
                    inputPath = samplePath + "Cars.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Glass":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Imports":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Iris":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Ozone":
                    inputPath = samplePath + "Ozone.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Tips":
                    inputPath = samplePath + "Tips.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Titanic":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Wine":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }
            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }

        /// <summary>
        /// Method to load Clustering Model Samples
        /// </summary>
        /// <param name="samplePath">sample path</param>
        /// <param name="inputPath">input path</param>
        /// <param name="pmmlPath">pmml path</param>
        /// <param name="outputPath">output path</param>
        private void LoadClusteringSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "Audit":
                    inputPath = samplePath + "Audit.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancer":
                    inputPath = samplePath + "BreastCancer.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Glass":
                    inputPath = samplePath + "Glass.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Iris":
                    inputPath = samplePath + "Iris.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Titanic":
                    inputPath = samplePath + "Titanic.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Wine":
                    inputPath = samplePath + "Wine.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }
            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }
    
        /// <summary>
        /// Load the Gradient Boosting Machine model samples
        /// </summary>
        /// <param name="sampleName">sample name </param>
        /// <param name="samplePath">sample file path</param>
        /// <param name="inputPath">inut file path</param>
        /// <param name="pmmlPath">pmml file path</param>
        /// <param name="outputPath">output file path</param>
        private void LoadGradientBoostingSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {
            switch (sampleName)
            {
                case "AuditBernoulli":
                    inputPath = samplePath + "Audit.csv";                    
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();                    
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Audit");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BfeedCoxph":
                    inputPath = samplePath + "Bfeed.csv";                    
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Bfeed");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Bfeed");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerAdaboost":
                    inputPath = samplePath + "BreastCancer.csv";                    
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "BreastCancerHuberized":
                    inputPath = samplePath + "BreastCancer.csv";                    
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "BreastCancer");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsLaplace":
                    inputPath = samplePath + "Cars.csv";                    
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "CarsTdist":
                    inputPath = samplePath + "Cars.csv";                    
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Cars");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsPairwise":
                    inputPath = samplePath + "Imports.csv";                    
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsPoisson":
                    inputPath = samplePath + "Imports.csv";                    
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "ImportsQuantile":
                    inputPath = samplePath + "Imports.csv";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Imports");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "TipsGaussian":
                    inputPath = samplePath + "Tips.csv";                    
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, ',');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Tips");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;
            }
            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));
        }
              
        /// <summary>
        /// Load the Associate rules model samples
        /// </summary>
        /// <param name="sampleName">sample name</param>
        /// <param name="samplePath">sample file path</param>
        /// <param name="inputPath">input file path</param>
        /// <param name="pmmlPath">pmml file path</param>
        /// <param name="outputPath">output file path</param>
        private void LoadAssociationRulesSample(string sampleName, string samplePath, string inputPath, string pmmlPath, string outputPath)
        {

            switch(sampleName)
            {
                case "Adult":
                    inputPath = samplePath + "Adult.txt";                    
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, '\t');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Adult");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Adult");
                    InitializePager();                  
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable,currentModelName);
                    break;

                case "Epub":
                    inputPath = samplePath + "Epub.txt";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, '\t');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Epub");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Epub");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable, currentModelName);
                    break;

                case "Groceries":
                    inputPath = samplePath + "Groceries.txt";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, '\t');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Groceries");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Groceries");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable, currentModelName);
                    break;

                case "Income":
                    inputPath = samplePath + "Income.txt";
                    inputTable = new Syncfusion.PMML.Table(inputPath, true, '\t');
                    inputDataTable = inputTable.ConvertToDataTable();
                    pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Income");
                    rScriptPath = string.Format("{0}{1}.R", samplePath, "Income");
                    InitializePager();
                    LoadTempInputTable(currentSampleName, pmmlPath, inputDataTable, currentModelName);
                    break;
            }

            BeginInvoke(new System.Action(() =>
            {
                pmmlCode.Text = File.ReadAllText(pmmlPath);
                this.pmmlCode.CurrentLine = 1;
            }));

        }

        /// <summary>
        /// convert dataTable into Syncfusion.PMML.Table
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        private Syncfusion.PMML.Table ConvertToTable(System.Data.DataTable dataTable)
        {
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                tempTable.ColumnNames[i] = dataTable.Columns[i].ToString();
            }
        
            for (int j = 0; j < dataTable.Rows.Count; j++)
            {
                for (int k = 0; k < tempTable.ColumnCount; k++)
                {
                   tempTable[j, k] = dataTable.Rows[j].ItemArray[k].ToString();
                }
            }
            return tempTable;
        }

        /// <summary>
        /// Load the inputTable and process the Predicted Result
        /// </summary>
        /// <param name="sampleName"></param>
        /// <param name="pmmlPath"></param>
        /// <param name="inputDataTable"></param>
        /// <param name="modelName"></param>
        private void LoadTempInputTable(string sampleName, string pmmlPath, DataTable inputDataTable, string modelName)
        {
            switch(modelName)
            {
                case "General Regression":
                    switch (sampleName)
                    {
                        case "WineLog":
                            WineLog.Program wineLogProgram = new WineLog.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");                    
                            outputTable = wineLogProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WineIdentity":
                            WineIdentity.Program wineIdentityProgram = new WineIdentity.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine");                    
                            outputTable = wineIdentityProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TitanicLogit":
                            TitanicLogit.Program titanicLogitProgram = new TitanicLogit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic"); 
                            outputTable = titanicLogitProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TitanicCloglog":
                            TitanicCloglog.Program titanicCloglogProgram = new TitanicCloglog.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic"); 
                            outputTable = titanicCloglogProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "GlassCloglog":
                            GlassCloglog.Program glassCloglogProgram = new GlassCloglog.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass"); 
                            outputTable = glassCloglogProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "GlassLogit":
                            GlassLogit.Program glassLogitProgram = new GlassLogit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass"); 
                            outputTable = glassLogitProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzoneLog":
                            OzoneLog.Program ozoneLogProgram = new OzoneLog.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozoneLogProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzoneIdentity":
                            OzoneIdentity.Program ozoneIdentityProgram = new OzoneIdentity.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozoneIdentityProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsIdentity":
                            TipsIdentity.Program tipsIdentityProgram = new TipsIdentity.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsIdentityProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsIdentity":
                            ImportsIdentity.Program importsIdentityProgram = new ImportsIdentity.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsIdentityProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsIdentity":
                            CarsIdentity.Program carsIdentityProgram = new CarsIdentity.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars"); 
                            outputTable = carsIdentityProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerLogitRegression":
                            BreastCancerLogitRegression.Program bcLogitRegressionProgram = new BreastCancerLogitRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                            outputTable = bcLogitRegressionProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerCloglogRegression":
                            BreastCancerCloglogRegression.Program bcCloglogRegressionProgram = new BreastCancerCloglogRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                               pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");                    
                            outputTable = bcCloglogRegressionProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerCloglogClassification":
                            BreastCancerCloglogClassification.Program bcCloglogClassificationProgram = new BreastCancerCloglogClassification.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");                    
                            outputTable = bcCloglogClassificationProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerLogitClassification":
                            BreastCancerLogitClassification.Program bcLogitClassificationProgram = new BreastCancerLogitClassification.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                            outputTable = bcLogitClassificationProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "AuditLogitRegression":
                            AuditLogitRegression.Program auditLogitRegressionProgram = new AuditLogitRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");                    
                            outputTable = auditLogitRegressionProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "AuditLogitClassification":
                            AuditLogitClassification.Program auditLogitClassificationProgram = new AuditLogitClassification.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");                    
                            outputTable = auditLogitClassificationProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "IrisLogit":
                            IrisLogit.Program irisLogitProgram = new IrisLogit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris"); 
                            outputTable = irisLogitProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "IrisCloglog":
                            IrisCloglog.Program irisCloglogProgram = new IrisCloglog.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris"); 
                            outputTable = irisCloglogProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "AuditBinomialProbitClassification":
                            AuditBinomialProbitClassification.Program auditBinomialProbitClassificationProgram = new AuditBinomialProbitClassification.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                            outputTable = auditBinomialProbitClassificationProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "AuditQuasibinomialProbitRegression":
                            AuditQuasibinomialProbitRegression.Program auditQuasibinomialProbitClassificationProgram = new AuditQuasibinomialProbitRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                            outputTable = auditQuasibinomialProbitClassificationProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerBinomialProbitClassification":
                            BreastCancerBinomialProbitClassification.Program breastCancerBinomialProbitClassificationProgram = new BreastCancerBinomialProbitClassification.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                            outputTable = breastCancerBinomialProbitClassificationProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerGaussianInverseRegression":
                            BreastCancerGaussianInverseRegression.Program breastCancerGaussianInverseRegressionProgram = new BreastCancerGaussianInverseRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                            outputTable = breastCancerGaussianInverseRegressionProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerQuasiInverseRegression":
                            BreastCancerQuasiInverseRegression.Program breastCancerQuasiInverseRegressionProgram = new BreastCancerQuasiInverseRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                            outputTable = breastCancerQuasiInverseRegressionProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerQuasibinomialProbitRegression":
                            BreastCancerQuasibinomialProbitRegression.Program breastCancerQuasibinomialProbitClassificationProgram = new BreastCancerQuasibinomialProbitRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                            outputTable = breastCancerQuasibinomialProbitClassificationProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerQuasipoissonInverseRegression":
                            BreastCancerQuasipoissonInverseRegression.Program breastCancerQuasipoissonInverseRegressionProgram = new BreastCancerQuasipoissonInverseRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                            outputTable = breastCancerQuasipoissonInverseRegressionProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerQuasipoissonProbitRegression":
                            BreastCancerQuasipoissonProbitRegression.Program breastCancerQuasipoissonProbitRegressionProgram = new BreastCancerQuasipoissonProbitRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                            outputTable = breastCancerQuasipoissonProbitRegressionProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsGammaInverse":
                            CarsGammaInverse.Program carsGammaInverseProgram = new CarsGammaInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars"); 
                            outputTable = carsGammaInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsInverseGaussian":
                            CarsInverseGaussian.Program carsInverseGaussianProgram = new CarsInverseGaussian.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars"); 
                            outputTable = carsInverseGaussianProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsQuasiInverse":
                            CarsQuasiInverse.Program carsQuasiInverseProgram = new CarsQuasiInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars"); 
                            outputTable = carsQuasiInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsQuasiSqrt":
                            CarsQuasiSqrt.Program carsQuasiSqrtProgram = new CarsQuasiSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars"); 
                            outputTable = carsQuasiSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "GlassBinomialProbit":
                            GlassBinomialProbit.Program glassBinomialProbitProgram = new GlassBinomialProbit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass"); 
                            outputTable = glassBinomialProbitProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "GlassQuasibinomialProbit":
                            GlassQuasibinomialProbit.Program glassQuasibinomialProbitProgram = new GlassQuasibinomialProbit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass"); 
                            outputTable = glassQuasibinomialProbitProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsGammaInverse":
                            ImportsGammaInverse.Program importsGammaInverseProgram = new ImportsGammaInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsGammaInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsGaussianInverse":
                            ImportsGaussianInverse.Program importsGaussianInverseProgram = new ImportsGaussianInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsGaussianInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsInverseGaussian":
                            ImportsInverseGaussian.Program importsInverseGaussianProgram = new ImportsInverseGaussian.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsInverseGaussianProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsNegativeBinomialSqrt":
                            ImportsNegativeBinomialSqrt.Program importsNegativeBinomialSqrtProgram = new ImportsNegativeBinomialSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsNegativeBinomialSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsPoissonSqrt":
                            ImportsPoissonSqrt.Program importsPoissonSqrtProgram = new ImportsPoissonSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsPoissonSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsQuasiInverse":
                            ImportsQuasiInverse.Program importsQuasiInverseProgram = new ImportsQuasiInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsQuasiInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsQuasiSqrt":
                            ImportsQuasiSqrt.Program importsQuasiSqrtProgram = new ImportsQuasiSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsQuasiSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "IrisBinomialProbit":
                            IrisBinomialProbit.Program irisBinomialProbitProgram = new IrisBinomialProbit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris"); 
                            outputTable = irisBinomialProbitProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "IrisQuasibinomialProbit":
                            IrisQuasibinomialProbit.Program irisQuasibinomialProbitProgram = new IrisQuasibinomialProbit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris"); 
                            outputTable = irisQuasibinomialProbitProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzoneGammaInverse":
                            OzoneGammaInverse.Program ozoneGammaInverseProgram = new OzoneGammaInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozoneGammaInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzoneGaussianInverse":
                            OzoneGaussianInverse.Program ozoneGaussianInverseProgram = new OzoneGaussianInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozoneGaussianInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzonePoissonSqrt":
                            OzonePoissonSqrt.Program ozonePoissonSqrtProgram = new OzonePoissonSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozonePoissonSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzoneQuasiInverse":
                            OzoneQuasiInverse.Program ozoneQuasiInverseProgram = new OzoneQuasiInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozoneQuasiInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzoneQuasiSqrt":
                            OzoneQuasiSqrt.Program ozoneQuasiSqrtProgram = new OzoneQuasiSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozoneQuasiSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzoneQuasipoissonSqrt":
                            OzoneQuasipoissonSqrt.Program ozoneQuasipoissonSqrtProgram = new OzoneQuasipoissonSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozoneQuasipoissonSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsGammaInverse":
                            TipsGammaInverse.Program tipsGammaInverseProgram = new TipsGammaInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsGammaInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsGaussianInverse":
                            TipsGaussianInverse.Program tipsGaussianInverseProgram = new TipsGaussianInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsGaussianInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsInverseGaussian":
                            TipsInverseGaussian.Program tipsInverseGaussianProgram = new TipsInverseGaussian.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsInverseGaussianProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsQuasiInverse":
                            TipsQuasiInverse.Program tipsQuasiInverseProgram = new TipsQuasiInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsQuasiInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsQuasiSqrt":
                            TipsQuasiSqrt.Program tipsQuasiSqrtProgram = new TipsQuasiSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsQuasiSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsQuasipoissonProbit":
                            TipsQuasipoissonProbit.Program tipsQuasipoissonProbitProbit = new TipsQuasipoissonProbit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsQuasipoissonProbitProbit.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TitanicBinomialProbit":
                            TitanicBinomialProbit.Program titanicBinomialProbitProgram = new TitanicBinomialProbit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic"); 
                            outputTable = titanicBinomialProbitProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TitanicQuasibinomialProbit":
                            TitanicQuasibinomialProbit.Program titanicQuasibinomialProbitProgram = new TitanicQuasibinomialProbit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic"); 
                            outputTable = titanicQuasibinomialProbitProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WineGammaInverse":
                            WineGammaInverse.Program wineGammaInverseProgram = new WineGammaInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = wineGammaInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WineInverseGaussian":
                            WineInverseGaussian.Program wineInverseGaussianProgram = new WineInverseGaussian.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = wineInverseGaussianProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WinePoissonSqrt":
                            WinePoissonSqrt.Program winePoissonSqrtProgram = new WinePoissonSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = winePoissonSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WineQuasiInverse":
                            WineQuasiInverse.Program wineQuasiInverseProgram = new WineQuasiInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = wineQuasiInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WineQuasiSqrt":
                            WineQuasiSqrt.Program wineQuasiSqrtProgram = new WineQuasiSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = wineQuasiSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WineQuasipoissonInverse":
                            WineQuasipoissonInverse.Program wineQuasipoissonInverseProgram = new WineQuasipoissonInverse.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = wineQuasipoissonInverseProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WineQuasipoissonSqrt":
                            WineQuasipoissonSqrt.Program wineQuasipoissonSqrtProgram = new WineQuasipoissonSqrt.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = wineQuasipoissonSqrtProgram.PredictResult(tempTable, pmmlPath);
                            break;

                    }
                    break;
                case "Naive Bayes":
                    switch (sampleName)
                    {
                        case "Audit":
                            Audit.Program auditProgram = new Audit.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = auditProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancer":
                            BreastCancer.Program breastCancerProgram = new BreastCancer.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = breastCancerProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Imports":
                            Imports.Program importsProgram = new Imports.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = importsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Iris":
                            Iris.Program irisProgram = new Iris.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = irisProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Titanic":
                            Titanic.Program titanicProgram = new Titanic.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = titanicProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Wine":
                            Wine.Program wineProgram = new Wine.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = wineProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;

                case "Random Forest":
                    switch (sampleName)
                    {
                        case "Audit":
                            AuditRandomForest.Program auditProgram = new AuditRandomForest.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = auditProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancer":
                            BreastCancerRandomForest.Program breastCancerProgram = new BreastCancerRandomForest.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = breastCancerProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Cars":
                            CarsRandomForest.Program carsProgram = new CarsRandomForest.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = carsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Glass":
                            GlassRandomForest.Program glassProgram = new GlassRandomForest.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = glassProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Imports":
                            ImportsRandomForest.Program importsProgram = new ImportsRandomForest.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = importsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Iris":
                            IrisRandomForest.Program irisProgram = new IrisRandomForest.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = irisProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Ozone":
                            OzoneRandomForest.Program ozoneProgram = new OzoneRandomForest.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = ozoneProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Tips":
                            TipsRandomForest.Program tipsProgram = new TipsRandomForest.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = tipsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Titanic":
                            TitanicRandomForest.Program titanicProgram = new TitanicRandomForest.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = titanicProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Wine":
                            WineRandomForest.Program wineProgram = new WineRandomForest.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = wineProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;

                case "Regression":
                    switch (sampleName)
                    {
                        case "Cars":
                            CarsRegression.Program carsProgram = new CarsRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = carsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Imports":
                            ImportsRegression.Program importsProgram = new ImportsRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = importsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Ozone":
                            OzoneRegression.Program ozoneProgram = new OzoneRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = ozoneProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Tips":
                            TipsRegression.Program tipsProgram = new TipsRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = tipsProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;

                case "Support Vector Machine":
                    switch (sampleName)
                    {
                        case "AuditLinear":
                            AuditLinear.Program auditLinearProgram = new AuditLinear.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit"); 
                            outputTable = auditLinearProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "AuditPolynomial":
                            AuditPolynomial.Program auditPolynomialProgram = new AuditPolynomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit"); 
                            outputTable = auditPolynomialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "AuditRadial":
                            AuditRadial.Program auditRadialProgram = new AuditRadial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit"); 
                            outputTable = auditRadialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "AuditSigmoid":
                            AuditSigmoid.Program auditSigmoidProgram = new AuditSigmoid.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit"); 
                            outputTable = auditSigmoidProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerLinear":
                            BreastCancerLinear.Program bcLinearProgran = new BreastCancerLinear.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer"); 
                            outputTable = bcLinearProgran.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerPolynomial":
                            BreastCancerPolynomial.Program bcPolynomialProgram = new BreastCancerPolynomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer"); 
                            outputTable = bcPolynomialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerRadial":
                            BreastCancerRadial.Program bcRadialProgram = new BreastCancerRadial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer"); 
                            outputTable = bcRadialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerSigmoid":
                            BreastCancerSigmoid.Program bcSigmoidProgram = new BreastCancerSigmoid.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer"); 
                            outputTable = bcSigmoidProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsLinear":
                            CarsLinear.Program carsLinearProgram = new CarsLinear.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars"); 
                            outputTable = carsLinearProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsPolynomial":
                            CarsPolynomial.Program carsPolynomialProgram = new CarsPolynomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars"); 
                            outputTable = carsPolynomialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsRadial":
                            CarsRadial.Program carsRadialProgram = new CarsRadial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars"); 
                            outputTable = carsRadialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsSigmoid":
                            CarsSigmoid.Program carsSigmoidProgram = new CarsSigmoid.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars"); 
                            outputTable = carsSigmoidProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "GlassLinear":
                            GlassLinear.Program glassLinearProgram = new GlassLinear.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass"); 
                            outputTable = glassLinearProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "GlassPolynomial":
                            GlassPolynomial.Program glassPolynomialProgram = new GlassPolynomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass"); 
                            outputTable = glassPolynomialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "GlassRadial":
                            GlassRadial.Program glassRadialProgram = new GlassRadial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass"); 
                            outputTable = glassRadialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "GlassSigmoid":
                            GlassSigmoid.Program glassSigmoidProgram = new GlassSigmoid.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Glass"); 
                            outputTable = glassSigmoidProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsLinear":
                            ImportsLinear.Program importsLinearProgram = new ImportsLinear.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsLinearProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsPolynomial":
                            ImportsPolynomial.Program importsPolynomialProgram = new ImportsPolynomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsPolynomialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsRadial":
                            ImportsRadial.Program importsRadialProgram = new ImportsRadial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsRadialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsSigmoid":
                            ImportsSigmoid.Program importsSigmoidProgram = new ImportsSigmoid.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports"); 
                            outputTable = importsSigmoidProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "IrisLinear":
                            IrisLinear.Program irisLinearProgram = new IrisLinear.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris"); 
                            outputTable = irisLinearProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "IrisPolynomial":
                            IrisPolynomial.Program irisPolynomialProgram = new IrisPolynomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris"); 
                            outputTable = irisPolynomialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "IrisRadial":
                            IrisRadial.Program irisRadialProgram = new IrisRadial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris"); 
                            outputTable = irisRadialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "IrisSigmoid":
                            IrisSigmoid.Program irisSigmoidProgram = new IrisSigmoid.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Iris"); 
                            outputTable = irisSigmoidProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzoneLinear":
                            OzoneLinear.Program ozoneLinearProgram = new OzoneLinear.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozoneLinearProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzonePolynomial":
                            OzonePolynomial.Program ozonePolynomialProgram = new OzonePolynomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozonePolynomialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzoneRadial":
                            OzoneRadial.Program ozoneRadialProgram = new OzoneRadial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozoneRadialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "OzoneSigmoid":
                            OzoneSigmoid.Program ozoneSigmoidProgram = new OzoneSigmoid.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Ozone"); 
                            outputTable = ozoneSigmoidProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsLinear":
                            TipsLinear.Program tipsLinearProgram = new TipsLinear.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsLinearProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsPolynomial":
                            TipsPolynomial.Program tipsPolynomialProgram = new TipsPolynomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsPolynomialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsRadial":
                            TipsRadial.Program tipsRadialProgram = new TipsRadial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsRadialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsSigmoid":
                            TipsSigmoid.Program tipsSigmoidProgram = new TipsSigmoid.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips"); 
                            outputTable = tipsSigmoidProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TitanicLinear":
                            TitanicLinear.Program titanicLinearProgram = new TitanicLinear.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic"); 
                            outputTable = titanicLinearProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TitanicPolynomial":
                            TitanicPolynomial.Program titanicPolynomialProgram = new TitanicPolynomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic"); 
                            outputTable = titanicPolynomialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TitanicRadial":
                            TitanicRadial.Program titanicRadialProgram = new TitanicRadial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic"); 
                            outputTable = titanicRadialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TitanicSigmoid":
                            TitanicSigmoid.Program titanicSigmoidProgram = new TitanicSigmoid.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Titanic"); 
                            outputTable = titanicSigmoidProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WineLinear":
                            WineLinear.Program wineLinearProgram = new WineLinear.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = wineLinearProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WinePolynomial":
                            WinePolynomial.Program winePolynomialProgram = new WinePolynomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = winePolynomialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WineRadial":
                            WineRadial.Program wineRadialProgram = new WineRadial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = wineRadialProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "WineSigmoid":
                            WineSigmoid.Program wineSigmoidProgram = new WineSigmoid.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Wine"); 
                            outputTable = wineSigmoidProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;

                case "Tree Model":
                    switch (sampleName)
                    {
                        case "Audit":
                            AuditTree.Program auditProgram = new AuditTree.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = auditProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancer":
                            BreastCancerTree.Program breastCancerProgram = new BreastCancerTree.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = breastCancerProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Cars":
                            CarsTree.Program carsProgram = new CarsTree.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = carsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Glass":
                            GlassTree.Program glassProgram = new GlassTree.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = glassProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Imports":
                            ImportsTree.Program importsProgram = new ImportsTree.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = importsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Iris":
                            IrisTree.Program irisProgram = new IrisTree.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = irisProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Ozone":
                            OzoneTree.Program ozoneProgram = new OzoneTree.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = ozoneProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Tips":
                            TipsTree.Program tipsProgram = new TipsTree.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = tipsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Titanic":
                            TitanicTree.Program titanicProgram = new TitanicTree.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = titanicProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Wine":
                            WineTree.Program wineProgram = new WineTree.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = wineProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;

                case "Clustering Model":
                    switch (sampleName)
                    {
                        case "Audit":
                            AuditKMeans.Program auditProgram = new AuditKMeans.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = auditProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancer":
                            BreastCancerKMeans.Program breastCancerProgram = new BreastCancerKMeans.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = breastCancerProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Glass":
                            GlassKMeans.Program glassProgram = new GlassKMeans.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = glassProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Iris":
                            IrisKMeans.Program irisProgram = new IrisKMeans.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = irisProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Titanic":
                            TitanicKMeans.Program titanicProgram = new TitanicKMeans.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = titanicProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Wine":
                            WineKMeans.Program wineProgram = new WineKMeans.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = wineProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;

                case "Neural Networks":
                    switch (sampleName)
                    {
                        case "Audit":
                            AuditNeural.Program auditProgram = new AuditNeural.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = auditProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancer":
                            BreastCancerNeural.Program breastCancerProgram = new BreastCancerNeural.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = breastCancerProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Cars":
                            CarsNeural.Program carsProgram = new CarsNeural.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = carsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Glass":
                            GlassNeural.Program glassProgram = new GlassNeural.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = glassProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Imports":
                            ImportsNeural.Program importsProgram = new ImportsNeural.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = importsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Iris":
                            IrisNeural.Program irisProgram = new IrisNeural.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = irisProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Ozone":
                            OzoneNeural.Program ozoneProgram = new OzoneNeural.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = ozoneProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Tips":
                            TipsNeural.Program tipsProgram = new TipsNeural.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = tipsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Titanic":
                            TitanicNeural.Program titanicProgram = new TitanicNeural.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = titanicProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Wine":
                            WineNeural.Program wineProgram = new WineNeural.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = wineProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;

                case "Multinomial Regression":
                    switch (sampleName)
                    {
                        case "Audit":
                            AuditMultinomial.Program auditProgram = new AuditMultinomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = auditProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancer":
                            BreastCancerMultinomial.Program breastCancerProgram = new BreastCancerMultinomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            currentPmmlPath = pmmlPath;
                            outputTable = breastCancerProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Glass":
                            GlassMultinomial.Program glassProgram = new GlassMultinomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = glassProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Iris":
                            IrisMultinomial.Program irisProgram = new IrisMultinomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = irisProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Titanic":
                            TitanicMultinomial.Program titanicProgram = new TitanicMultinomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = titanicProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Wine":
                            WineMultinomial.Program wineProgram = new WineMultinomial.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = wineProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;

                case "Cox Regression":
                    switch (sampleName)
                    {
                        case "Aml":
                            AmlCoxRegression.Program amlProgram = new AmlCoxRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = amlProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Bfeed":
                            BfeedCoxRegression.Program bfeedProgram = new BfeedCoxRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = bfeedProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Larynx":
                            LarynxCoxRegression.Program larynxProgram = new LarynxCoxRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = larynxProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Lung":
                            LungCoxRegression.Program lungProgram = new LungCoxRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = lungProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Ovarian":
                            OvarianCoxRegression.Program ovarianProgram = new OvarianCoxRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = ovarianProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Rats":
                            RatsCoxRegression.Program ratsProgram = new RatsCoxRegression.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            outputTable = ratsProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;

                case "Gradient Boosting":
                    switch (sampleName)
                    {
                        case "AuditBernoulli":
                            Audit_Bernoulli.Program auditProgram = new Audit_Bernoulli.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
                            outputTable = auditProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BfeedCoxph":
                            Bfeed_Coxph.Program bfeedProgram = new Bfeed_Coxph.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Bfeed");
                            outputTable = bfeedProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerAdaboost":
                            BreastCancer_Adaboost.Program breastCancerProgram = new BreastCancer_Adaboost.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                            outputTable = breastCancerProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "BreastCancerHuberized":
                            BreastCancer_Huberized.Program breastCancerHeuberizedProgram = new BreastCancer_Huberized.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "BreastCancer");
                            outputTable = breastCancerHeuberizedProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsLaplace":
                            Cars_Laplace.Program carsProgram = new Cars_Laplace.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                            outputTable = carsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "CarsTdist":
                            Cars_Tdist.Program carsTdistProgram = new Cars_Tdist.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Cars");
                            outputTable = carsTdistProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsPairwise":
                            Imports_Pairwise.Program importsProgram = new Imports_Pairwise.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                            outputTable = importsProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "ImportsPoisson":
                            Imports_Poisson.Program importsPoissonProgram = new Imports_Poisson.Program();;
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                            outputTable = importsPoissonProgram.PredictResult(tempTable, pmmlPath);
                            break;
                        case "ImportsQuantile":
                            Imports_Quantile.Program importsQuantileProgram = new Imports_Quantile.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Imports");
                            outputTable = importsQuantileProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "TipsGaussian":
                            Tips_Gaussian.Program tipsProgram = new Tips_Gaussian.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Tips");
                            outputTable = tipsProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;          
     
                case "Association Rules":
                    switch(sampleName)
                    {
                        case "Adult":
                            Adult.Program AdultProgram = new Adult.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Adult");
                            outputTable = AdultProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Epub":
                            Epub.Program EpubProgram = new Epub.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Epub");
                            outputTable = EpubProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Groceries":
                            Groceries.Program GroceriesProgram = new Groceries.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Groceries");
                            outputTable = GroceriesProgram.PredictResult(tempTable, pmmlPath);
                            break;

                        case "Income":
                            Income.Program IncomeProgram = new Income.Program();
                            tempInputDataTable = FillPage(inputDataTable);
                            tempTable = new Syncfusion.PMML.Table(tempInputDataTable.Rows.Count, tempInputDataTable.Columns.Count);
                            tempTable = ConvertToTable(tempInputDataTable);
                            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Income");
                            outputTable = IncomeProgram.PredictResult(tempTable, pmmlPath);
                            break;
                    }
                    break;
            }
            
            DataTable resultTable = null;
            if (tempTable != null && outputTable != null)
            {
                var input = tempTable.ConvertToDataTable();
                resultTable = this.MergeTable(input, outputTable);
            }
            BeginInvoke(new System.Action(() =>
            {
                this.PredictedResult.BeginUpdate();                               
                PredictedResult.DataSource = resultTable;
                PredictedResult.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Left;
                int startVal = PredictedResult.TableModel.NameToColIndex(PredictedResult.TableDescriptor.Columns[0].MappingName);
                int start = PredictedResult.TableModel.ColIndexToField(startVal);
                int endVal = PredictedResult.TableModel.NameToColIndex(PredictedResult.TableDescriptor.Columns[PredictedResult.TableDescriptor.Columns.Count - 1].MappingName);
                int end = PredictedResult.TableModel.ColIndexToField(endVal);
                PredictedResult.TableModel.ColWidths.ResizeToFitOptimized(GridRangeInfo.Cols(start, end), GridResizeToFitOptions.IncludeHeaders, GridTextOptions.FormattedText);
                totalWidth = this.PredictedResult.TableModel.ColWidths.GetTotal(0,
                this.PredictedResult.TableDescriptor.VisibleColumns.Count);
                this.pmmlCode.CurrentLine = 1;
                this.PredictedResult.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22f);
                for (int i = 0; i < resultTable.Columns.Count; i++)
                {
                    var cellValue = resultTable.Rows[0].ItemArray[i].ToString();
                    if (double.TryParse(cellValue, out result))
                    {
                        this.PredictedResult.TableDescriptor.Columns[i].Appearance.AnyRecordFieldCell.HorizontalAlignment = GridHorizontalAlignment.Right;

                    }
                    if (i >= inputTable.ColumnCount)
                    {
                        this.PredictedResult.TableDescriptor.Columns[i].Appearance.AnyRecordFieldCell.BackColor = Color.FromArgb(214, 211, 209);
                    }
                }
                this.PredictedResult.EndUpdate(true);
            }));
            DisplayPageInfo();
        }


        /// <summary>
        /// A method that initializes page settings and loads the default page.
        /// </summary>
        private void InitializePager()
        {
            // Set the start and max records. 
            _maxRec = inputDataTable.Rows.Count;
            _pageCount = _maxRec / _pageSize;

            //Adjust the page number if the last page contains a partial page.
            if ((_maxRec % _pageSize) > 0)
            {
                _pageCount += 1;
            }

            // Initial seeings
            _currentPage = 1;
            _recNo = 0;

            _myLabel.Location =
                new Point(
                    PredictedResult.RecordNavigationControl.NavigationBar.ButtonBarChild.Buttons[2].Bounds.X, 0);
            _myLabel.Width =
                PredictedResult.RecordNavigationControl.NavigationBar.ButtonBarChild.Buttons[5].Bounds.X -
                _myLabel.Location.X;
            _myLabel.TextAlign = ContentAlignment.TopCenter;
            _myLabel.BackColor = Color.White;
            _myLabel.Font = new Font("Segoe UI", 10);
            _myLabel.ForeColor = Color.Gray;

            BeginInvoke(new System.Action(() =>
            {
                PredictedResult.RecordNavigationControl.NavigationBar.Controls.Add(_myLabel);
            }));

            _engine = new Engine();
            _engine.SetSourceList(inputDataTable.DefaultView);

            
            BeginInvoke(new System.Action(() =>
            {
                PredictedResult.ShowNavigationBar = true;
                PredictedResult.RecordNavigationBar.AllowAddNew = false;
                PredictedResult.RecordNavigationBar.AllowStepIncrease = false;
                PredictedResult.RecordNavigationBar.ButtonLook = ButtonLook.Flat;
                PredictedResult.RecordNavigationBar.DisplayArrowButtons = DisplayArrowButtons.All;
                PredictedResult.RecordNavigationBar.CurrentRecordChanging += RecordNavigationBar_CurrentRecordChanging;
                PredictedResult.RecordNavigationBar.ArrowButtonClicked -= RecordNavigationBar_ArrowButtonClicked;
                PredictedResult.RecordNavigationBar.ArrowButtonClicked += RecordNavigationBar_ArrowButtonClicked;
            }));
        }

        /// <summary>
        /// A method that fills the temporary table with paged data to display in grid.
        /// </summary>
        /// <param name="table">DataTable with latest view applied.</param>
        private DataTable FillPage(DataTable table)
        {
            int i;
            int end;
            DataTable temp = table.Clone();

            if (_currentPage == _pageCount)
                end = _maxRec;
            else
                end = _pageSize * _currentPage;

            var start = _recNo;

            //Copy rows from the source table to fill the temporary table.
            for (i = start; i < end; i++)
            {
                temp.ImportRow(table.Rows[i]);
                _recNo += 1;
            }
            return temp;
        }

        /// <summary>
        /// A method to display the page information in pager control at bottom.
        /// </summary>
        private void DisplayPageInfo()
        {
            BeginInvoke(new System.Action(() =>
            {
                _myLabel.Text = "Page " + _currentPage.ToString(CultureInfo.InvariantCulture) + " of " + _pageCount.ToString(CultureInfo.InvariantCulture);
            }));
            var arrowType = ArrowType.None;
            if (_currentPage != 1)
                arrowType |= ArrowType.First;
            if (_currentPage > 1)
                arrowType |= ArrowType.Previous;
            if (_currentPage < _pageCount)
                arrowType |= ArrowType.Next;
            if (_currentPage != _pageCount)
                arrowType |= ArrowType.Last;
            BeginInvoke(new System.Action(() =>
            {
                int topRow = this.PredictedResult.TableControl.TopRowIndex;
                this.PredictedResult.TableControl.CurrentCell.Activate(topRow, 1);
                this.PredictedResult.RecordNavigationBar.EnableButtonFlags = arrowType;
            }));
        }

        
        /// <summary>
        /// A method that get triggered on current record change in grid.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:Syncfusion.Windows.Forms.CurrentRecordEventArgs">CurrentRecordEventArgs</see> that contains the event data.</param>
        static void RecordNavigationBar_CurrentRecordChanging(object sender, CurrentRecordEventArgs e)
        {
            e.Cancel = true;
        }

        /// <summary>
        /// A method that was invoked on clicking arrow buttons in pager control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:Syncfusion.Windows.Forms.ArrowButtonEventArgs">ArrowButtonEventArgs</see> that contains the event data.</param>
        void RecordNavigationBar_ArrowButtonClicked(object sender, ArrowButtonEventArgs e)
        {
            switch (e.Arrow)
            {
                case ArrowType.First:
                    _currentPage = 1;
                    _recNo = 0;
                    LoadTempInputTable(currentSampleName, currentPmmlPath, this.inputDataTable.DefaultView.ToTable(), currentModelName);
                    break;
                case ArrowType.Previous:
                    if (_currentPage == _pageCount)
                    {
                        _recNo = _pageSize * (_currentPage - 2);
                    }
                    _currentPage -= 1;
                    _recNo = _pageSize * (_currentPage - 1);
                    LoadTempInputTable(currentSampleName, currentPmmlPath, this.inputDataTable.DefaultView.ToTable(), currentModelName);
                    break;
                case ArrowType.Next:
                    _currentPage += 1;
                    if (_currentPage > _pageCount)
                    {
                        _currentPage = _pageCount;
                    }
                    LoadTempInputTable(currentSampleName, currentPmmlPath, this.inputDataTable.DefaultView.ToTable(), currentModelName);
                    break;
                case ArrowType.Last:
                    _currentPage = _pageCount;
                    _recNo = _pageSize * (_currentPage - 1);
                    LoadTempInputTable(currentSampleName, currentPmmlPath, this.inputDataTable.DefaultView.ToTable(), currentModelName);
                    break;
            }
        }
    
    }
   
}
