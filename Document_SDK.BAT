@echo off
set "target=DocumentSDK"

if not exist "%target%" (
    mkdir "%target%"
)

xcopy ".github" "%target%\.github\" /s /e /y
xcopy "common" "%target%\common\" /s /e /y
xcopy "docio" "%target%\docio\" /s /e /y
xcopy "pdf" "%target%\pdf\" /s /e /y
xcopy "presentation" "%target%\presentation\" /s /e /y
xcopy "showcase\Invoice" "%target%\showcase\Invoice\" /s /e /y
xcopy "showcase\Presentation Demo" "%target%\showcase\Presentation Demo\" /s /e /y
xcopy "xlsio" "%target%\xlsio\" /s /e /y

copy "showcase\invoice.png" "%target%\showcase\" /y
copy "showcase\ppt__logo.png" "%target%\showcase\" /y
copy "BuildFile.xml" "%target%\" /y
copy "CopyFilesToUISuiteSDK.bat" "%target%\" /y
copy "Directory.Build.props" "%target%\" /y
copy "Samples_DocumentSDK.xml" "%target%\" /y

echo All folders and files copied to "%target%" successfully.

set "base=DocumentSDK"

rmdir /s /q "%base%\xlsio\Data Binding\Import-Export DataTable"

rmdir /s /q "%base%\common\Analytics"
rmdir /s /q "%base%\common\Data\Chart"
rmdir /s /q "%base%\common\Data\Diagram"
rmdir /s /q "%base%\common\Data\Spreadsheet"

del /f /q "%base%\common\Data\ACC.mdb"
del /f /q "%base%\common\Data\ComboBoxAdvDataBinding.mdb"
del /f /q "%base%\common\Data\CustOrders.xml"
del /f /q "%base%\common\Data\Expand.xml"
del /f /q "%base%\common\Data\GDBDdata.XML"
del /f /q "%base%\common\Data\HVData.xml"
del /f /q "%base%\common\Data\NorthwindwithImage.sdf"
del /f /q "%base%\common\Data\NWIND.MDB"
del /f /q "%base%\common\Data\pages.mdb"
del /f /q "%base%\common\Data\Shippers.xml"

rmdir /s /q "%base%\common\images\Chart"
rmdir /s /q "%base%\common\images\Diagram"
rmdir /s /q "%base%\common\images\Grid"
rmdir /s /q "%base%\common\images\Tools"

echo Folder cleanup inside "%base%" completed.