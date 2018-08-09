using System.Globalization;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.PivotAnalysis;

namespace LocalizationDemo
{
    class Localizer : ILocalizationProvider
    {
        public string GetLocalizedString(CultureInfo culture, string name, object obj)
        {
            switch (name)
            {
                case PivotResourceIdentifiers.PivotTableFieldList:
                    return "Pivot Tablie Feld liste";
                case PivotResourceIdentifiers.Choosefieldstoaddreport:
                    return "Wählen Sie Felder aus, die zum Bericht hinzugefügt werden sollen";
                case PivotResourceIdentifiers.ColumnLabels:
                    return "Säulen";
                case PivotResourceIdentifiers.DeferlayoutUpdate:
                    return "Layout - Aktualisierung verschieben";
                case PivotResourceIdentifiers.Dragfieldsbetweenareasbelow:
                    return "Ziehen Sie Felder zwischen den Bereichen darunter";
                case PivotResourceIdentifiers.DropPivotFieldsheretoFilterBy:
                    return "Schau hier, um Pivot Felder durch Filter";
                case PivotResourceIdentifiers.MoveDown:
                    return "Nach unten";
                case PivotResourceIdentifiers.MoveToBeginning:
                    return "An den Anfang";
                case PivotResourceIdentifiers.MoveToColumnLabels:
                    return "Spaltenbeschriftungen";
                case PivotResourceIdentifiers.MoveToEnd:
                    return "Zum Ende";
                case PivotResourceIdentifiers.MoveToReportFilter:
                    return "Verschieben nach Filter melden";
                case PivotResourceIdentifiers.MoveToRowLabels:
                    return "Verschieben nach Etikettenzeile";
                case PivotResourceIdentifiers.MoveToValues:
                    return "Bewegen Sie die Werte";
                case PivotResourceIdentifiers.MoveUp:
                    return "Nach oben";
                case PivotResourceIdentifiers.OK:
                    return "OK";
                case PivotResourceIdentifiers.PivotSchemaDesigner:
                    return "Pivot Svhemae Konstrukteur";
                case PivotResourceIdentifiers.RemoveField:
                    return "Feld entfernen";
                case PivotResourceIdentifiers.ReportFilter:
                    return "Filter";
                case PivotResourceIdentifiers.RowLabel:
                    return "Reihen";
                case PivotResourceIdentifiers.ShowCalculationsasColumns:
                    return "Die Berechnungen zeigen, wie Spalten";
                case PivotResourceIdentifiers.Update:
                    return "Aktualisierung";
                case PivotResourceIdentifiers.Values:
                    return "Werte";
                case PivotResourceIdentifiers.FieldName:
                    return "Feldname";
                case PivotResourceIdentifiers.FieldHeader:
                    return "Feld Kopfzeile";
                case PivotResourceIdentifiers.Description:
                    return "Beschreibung";
                case PivotResourceIdentifiers.Format:
                    return "Format";
                case PivotResourceIdentifiers.SummarizeValueBy:
                    return "Wert zusammenfassen nach";
                case PivotResourceIdentifiers.ShowValueAs:
                    return "Wert anzeigen als";
                case PivotResourceIdentifiers.PivotComputationInformation:
                    return "Pivot-Berechnungsinformationen";
                case PivotResourceIdentifiers.DoubleTotalSum:
                    return "Doppelte Gesamtsumme";
                case PivotResourceIdentifiers.DoubleAverage:
                    return "doppelter Durchschnitt";
                case PivotResourceIdentifiers.DoubleMaximum:
                    return "Doppeltes Maximum";
                case PivotResourceIdentifiers.DoubleMinimum:
                    return "Doppeltes Minimum";
                case PivotResourceIdentifiers.DoubleStandardDeviation:
                    return "Doppelte Standardabweichung";
                case PivotResourceIdentifiers.Count:
                    return "Anzahl";
                case PivotResourceIdentifiers.DecimalTotalSum:
                    return "Dezimal-Gesamtsumme";
                case PivotResourceIdentifiers.IntTotalSum:
                    return "Int Gesamtsumme";
                case PivotResourceIdentifiers.Custom:
                    return "Brauch";
                case PivotResourceIdentifiers.DisplayIfDiscreteValuesEqual:
                    return "Anzeige wenn Diskrete Werte gleich sind";
                case PivotResourceIdentifiers.Sum:
                    return "Summe";
                case PivotResourceIdentifiers.Average:
                    return "Durchschnittlich";
                case PivotResourceIdentifiers.Max:
                    return "Max";
                case PivotResourceIdentifiers.Min:
                    return "Mindest";
                case PivotResourceIdentifiers.CountNumbers:
                    return "Nummern Zählen";
                case PivotResourceIdentifiers.StdDev:
                    return "Std. Dev";
                case PivotResourceIdentifiers.StdDevP:
                    return "Std. Entwickler P";
                case PivotResourceIdentifiers.Var:
                    return "Var";
                case PivotResourceIdentifiers.VarP:
                    return "VarP";
                case PivotResourceIdentifiers.DoubleVariance:
                    return "Doppelte Abweichung";
                case PivotResourceIdentifiers.NoCalculation:
                    return "Keine Berechnung";
                case PivotResourceIdentifiers.PercentageOfGrandTotal:
                    return "% der Gesamtsumme";
                case PivotResourceIdentifiers.PercentageOfColumnTotal:
                    return "% der Spaltensumme";
                case PivotResourceIdentifiers.PercentageOfRowTotal:
                    return "% der Zeilensumme";
                case PivotResourceIdentifiers.PercentageOfParentColumnTotal:
                    return "% der übergeordneten Spalte insgesamt";
                case PivotResourceIdentifiers.PercentageOfParentRowTotal:
                    return "% der übergeordneten Zeilensumme";
                case PivotResourceIdentifiers.PercentageOfParentTotal:
                    return "% der Elternsumme";
                case PivotResourceIdentifiers.Index:
                    return "Index";
                case PivotResourceIdentifiers.Formula:
                    return "Formel";
                case PivotResourceIdentifiers.PercentageOf:
                    return "% von";
                case PivotResourceIdentifiers.DifferenceFrom:
                    return "Unterschied von";
                case PivotResourceIdentifiers.PercentageOfDifferenceFrom:
                    return "% Unterschied von";
                case PivotResourceIdentifiers.RunningTotalIn:
                    return "Laufende Summe";
                case PivotResourceIdentifiers.PercentageOfRunningTotalIn:
                    return "% der laufenden Summe in";
                case PivotResourceIdentifiers.RankSmallestToLargest:
                    return "Rang Kleinster bis Größter";
                case PivotResourceIdentifiers.RankLargestToSmallest:
                    return "Rang am größten zum kleinsten";
                case PivotResourceIdentifiers.Distinct:
                    return "Eindeutig";
                default:
                    return string.Empty;
            }         
        }
    }
}