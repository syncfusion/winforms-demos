@echo off

REM Section I - Main folders
for %%F in (
    "autocomplete" "barcode" "bulletgraph" "calculate" "chart" "containercontrols"
    "contextmenustripext" "datagrid" "diagram" "dialogs" "docio" "dockingmanager"
    "dropdown" "edit" "editor" "fontcombobox" "gauge" "gridcontrol" "gridgroupingcontrol"
    "grouping" "htmlui" "inputcontrols" "layout" "listcontrols" "localization" "map"
    "menu" "multicolumntreeview" "navigation" "navigationview" "newlocalizationprocedure"
    "notification" "pdf" "pdfviewer" "pivotchart" "pivotgrid" "pmml" "popupmenu"
    "presentation" "radialmenu" "ribbon" "schedulecontrol" "sfbutton" "sfcombobox"
    "skinmanager" "smithchart" "spellchecker" "togglebutton" "toolbars" "treemap"
    "treeview" "xlsio"
) do (
    IF EXIST "%%F" rmdir /s /q "%%F"
)

REM Section I - Main files
for %%F in (
    "Document_SDK.BAT" "FileFormatSamples.xml" "Samples_DocumentSDK.xml"
    "Samples_PDFViewerSDK.xml" "Samples.xml"
) do (
    IF EXIST "%%F" del /f /q "%%F"
)

REM Section II - common folders
for %%F in (
    "common\Analytics" "common\images" "common\Data\Chart" "common\Data\Diagram"
    "common\Data\DocIO" "common\Data\PDF" "common\Data\Presentation" "common\Data\XlsIO"
) do (
    IF EXIST "%%F" rmdir /s /q "%%F"
)

REM Section II - common files without spaces
for %%F in (
    "ACC.mdb" "AdventureWorkCycle.xml" "ComboBoxAdvDataBinding.mdb" "CustOrders.xml"
    "Expand.xml" "GDBDdata.XML" "HVData.xml" "Northwind.mdb" "NorthwindIO_3.5.sdf"
    "NorthwindIO.sdf" "NorthwindwithImage.sdf" "NWIND.MDB" "Orders.xml" "pages.mdb"
    "Shippers.xml"
) do (
    IF EXIST "common\Data\%%F" del /f /q "common\Data\%%F"
)

REM Section II - common files with spaces
IF EXIST "common\Data\Essential DocIO.txt" del /f /q "common\Data\Essential DocIO.txt"
IF EXIST "common\Data\Essential PDF.txt" del /f /q "common\Data\Essential PDF.txt"
IF EXIST "common\Data\Essential XlsIO.txt" del /f /q "common\Data\Essential XlsIO.txt"
IF EXIST "common\Data\Product Catalog.pdf" del /f /q "common\Data\Product Catalog.pdf"

REM Section III - showcase folders
for %%F in (
    "Audit Showcase" "CarDashboardDemo" "Diagram Builder" "Expense Analysis Demo"
    "Formula Analysis Demo" "Grouping Trader Grid Test Demo" "Invoice" "Outlook Demo"
    "PatientMonitoringDemo" "Pivot Customization Demo" "Portfolio Grid Demo"
    "Presentation Demo" "Sales Analysis Demo" "SuccinitySeries" "UnitConverter"
    "VS2012Demo" "Weather Analysis Demo" "Word 2013 Demo"
) do (
    IF EXIST "showcase\%%F" rmdir /s /q "showcase\%%F"
)

REM Section III - showcase files
for %%F in (
    "Calculate.png" "CarDashboard.png" "CardViewDemo.png" "DiagramBuilder.png"
    "ExpenseDetails.png" "Invoice.png" "OutlookDemo.png" "patientmonitor.png"
    "PivotCustomization.png" "PortfolioGrid.png" "ppt__logo.png" "sales.png"
    "succinctly.png" "TraderGridTestDemo.png" "vs2012demo.png" "weather.png"
    "word2013demo.png"
) do (
    IF EXIST "showcase\%%F" del /f /q "showcase\%%F"
)
