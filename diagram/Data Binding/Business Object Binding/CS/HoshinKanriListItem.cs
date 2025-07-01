#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

using System.Web;

/// <summary>
/// Summary description for HoshinKanriListItem
/// </summary>
public class HoshinKanriListItem
{

    private string content = string.Empty;
    private string content1 = string.Empty;
    private List<string> subContent = new List<string>();
    private List<string[]> plan = new List<string[]>();
    private List<string[]> actual = new List<string[]>();
    private List<string> leader = new List<string>();
    private List<string> resources = new List<string>();
    private List<string> comments = new List<string>();
    private List<string> costSavings = new List<string>();
    private List<string> toolTip = new List<string>();
    public List<bool> isOuterRectangle = new List<bool>();

    public string Content { get { return content; } set { content = value; } }
    public string Content1 { get { return content1; } set { content1 = value; } }
    public List<string> SubContent { get { return subContent; } set { subContent = value; } }
    public List<string[]> Plan { get { return plan; } set { plan = value; } }
    public List<string[]> Actual { get { return actual; } set { actual = value; } }
    public List<string> Leader { get { return leader; } set { leader = value; } }
    public List<string> Resources { get { return resources; } set { resources = value; } }
    public List<string> Comments { get { return comments; } set { comments = value; } }
    public List<string> CostSavings { get { return costSavings; } set { costSavings = value; } }
    public List<string> ToolTip { get { return toolTip; } set { toolTip = value; } }
    public List<bool> IsOuterRectangle { get { return isOuterRectangle; } set { isOuterRectangle = value; } }
}