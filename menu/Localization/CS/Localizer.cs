#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Localization;
using Syncfusion.Windows.Forms.Tools;

namespace Localization
{
    #region Localization

    /// <summary>
    /// Provides static methods and properties to localize the UI.
    /// </summary>
    
    public class Localization : ILocalizationProvider
    {
        public string GetLocalizedString(System.Globalization.CultureInfo culture, string name, object obj)
        {
            switch (name)
            {
                case Localizer.EditResourceIdentifiers.FDTitle:
                    return "使用正则表达式";
                case Localizer.EditResourceIdentifiers.FDbtnFind:
                    return "找下一个";
                case Localizer.EditResourceIdentifiers.FDbtnClose:
                    return "关";
                case Localizer.EditResourceIdentifiers.FDbtnMarkAll:
                    return "马卡尔";
                case Localizer.EditResourceIdentifiers.FDchkCase:
                    return "相符";
                case Localizer.EditResourceIdentifiers.FDchkHidden:
                    return "搜索和隐藏文本";
                case Localizer.EditResourceIdentifiers.FDchkRegular:
                    return "使用正则表达式";
                case Localizer.EditResourceIdentifiers.FDchkUp:
                    return "搜索和向上";
                case Localizer.EditResourceIdentifiers.FDchkWholeWord:
                    return "匹配和整个词";
                case Localizer.EditResourceIdentifiers.FDchkWrap:
                    return "环绕";
                case Localizer.EditResourceIdentifiers.FDGroupTitle:
                    return "搜索";
                case Localizer.EditResourceIdentifiers.FDMain:
                    return "找到和什么";
                case Localizer.EditResourceIdentifiers.FDrdbDocument:
                    return "当前和文档";
                case Localizer.EditResourceIdentifiers.FDrdbSelection:
                    return "当前及选择";

                case Localizer.EditResourceIdentifiers.FGoTitle:
                    return "去线";
                case Localizer.EditResourceIdentifiers.FGoNumber:
                    return "电话号码{0}-{1}";
                case Localizer.EditResourceIdentifiers.FGobtnOK:
                    return "好";
                case Localizer.EditResourceIdentifiers.FGobtnCancel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.FormTitle:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.OkButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.CancelButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.FormatLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.LanguageLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.FillAndBordersGroupBox:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.TextSettingsGroupBox:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.UnderlineGroupBox:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.ApplyButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.BackgroundColorLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.BackgroundStyleLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.BorderColorLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.FontColorLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.FontNameLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.FontSizeLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.FontStyleLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.StrikeOutColorLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.UnderlineColorLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.UnderlineStyleLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.FormatEditorDialog.UnderlineWeightLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.CreateNewFormatDialog.FormTitle:
                    return "取消";
                case Localizer.EditResourceIdentifiers.CreateNewFormatDialog.NameLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.CreateNewFormatDialog.SettingsLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.KeyBindingDialog.CommandShortcutsLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.KeyBindingDialog.CommandsLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.KeyBindingDialog.FormTitle:
                    return "取消";
                case Localizer.EditResourceIdentifiers.KeyBindingDialog.ShortcutLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.KeyBindingDialog.RemoveButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.KeyBindingDialog.DefaultButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.KeyBindingDialog.AssignButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.FormTitle:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.AddFormatButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.AddLexemButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.AddSubLexemButton:
                    return "取消";

                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.BackColorLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.BeginTokenCheckBox:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.BeginTokenLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.ContinueTokenLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.DeleteButton:
                    return "颜";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.EndTokenLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.FileExtensionLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.FileExtensionTabPageText:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.FontFormatButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.ForeColorLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.FormatLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.FormatListLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.FormatTabPageText:
                    return "取消";

                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.HatchStyleLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.HelpButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.IsComplexCheckBox:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.LanguageLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.LexemLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.LexemTabPageText:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.LineColorLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.ListEditorRemoveButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.MultiCharsLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.OneCharLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.OnlyLocalCheckBox:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.OpenButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.OpenDialogTitle:
                    return "取消";

                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.PriorityLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.RestoreButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.SampleLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.SaveAsButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.SaveDialogTitle:
                    return "取消";

                case Localizer.EditResourceIdentifiers.LanguageColoringConfigurationDialog.SetFontButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.NewFormatItemDialog.ExampleLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.NewFormatItemDialog.FormTitle:
                    return "取消";
                case Localizer.EditResourceIdentifiers.NewFormatItemDialog.ValueLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.CreateNewLanguageColoringDialog.LanguagesListLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.CreateNewLanguageColoringDialog.FormTitle:
                    return "取消";
                case Localizer.EditResourceIdentifiers.CreateNewLanguageColoringDialog.FilePathTextBox:
                    return "取消";
                case Localizer.EditResourceIdentifiers.CreateNewLanguageColoringDialog.NameLabel:
                    return "取消";
                case Localizer.EditResourceIdentifiers.CreateNewLanguageColoringDialog.ConfigurationFileLabel:
                    return "取消";


                case Localizer.EditResourceIdentifiers.DEF_CONFIG_CREATE_LANGUAGE:
                    return "取消";
                case Localizer.EditResourceIdentifiers.DEF_CONFIG_SAVE_CHANGES:
                    return "取消";
                case Localizer.EditResourceIdentifiers.DEF_CONFIG_SAVE_OTHERS_CHANGES:
                    return "取消";
                case Localizer.EditResourceIdentifiers.DEF_MENU_BOOKMARKS:
                    return "上下文菜单书签";
                case Localizer.EditResourceIdentifiers.DEF_MENU_CLEARBOOKMARKS:
                    return "清除书签";
                case Localizer.EditResourceIdentifiers.DEF_MENU_CLOSE:
                    return "上下文菜单关";
                case Localizer.EditResourceIdentifiers.DEF_MENU_COLLAPSEALL:
                    return "上下文菜单坍方";
                case Localizer.EditResourceIdentifiers.DEF_MENU_COMMENTSELECTION:
                    return "上下文菜单评论选择";
                case Localizer.EditResourceIdentifiers.DEF_MENU_COPY:
                    return "上文菜单评论";
                case Localizer.EditResourceIdentifiers.DEF_MENU_CUT:
                    return "切";
                case Localizer.EditResourceIdentifiers.DEF_MENU_DELETE:
                    return "删除";
                case Localizer.EditResourceIdentifiers.DEF_MENU_DELETEALL:
                    return "删除所有";
                case Localizer.EditResourceIdentifiers.DEF_MENU_EDIT:
                    return "编辑";
                case Localizer.EditResourceIdentifiers.DEF_MENU_FILE:
                    return "文件";
                case Localizer.EditResourceIdentifiers.DEF_MENU_EXPANDALL:
                    return "展开全部";
                case Localizer.EditResourceIdentifiers.DEF_MENU_FIND:
                    return "找";
                case Localizer.EditResourceIdentifiers.DEF_MENU_GOTO:
                    return "去";
                case Localizer.EditResourceIdentifiers.DEF_MENU_INDENTSELECTION:
                    return "缩进选择";
                case Localizer.EditResourceIdentifiers.DEF_MENU_NEW:
                    return "新";
                case Localizer.EditResourceIdentifiers.DEF_MENU_OPEN:
                    return "打开打开";
                case Localizer.EditResourceIdentifiers.DEF_MENU_OPTIONS:
                    return "打开";
                case Localizer.EditResourceIdentifiers.DEF_MENU_PREVBOOKMARK:
                    return "上一个书签";
                case Localizer.EditResourceIdentifiers.DEF_MENU_PRINT:
                    return "打印";
                case Localizer.EditResourceIdentifiers.DEF_MENU_PRINTPREVIEW:
                    return "打印预览";
                case Localizer.EditResourceIdentifiers.DEF_MENU_REDO:
                    return "重做";
                case Localizer.EditResourceIdentifiers.DEF_MENU_REPLACE:
                    return "更换";
                case Localizer.EditResourceIdentifiers.DEF_MENU_SAVE:
                    return "保存";
                case Localizer.EditResourceIdentifiers.DEF_MENU_SAVEAS:
                    return "另存为";
                case Localizer.EditResourceIdentifiers.DEF_MENU_PASTE:
                    return "糊";
                case Localizer.EditResourceIdentifiers.DEF_MENU_SELECTALL:
                    return "全选";
                case Localizer.EditResourceIdentifiers.DEF_MENU_TABIFYSELECTION:
                    return "主题";
                case Localizer.EditResourceIdentifiers.DEF_MENU_TOGGLEBOOKMARK:
                    return "切换书签";
                case Localizer.EditResourceIdentifiers.DEF_MENU_UNCOMMENTSELECTION:
                    return "取消注释选择";
                case Localizer.EditResourceIdentifiers.DEF_MENU_UNDO:
                    return "解开";
                case Localizer.EditResourceIdentifiers.DEF_MENU_UNTABIFYSELECTION:
                    return "未选择";
                case Localizer.EditResourceIdentifiers.DEF_MENU_UNINDENTSELECTION:
                    return "取消缩进";
                case Localizer.EditResourceIdentifiers.DEF_MENU_ADVANCED:
                    return "高级";
                case Localizer.EditResourceIdentifiers.DEF_MENU_NEXTBOOKMARK:
                    return "下一本书";
                case Localizer.EditResourceIdentifiers.DEF_MSG_FOUND_NOTHING:
                    return "没有文字";
                case Localizer.EditResourceIdentifiers.DEF_MSG_FOUND_NOTHING_CAPTION:
                    return "找到文本";
                case Localizer.EditResourceIdentifiers.FRbtnReplace:
                    return "更换";
                case Localizer.EditResourceIdentifiers.FRbtnReplaceAll:
                    return "全部替换";
                case Localizer.EditResourceIdentifiers.DEF_PRINT_PAGE_PREFIX:
                    return "页";
                case Localizer.EditResourceIdentifiers.DEF_MSG_SAVE_MODIFIED:
                    return "文件已更改 你做 想 变化";
                case Localizer.EditResourceIdentifiers.DEF_MSG_SAVE_MODIFIED_CAPTION:
                    return " 想 变化";
                case Localizer.EditResourceIdentifiers.DEF_MSG_SAVE_FILE_USING_ENCODING_CAPTION:
                    return " 保存存档";
                case Localizer.EditResourceIdentifiers.GoToDialogErrorInfo:
                    return "值 必须 在  该 范围 [{0}-{1}]";

                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.OkButton:
                    return "好";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.AutoIndentModeLabel:
                    return "自动缩进模式";
                case Localizer.EditResourceIdentifiers.DEF_OPTS_APPEARANCE:
                    return "出现";
                case Localizer.EditResourceIdentifiers.DEF_OPTS_APPEARANCEAREAS:
                    return "地区";
                case Localizer.EditResourceIdentifiers.DEF_OPTS_APPEARANCECONTROL:
                    return "控制";
                case Localizer.EditResourceIdentifiers.DEF_OPTS_APPEARANCETEXT:
                    return "文本";
                case Localizer.EditResourceIdentifiers.DEF_OPTS_BEHAVIOUR:
                    return "行为";
                case Localizer.EditResourceIdentifiers.DEF_OPTS_BEHAVIOURGENERAL:
                    return "一般";
                case Localizer.EditResourceIdentifiers.DEF_OPTS_BEHAVIOURTABS:
                    return "标签";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.CancelButton:
                    return "取消";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.AutoIndentModeBlockText:
                    return "块";

                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.ChangedLinesMarking:
                    return "改变了行标记";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.ColumnGuidesText:
                    return "列指南";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.FormTitle:
                    return "控制选项";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.GroupUndoText:
                    return "组撤消";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.HorizontalScrollBarText:
                    return "水平滚动条";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.IndentationBlockBordersText:
                    return "缩进块边框";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.IndentationGuidelinesText:
                    return "缩进指南";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.IndicatorAreaText:
                    return "指标区";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.InsertModeText:
                    return "插入模式";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.LineNumbersText:
                    return "行号";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.LinesWrappingMarksText:
                    return "线包裹标记";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.AutoIndentModeNoneText:
                    return "没有";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.OutliningCollapsersText:
                    return "概述折叠器";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.SelectionAreaText:
                    return "选择区域";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.WordWrapAreaText:
                    return "自动换行区";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.XPStyleText:
                    return "风格";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.UserAreaText:
                    return "用户区";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.WrappedLinesMarksText:
                    return "包裹线标记";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.TransparentSelectionText:
                    return "透明选择";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.VerticalScrollBarText:
                    return "垂直滚动条";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.StatusBarText:
                    return "状态栏";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.VirtualSpaceModeText:
                    return "虚拟空间模式";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.ViewWhiteSpaceText:
                    return "查看白色空间";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.WordWrapText:
                    return "自动换行";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.UseTabsText:
                    return "使用标签";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.TabStopsText:
                    return "制表位";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.TabSizeLabel:
                    return "标签大小";
                case Localizer.EditResourceIdentifiers.ControlOptionsDialog.AutoIndentModeSmartText:
                    return "聪明";

                case ToolsResourceIdentifiers.DockableMenuItemText: return "可停靠";
                case ToolsResourceIdentifiers.AutoHideMenuItemText: return "自动隐藏";
                case ToolsResourceIdentifiers.FloatingMenuItemText: return "漂浮的";
                case ToolsResourceIdentifiers.MDIChildMenuItemText: return "MDI 子";
                case ToolsResourceIdentifiers.HideMenuItemText: return "隐藏";
                case ToolsResourceIdentifiers.MenuItemDockToLeft: return "剩下";
                case ToolsResourceIdentifiers.MenuItemDockToRight: return "对";
                case ToolsResourceIdentifiers.MenuItemDockToTop: return "最佳";
                case ToolsResourceIdentifiers.MenuItemDockToBottom: return "底部";
                case ToolsResourceIdentifiers.MenuItemDockTo: return "码头";
                case ToolsResourceIdentifiers.AddOrRemoveButtons: return "添加或删除按钮";
                case ToolsResourceIdentifiers.CustomizeMenu: return "自定义菜单";
                case ToolsResourceIdentifiers.ResetToolBarMenu: return "重置工具栏";
                case ToolsResourceIdentifiers.SuccesfulResetMessageBoxTitle: return "工具栏复位成功";
                case ToolsResourceIdentifiers.SuccesfulToolbarResetMessage: return "工具栏 将显示 下次 下次 打开应用程序";
                case ToolsResourceIdentifiers.BarCustomizationDialogClose: return "关";
                case ToolsResourceIdentifiers.BarCustomizationDialogOther: return "其他";
                case ToolsResourceIdentifiers.BarCustomizationDialogLargeIcons: return "大图标";
                case ToolsResourceIdentifiers.BarCustomizationDialogDelete: return "删除";
                case ToolsResourceIdentifiers.BarCustomizationDialogNew: return "新";
                case ToolsResourceIdentifiers.BarCustomizationDialogResetCustomization: return "复位定制";
                case ToolsResourceIdentifiers.BarCustomizationDialogTabToolbars: return "工具栏";
                case ToolsResourceIdentifiers.BarCustomizationDialogTabOptions: return "选项";
                case ToolsResourceIdentifiers.BarCustomizationDialogTabCommands: return "命令";
                case ToolsResourceIdentifiers.BarCustomizationDialogPersonalizedMenus: return "个性化的菜单和工具栏";
                case ToolsResourceIdentifiers.BarCustomizationDialogToolbars: return "工具栏";
                case ToolsResourceIdentifiers.BarCustomizationDialogResetPartialMenus: return "重置我的使用率数据";
                case ToolsResourceIdentifiers.BarCustomizationDialogExpandAfterDelay: return "显示完整的菜单在短暂延迟后";
                case ToolsResourceIdentifiers.BarCustomizationDialogCategories: return "类别";
                case ToolsResourceIdentifiers.BarCustomizationDialogButtonReset: return "复位";
                case ToolsResourceIdentifiers.BarCustomizationDialogAlwaysFullMenu: return "总是显示完整的菜单";
                case ToolsResourceIdentifiers.BarCustomizationDialogCommands: return "命令";
                case ToolsResourceIdentifiers.CustomMenu: return "自定义菜单";
                case ToolsResourceIdentifiers.BarCustomizationDialogCaption: return "定制";
                default:
                    return string.Empty;
            }
        }
    }
    #endregion
}
