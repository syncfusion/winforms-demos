using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace LocalizationDemo
{
    class Localizer : ILocalizationProvider
    {
        #region ILocalizationProvider Members

        public string GetLocalizedString(System.Globalization.CultureInfo culture, string name,object obj)
        {
            switch (name)
            {
                #region Menu Package
                case ToolsResourceIdentifiers.CustomizeMenu:
                    return "Customize...";
                case ToolsResourceIdentifiers.CustomMenu:
                    return "Benutzerdefinierte";
                case ToolsResourceIdentifiers.NewMenu:
                    return "Neue";
                case ToolsResourceIdentifiers.AddOrRemoveButtons:
                    return "Schaltflächen hinzufügen oder entfernen";
                case ToolsResourceIdentifiers.Add:
                    return "Hinzufügen";
                case ToolsResourceIdentifiers.Delete:
                    return "Löschen";
                case ToolsResourceIdentifiers.Rename:
                    return "Umbenennen";
                case ToolsResourceIdentifiers.DeleteAll:
                    return "AlleLöschen";
                case ToolsResourceIdentifiers.ResetToolBarMenu:
                    return "Symbolleiste zurücksetzen";
                #endregion

                #region BarCustomization Dialog
                case ToolsResourceIdentifiers.BarCustomizationDialogButtonReset:
                    return "Reset";
                case ToolsResourceIdentifiers.BarCustomizationDialogCommands:
                    return "Löschen";
                case ToolsResourceIdentifiers.BarCustomizationDialogNew:
                    return "Neue";
                case ToolsResourceIdentifiers.BarCustomizationDialogTabCommands:
                    return "Befehle";
                case ToolsResourceIdentifiers.BarCustomizationDialogModify:
                    return "Ändern";
                case ToolsResourceIdentifiers.BarCustomizationDialogCategories:
                    return "Kategorien";
                case ToolsResourceIdentifiers.BarCustomizationDialogTabOptions:
                    return "Optionen";
                case ToolsResourceIdentifiers.BarCustomizationDialogResetCustomization:
                    return "Reset Anpassung";
                case ToolsResourceIdentifiers.BarCustomizationDialogResetPartialMenus:
                    return "Reset Teilweise Menüs";
                case ToolsResourceIdentifiers.BarCustomizationDialogLargeIcons:
                    return "Große Symbole verwenden";
                case ToolsResourceIdentifiers.BarCustomizationDialogExpandAfterDelay:
                    return "Expand Nach Delay";
                case ToolsResourceIdentifiers.BarCustomizationDialogPersonalizedMenus:
                    return "personalisierte Menüs";
                case ToolsResourceIdentifiers.BarCustomizationDialogAlwaysFullMenu:
                    return "Immer anzeigen Menu";
                case ToolsResourceIdentifiers.BarCustomizationDialogClose:
                    return "Schließen";
                case ToolsResourceIdentifiers.BarCustomizationDialogCaption:
                    return "Anpassungsdialogfeld";
                case ToolsResourceIdentifiers.BarCustomizationDialogDelete:
                    return "Löschen";
                case ToolsResourceIdentifiers.BarCustomizationDialogOther:
                    return "Andere";
                case ToolsResourceIdentifiers.BarCustomizationDialogTabToolbars:
                case ToolsResourceIdentifiers.BarCustomizationDialogToolbars:
                    return "Symbolleisten";
                #endregion

                #region Color Editor
                case ResourceIdentifiers.ColorEditorPaletteTab:
                    return "Farbenskala";
                case ResourceIdentifiers.ColorEditorStandardTab:
                    return "Niveau";
                case ResourceIdentifiers.ColorEditorSystemTab:
                    return "Anlage";
                #endregion

                #region Menu notifications
                case ToolsResourceIdentifiers.RecentlyUsedItemsResetConfirm:
                    return "Damit wird die Aufzeichnung der Befehle, die Sie in dieser Anwendung verwendet haben und die Standardeinstellungen wiederherstellen sichtbare Befehle in den Menüs und Symbolleisten eingestellt. Es wird nicht explizite Anpassungen. Sind Sie sicher, dass dies zu tun?";
                case ToolsResourceIdentifiers.RecentlyUsedItemsResetConfirmTitle:
                    return "Bestätigen zurückgesetzt";
                case ToolsResourceIdentifiers.NotifyRecentlyUsedItemsReset:
                    return "Ihre aufgezeichneten Nutzungsdaten wurde entfernt. Die Menüs und Befehle werden Sie das nächste Mal öffnen diese Anwendung wiederhergestellt werden.";
                case ToolsResourceIdentifiers.CustomizationResetConfirm:
                    return "Dadurch werden alle expliziten Anpassungen auf die Menüs und Symbolleisten getan. Sind Sie sicher, dass dies zu tun?";
                case ToolsResourceIdentifiers.NotifyCustomizationReset:
                    return "Maßgeschneiderte Informationen zurückgesetzt wird. Allerdings werden die Menüs und Befehle nur in den Grundzustand wiederhergestellt werden Sie das nächste Mal öffnen diese Anwendung.";
                case ToolsResourceIdentifiers.CustomizationResetConfirmTitle:
                    return "Bestätigen zurückgesetzt";
                case ToolsResourceIdentifiers.NotifyCustomizationResetTitle:
                    return "Customization Informationen zum Zurücksetzen";
                #endregion

                #region MessageBoxAdv
                case ResourceIdentifiers.Retry:
                    return "Wiederholen";
                case ResourceIdentifiers.Cancel:
                    return "Abbrechen";
                #endregion

                default:
                    return string.Empty;
            }
        }

        #endregion
    }
}
