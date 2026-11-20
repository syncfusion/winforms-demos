program HelloWorld; 

{$APPTYPE CONSOLE} 

uses
ActiveX,
Printers,
novaOptions,
novapiLIB_TLB; 

const 

//name of novaPDF Printer
PRINTER_NAME    = 'novaPDF Pro v6'; 

//text to be written in the PDF file
PDF_TEXT        = 'Hello world from Delphi!'; 

//PDF file name
PDF_FILE_NAME   = 'HelloWorld_Delphi.pdf'; 

//Print profile name
PROFILE_NAME      = 'HelloWorld Delphi Profile';
PROFILE_IS_PUBLIC = 0; 

var
hr : HRESULT;
pNova : INovaPdfOptions;
strDefaultProfile : WideString;
bPublicProfile: Integer;
//decomment next code if you use workaround for printer index (see below)
//Device, Driver, Port: array[0..80] of Char;
//DevMode: THandle; 

begin 

//initialize COM
hr := ActiveX.CoInitialize(nil);
if (FAILED (hr)) then begin
  System.Writeln('Failed to initialize COM');
  exit;
end; 

//create one NovaPdfOptions instance
pNova := nil;
hr := ActiveX.CoCreateInstance(
            CLASS_NovaPdfOptions, //CLSID_CNovaPdfSource,
            nil,
            CLSCTX_INPROC_SERVER,
            IID_INovaPdfOptions,
            pNova);
if (FAILED(hr))   then begin
  System.Writeln('Failed to create novaPDF COM object');
  exit;
end; 

//initialize NovaPdfOptions and pass printer name
//if you have an application license for novaPDF SDK,
//pass both the registration name and the license key to the Initialize2() function
//hr := pNova.Initialize2( PRINTER_NAME, '<registration name>', '<license key>');
hr := pNova.Initialize2( PRINTER_NAME, '', '', '' ); 

if (SUCCEEDED(hr)) then begin 

  pNova.SetDefaultPrinter();
 // now the default printer is novaPDF printer but the Printer object is not updated
  // here is a workaround to update the Printer object with the default printer
  // you only need this code if you check later on the Printer.PrinterIndex to find out the default printer
  //Printer.GetPrinter(Device, Driver, Port, DevMode);
  //Printer.SetPrinter(PRINTER_NAME, Driver, Port, 0); 

  // set optional PDF settings
  // create a temporary profile for the current print job,
  // in order to not modify the default profile settings
  pNova.AddProfile2(PROFILE_NAME, PROFILE_IS_PUBLIC);
  // set PDF document Title
  pNova.SetOptionString2(NOVAPDF_INFO_TITLE,
                         'Hello World Delphi Sample', PROFILE_NAME, PROFILE_IS_PUBLIC);
  // set resulting file name
  pNova.SetOptionString2(NOVAPDF_SAVE_FOLDER, '', PROFILE_NAME, PROFILE_IS_PUBLIC);
  pNova.SetOptionString2(NOVAPDF_SAVE_FILE,
                         PDF_FILE_NAME, PROFILE_NAME, PROFILE_IS_PUBLIC);
  //do not show prompt dialog
  pNova.SetOptionLong2(NOVAPDF_SAVE_PROMPT, 0, PROFILE_NAME, PROFILE_IS_PUBLIC);
  //if file exists, override
  pNova.SetOptionLong2(NOVAPDF_SAVE_CONFLICT_STRATEGY,
                       FILE_CONFLICT_STRATEGY_OVERWRITE,
                       PROFILE_NAME, PROFILE_IS_PUBLIC);
  //open document in PDF viewer
  pNova.SetOptionLong2(NOVAPDF_ACTION_OPEN_DOCUMENT, 1, PROFILE_NAME, PROFILE_IS_PUBLIC);
  // set active profile
  strDefaultProfile := '';
  pNova.GetActiveProfile2(strDefaultProfile, bPublicProfile);
  pNova.SetActiveProfile2(PROFILE_NAME, PROFILE_IS_PUBLIC); 

  //start print job
  Printer.BeginDoc();
  Printer.Canvas.Font.Size := 24;
  Printer.Canvas.TextOut( 100,
                          80,
                          PDF_TEXT);
  Printer.endDoc();
  System.Writeln('Print job finished'); 

  //restore default profile
  pNova.SetActiveProfile2(strDefaultProfile, bPublicProfile);
  pNova.DeleteProfile2(PROFILE_NAME, PROFILE_IS_PUBLIC);

  //restore default printer
  pNova.RestoreDefaultPrinter();
end else begin
  System.Writeln('Failed to initialize novaPDF Printer');
end; 

ActiveX.CoUninitialize(); 
end.