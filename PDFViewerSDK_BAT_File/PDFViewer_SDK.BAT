@echo off
setlocal

REM Define source and destination paths
set "SOURCE=."
set "DEST=PDFViewerSDK"

REM Create destination folder if it doesn't exist
if not exist "%DEST%" mkdir "%DEST%"
if not exist "%DEST%\..\common" mkdir "%DEST%\common"
if not exist "%DEST%\..\common\Data" mkdir "%DEST%\common\Data"

REM Copy folders
xcopy "%SOURCE%\..\pdfviewer" "%DEST%\pdfviewer" /E /I /Y
xcopy "%SOURCE%\..\showcase\SuccinitySeries" "%DEST%\showcase\SuccinitySeries" /E /I /Y
xcopy "%SOURCE%\..\common\Data\PDF" "%DEST%\common\Data\PDF" /E /I /Y
xcopy "%SOURCE%\..\common\images\PDF" "%DEST%\common\images\PDF" /E /I /Y
xcopy /Y "%SOURCE%\..\common\SyncfusionLicense.txt" "%DEST%\common\"

REM Copy files
xcopy "%SOURCE%\..\showcase\succinctly.png" "%DEST%\showcase" /Y
xcopy "%SOURCE%\..\Directory.Build.props" "%DEST%\" /Y
xcopy "%SOURCE%\..\Samples_PDFViewerSDK.xml" "%DEST%\" /Y
xcopy "%SOURCE%\..\BuildFile.xml" "%DEST%\" /Y

echo Copy operation completed.
pause