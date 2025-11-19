@echo off
setlocal

REM Define source and destination paths
set "SOURCE=."
set "DEST=spreadsheeteditorsdk"

REM Create destination folder if it doesn't exist
if not exist "%DEST%" mkdir "%DEST%"
if not exist "%DEST%\common" mkdir "%DEST%\common"
if not exist "%DEST%\common\Data" mkdir "%DEST%\common\Data"

REM Copy folders
xcopy "%SOURCE%\spreadsheet" "%DEST%\spreadsheet" /E /I /Y
xcopy "%SOURCE%\showcase\SpreadsheetDemo" "%DEST%\showcase\SpreadsheetDemo" /E /I /Y
xcopy "%SOURCE%\common\Data\Spreadsheet" "%DEST%\common\Data\Spreadsheet" /E /I /Y

REM Copy files
xcopy "%SOURCE%\showcase\Spreadsheet.png" "%DEST%\showcase" /Y
xcopy "%SOURCE%\common\Data\Northwind.sdf" "%DEST%\common/Data" /Y
xcopy "%SOURCE%\common\SyncfusionLicense.txt" "%DEST%\common" /Y
xcopy "%SOURCE%\Directory.Build.props" "%DEST%\" /Y
xcopy "%SOURCE%\Samples_SpreadsheetEditorSDK.xml" "%DEST%\" /Y
xcopy "%SOURCE%\BuildFile.xml" "%DEST%\" /Y

echo Copy operation completed.
pause