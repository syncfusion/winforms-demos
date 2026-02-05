@echo off
echo Starting copy all demos to UISuite_SB...

:: Create the destination directory if it doesn't exist
if not exist "UISuite_SB" mkdir "UISuite_SB"

:: Copy all files from SB to UISuite_SB
echo Copying all demo folder to UISuite_SB...
for /d %%F in (*) do (
	if /i not "%%F"=="UISuite_SB" xcopy "%%F" "UISuite_SB\%%F" /e /i /y
)

:: Copy file to the UISuite_SB
copy "Directory.Build.props" UISuite_SB\
copy "BuildFile.xml" UISuite_SB\
copy "Samples.xml" UISuite_SB\

:: Remove Directory that are not needed in UISuite
echo Removing Directory from UISuite...
if exist "UISuite_SB\.github" rmdir "UISuite_SB\.github" /s /q
if exist "UISuite_SB\docio" rmdir "UISuite_SB\docio" /s /q
if exist "UISuite_SB\pdf" rmdir "UISuite_SB\pdf" /s /q
if exist "UISuite_SB\pdfviewer" rmdir "UISuite_SB\pdfviewer" /s /q
if exist "UISuite_SB\presentation" rmdir "UISuite_SB\presentation" /s /q
if exist "UISuite_SB\spreadsheet" rmdir "UISuite_SB\spreadsheet" /s /q
if exist "UISuite_SB\xlsio" rmdir "UISuite_SB\xlsio" /s /q
if exist "UISuite_SB\showcase\SpreadsheetDemo" rmdir "UISuite_SB\showcase\SpreadsheetDemo" /s /q
if exist "UISuite_SB\showcase\SuccinitySeries" rmdir "UISuite_SB\showcase\SuccinitySeries" /s /q
if exist "UISuite_SB\showcase\Invoice" rmdir "UISuite_SB\showcase\Invoice" /s /q
if exist "UISuite_SB\showcase\Presentation Demo" rmdir "UISuite_SB\showcase\Presentation Demo" /s /q

:: Delete specific Image files that are not needed in UISuite
echo Starting to Remove IO Files from Showcase file in ListViewIcons...
if exist "UISuite_SB\showcase\succinctly.png" del "UISuite_SB\showcase\succinctly.png"
if exist "UISuite_SB\showcase\Spreadsheet.png" del "UISuite_SB\showcase\Spreadsheet.png"
if exist "UISuite_SB\showcase\Invoice.png" del "UISuite_SB\showcase\Invoice.png"
if exist "UISuite_SB\showcase\showcase\ppt__logo.png" del "UISuite_SB\showcase\ppt__logo.png"

:: Remove IO Folder that are not needed in UISuite in Common folder
echo Starting to Remove IO Folder that are not needed in Common folder...
if exist "UISuite_SB\common\images\DocIO" rmdir "UISuite_SB\common\images\DocIO" /s /q
if exist "UISuite_SB\common\images\PDF" rmdir "UISuite_SB\common\images\PDF" /s /q
if exist "UISuite_SB\common\images\Presentation" rmdir "UISuite_SB\common\images\Presentation" /s /q
if exist "UISuite_SB\common\images\XlsIO" rmdir "UISuite_SB\common\images\XlsIO" /s /q
if exist "UISuite_SB\common\Data\DocIO" rmdir "UISuite_SB\common\Data\DocIO" /s /q
if exist "UISuite_SB\common\Data\PDF" rmdir "UISuite_SB\common\Data\PDF" /s /q
if exist "UISuite_SB\common\Data\Presentation" rmdir "UISuite_SB\common\Data\Presentation" /s /q
if exist "UISuite_SB\common\Data\Spreadsheet" rmdir "UISuite_SB\common\Data\Spreadsheet" /s /q
if exist "UISuite_SB\common\Data\XlsIO" rmdir "UISuite_SB\common\Data\XlsIO" /s /q
if exist "UISuite_SB\common\Data\Essential DocIO.txt" del "UISuite_SB\common\Data\Essential DocIO.txt"
if exist "UISuite_SB\common\Data\Essential PDF.txt" del "UISuite_SB\common\Data\Essential PDF.txt"
if exist "UISuite_SB\common\Data\Essential XlsIO.txt" del "UISuite_SB\common\Data\Essential XlsIO.txt"

echo Process completed successfully!