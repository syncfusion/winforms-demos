#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
                    return "Pivot Tabellen Feldliste";
                case PivotResourceIdentifiers.Choosefieldstoaddreport:
                    return "Felder auswählen, die dem Bericht hinzugefügt werden sollen";
                case PivotResourceIdentifiers.ColumnLabels:
                    return "Spalten";
                case PivotResourceIdentifiers.DeferlayoutUpdate:
                    return "Layout - Aktualisierung aufschieben";
                case PivotResourceIdentifiers.Dragfieldsbetweenareasbelow:
                    return "Felder zwischen den untenstehenden Bereichen ziehen";
                case PivotResourceIdentifiers.DropPivotFieldsheretoFilterBy:
                    return "Pivot Felder hier ablegen, um danach zu filtern";
                case PivotResourceIdentifiers.MoveDown:
                    return "Nach unten verschieben";
                case PivotResourceIdentifiers.MoveToBeginning:
                    return "An den Anfang verschieben";
                case PivotResourceIdentifiers.MoveToColumnLabels:
                    return "Zu Spaltenbeschriftungen verschieben";
                case PivotResourceIdentifiers.MoveToEnd:
                    return "An das Ende verschieben";
                case PivotResourceIdentifiers.MoveToReportFilter:
                    return "Zu Berichtsfiltern verschieben";
                case PivotResourceIdentifiers.MoveToRowLabels:
                    return "Zu Zeilenbeschriftungen verschieben";
                case PivotResourceIdentifiers.MoveToValues:
                    return "Zu Werten verschieben";
                case PivotResourceIdentifiers.MoveUp:
                    return "Nach oben verschieben";
                case PivotResourceIdentifiers.OK:
                    return "OK";
                case PivotResourceIdentifiers.Cancel:
                    return "Abbrechen";
                case PivotResourceIdentifiers.PivotSchemaDesigner:
                    return "Pivot Schema Designer";
                case PivotResourceIdentifiers.RemoveField:
                    return "Feld entfernen";
                case PivotResourceIdentifiers.ReportFilter:
                    return "Filter";
                case PivotResourceIdentifiers.RowLabel:
                    return "Zeilen";
                case PivotResourceIdentifiers.ShowCalculationsasColumns:
                    return "Berechnungen als Spalten anzeigen";
                case PivotResourceIdentifiers.Update:
                    return "Aktualisieren";
                case PivotResourceIdentifiers.Values:
                    return "Werte";
                case PivotResourceIdentifiers.FieldName:
                    return "Feldname";
                case PivotResourceIdentifiers.FieldHeader:
                    return "Feldüberschrift";
                case PivotResourceIdentifiers.BaseField:
                    return "Basisfeld";
                case PivotResourceIdentifiers.BaseItem:
                    return "Basisobjekt";
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
                    return "Dezimale Gesamtsumme";
                case PivotResourceIdentifiers.IntTotalSum:
                    return "Ganze Gesamtsumme";
                case PivotResourceIdentifiers.Custom:
                    return "Benutzerdefiniert";
                case PivotResourceIdentifiers.DisplayIfDiscreteValuesEqual:
                    return "Anzeige wenn Diskrete Werte gleich sind";
                case PivotResourceIdentifiers.Sum:
                    return "Summe";
                case PivotResourceIdentifiers.Average:
                    return "Durchschnitt";
                case PivotResourceIdentifiers.Max:
                    return "Max";
                case PivotResourceIdentifiers.Min:
                    return "Min";
                case PivotResourceIdentifiers.CountNumbers:
                    return "Anzahl der Zahlen";
                case PivotResourceIdentifiers.StdDev:
                    return "Std. Dev";
                case PivotResourceIdentifiers.StdDevP:
                    return "Std. Entwickler P";
                case PivotResourceIdentifiers.Var:
                    return "Var";
                case PivotResourceIdentifiers.VarP:
                    return "VarP";
                case PivotResourceIdentifiers.DoubleVariance:
                    return "Doppelte Varianz";
                case PivotResourceIdentifiers.NoCalculation:
                    return "Keine Berechnung";
                case PivotResourceIdentifiers.PercentageOfGrandTotal:
                    return "% der Gesamtsumme";
                case PivotResourceIdentifiers.PercentageOfColumnTotal:
                    return "% der Spaltensumme";
                case PivotResourceIdentifiers.PercentageOfRowTotal:
                    return "% der Zeilensumme";
                case PivotResourceIdentifiers.PercentageOfParentColumnTotal:
                    return "% der übergeordneten spaltensumme";
                case PivotResourceIdentifiers.PercentageOfParentRowTotal:
                    return "% der übergeordneten Zeilensumme";
                case PivotResourceIdentifiers.PercentageOfParentTotal:
                    return "% der übergeordneten Gesamtsumme";
                case PivotResourceIdentifiers.Index:
                    return "Index";
                case PivotResourceIdentifiers.Formula:
                    return "Formel";
                case PivotResourceIdentifiers.PercentageOf:
                    return "% von";
                case PivotResourceIdentifiers.DifferenceFrom:
                    return "Differenz von";
                case PivotResourceIdentifiers.PercentageOfDifferenceFrom:
                    return "% der Differenz von";
                case PivotResourceIdentifiers.RunningTotalIn:
                    return "Laufende Summe in";
                case PivotResourceIdentifiers.PercentageOfRunningTotalIn:
                    return "% der laufenden Summe in";
                case PivotResourceIdentifiers.RankSmallestToLargest:
                    return "Rang vom Kleinsten zum Größten";
                case PivotResourceIdentifiers.RankLargestToSmallest:
                    return "Rang vom Größten zum Kleinsten";
                case PivotResourceIdentifiers.Distinct:
                    return "Unterscheidung";
                case PivotResourceIdentifiers.SubTotal:
                    return "Zwischensumme";
                case PivotResourceIdentifiers.GrandTotal:
                    return "Gesamt";
                default:
                    return string.Empty;
            }         
        }
    }
}