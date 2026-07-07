@echo off
echo Starting copy all demos to UISuite_SB...

:: Remove Directory that are not needed in UISuite_SB
echo Removing Directory from UIKeySuite...
if exist "diagram" rmdir "diagram" /s /q
if exist "schedulecontrol" rmdir "schedulecontrol" /s /q
if exist "showcase\Diagram Builder" rmdir "showcase\Diagram Builder" /s /q

:: Delete specific Image files that are not needed in UISuite
echo Starting to Remove IO Files from Showcase file in ListViewIcons...
if exist "showcase\DiagramBuilder.png" del "showcase\DiagramBuilder.png"
if exist "Samples.xml" del "Samples.xml"

:: Remove IO Folder that are not needed in UISuite in Common folder
echo Starting to Remove IO Folder that are not needed in Common folder...
if exist "common\images\Diagram" rmdir "common\images\Diagram" /s /q
if exist "common\Data\Diagram" rmdir "common\Data\Diagram" /s /q

echo Renaming file...
ren "Samples_UIKey.xml" "Samples.xml"

echo Process completed successfully!