#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;

namespace EssentialDocIOSamples
{

    public class Form1 : MetroForm
    {
        #region Private Members

        private ToolTip toolTip1;
        private ButtonAdv buttonAdv1;
        private PictureBox pictureBox1;
        private Label label2;
        private IContainer components;

        #endregion

        #region Constructor, Main and Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //			
            InitializeComponent();
            Application.EnableVisualStyles();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        /// <summary>
        /// Helper method to find a syncfusion license key from the Common folder
        /// </summary>
        /// <param name="fileName">File name of the syncfusion license key</param>
        /// <returns></returns>
        public static string FindLicenseKey()
        {
            int levelsToCheck = 12;
            string filePath = @"Common\SyncfusionLicense.txt";

            string rootPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase.Replace(@"file:///", ""));

            for (int n = 0; n < levelsToCheck; n++)
            {
                string fileDataPath = System.IO.Path.Combine(rootPath, filePath);
                if (System.IO.File.Exists(fileDataPath))
                    return File.ReadAllText(fileDataPath, Encoding.UTF8);
                DirectoryInfo rootDirectory = Directory.GetParent(rootPath);
                if (rootDirectory == null)
                    break;
                rootPath = rootDirectory.FullName;
            }
            return string.Empty;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
		    SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(173, 33);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(287, 213);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv1.Size = new System.Drawing.Size(173, 33);
            this.buttonAdv1.TabIndex = 62;
            this.buttonAdv1.Text = "Generate";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 120);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 72);
            this.label2.TabIndex = 68;
            this.label2.Text = "Click the button to view the generated Word document. Please note that Microsoft " +
    "Word Viewer or Microsoft Word is required to view the resultant Word document.";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 22);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(486, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.pictureBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Mapping";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button_Click Event
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Get XML file path.
                string dataPath = Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Data\DocIO\";

                // Create a new document.
                WordDocument document = new WordDocument();

                //Add a section & a paragraph in the empty document.
                document.EnsureMinimal();

                //Loads XML file into the customXML part of the Word document.
                CustomXMLPart docIOxmlPart = new CustomXMLPart(document);
                docIOxmlPart.Load(System.IO.Path.Combine(dataPath, "Employees.xml"));

                //Insert content controls and maps Employees details to it.
                InsertAndMapEmployees(document, "EmployeesList", docIOxmlPart);

                //Saving the document as .docx
                document.Save("Sample.docx", FormatType.Docx);
                document.Close();

                //Message box confirmation to view the created document.
                if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.docx");
                        //Exit
                        this.Close();
                    }
                    catch (Win32Exception ex)
                    {
                        MessageBoxAdv.Show("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                        Console.WriteLine(ex.ToString());
                    }
                }
                else
                {
                    // Exit
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

       #region Helper Method
        /// <summary>
        /// Insert and Maps CustomXMLPart to content control based on XPath.
        /// </summary>
        /// <param name="paragraph">Paragraph instance to append content control.</param>
        /// <param name="XPath">XPath of the CustomXMLNode to be mapped</param>
        /// <param name="custXMLPart">CustomXMLPart of the CustomXMLNode</param>
        private void MapCustomXMLPart(IWParagraph paragraph, string XPath, CustomXMLPart custXMLPart)
        {
            IInlineContentControl contentControl = paragraph.AppendInlineContentControl(ContentControlType.Text);
            contentControl.ContentControlProperties.XmlMapping.SetMapping(XPath, string.Empty, custXMLPart);
        }        
        /// <summary>
        /// Inserts content control and maps the employees details to it. 
        /// </summary>
        /// <param name="document">Word document instance.</param>
        /// <param name="xmlRootPath">Custom XML root Xpath.</param>
        /// <param name="docIOxmlPart">CustomXMLPart instance.</param>
        private void InsertAndMapEmployees(WordDocument document, string xmlRootPath, CustomXMLPart docIOxmlPart)
        {
            //Retrieving CustomXMLNode from xmlRootPath.
            CustomXMLNode parentNode = docIOxmlPart.SelectSingleNode(xmlRootPath);

            int empIndex = 1;
            foreach (CustomXMLNode employeeNode in parentNode.ChildNodes)
            {
                if (employeeNode.HasChildNodes())
                {
                    //Adds new paragraph to the section
                    IWParagraph paragraph = document.LastSection.AddParagraph();
                    paragraph.ParagraphFormat.BackColor = Color.Gray;

                    IWTextRange textrange = paragraph.AppendText("Employee");
                    textrange.CharacterFormat.TextColor = Color.White;
                    textrange.CharacterFormat.Bold = true;
                    textrange.CharacterFormat.FontSize = 14;

                    //Insert content controls and maps Employee details to it.
                    InsertAndMapEmployee(document,employeeNode,xmlRootPath, docIOxmlPart,empIndex);
                }
                empIndex++;
            }
        }
        /// <summary>
        /// Inserts content control and maps the employee details to it.
        /// </summary>
        /// <param name="document">Word document instance.</param>
        /// <param name="employeesNode">CustomXMLNode of employee.</param>
        /// <param name="rootXmlPath">Custom XML root Xpath.</param>
        /// <param name="docIOxmlPart">CustomXMLPart instance.</param>
        /// <param name="empIndex">Current employee index.</param>
        private void InsertAndMapEmployee(WordDocument document, CustomXMLNode employeesNode, string rootXmlPath, CustomXMLPart docIOxmlPart, int empIndex)
        {
            //Column names of Employee element.
            string[] employeesDetails = { "FirstName", "LastName", "Employee ID", "Extension", "Address", "City", "Country" };
            int empChildIndex = 0;
            int customerIndex = 1;

            // Append current empolyee XPath with root XPath.
            string empPath = "/" + rootXmlPath + "/Employees[" + empIndex + "]/";                
            // Iterating child elements of Employee
            foreach (CustomXMLNode employeeChild in employeesNode.ChildNodes)
            {
                IWParagraph paragraph = document.LastParagraph;                
                if (employeeChild.HasChildNodes())
                {
                    //Insert a content controls and maps Customer details to it.
                    InsertAndMapCustomer(document, employeeChild, docIOxmlPart, empPath, customerIndex);
                    customerIndex++;
                }
                else
                {
                    if (empChildIndex != 1)
                    {
                        //Insert a content controls and maps Employee details other than Customer details to it.
                        paragraph = document.LastSection.AddParagraph();
                        if (empChildIndex == 0 )
                            paragraph.AppendText("Name: ");
                        else
                            paragraph.AppendText(employeesDetails[empChildIndex] + ": ");
                    }
					 else
                        paragraph.AppendText(" ");
                    MapCustomXMLPart(paragraph, empPath + employeesDetails[empChildIndex].Replace(" ",""), docIOxmlPart);
         
                }
                empChildIndex++;
            }            
        }
        /// <summary>
        /// Insert a content controls and maps Customer details to it.
        /// </summary>
        /// <param name="document">Word document instance.</param>
        /// <param name="customerNode">CustomXMLNode of customer.</param>
        /// <param name="docIOxmlPart">CustomXMLPart instance.</param>
        /// <param name="empPath">Current employee index.</param>
        /// <param name="custIndex">Current customer index.</param>
        private void InsertAndMapCustomer(WordDocument document, CustomXMLNode customerNode, CustomXMLPart docIOxmlPart, string empPath, int custIndex)
        {
            //Column names of Customer element.
            string[] customersDetails = { "Customer ID", "Employee ID", "Company Name", "Contact Name", "City", "Country" };

            document.LastSection.AddParagraph();

            //Adds new paragraph to the section
            IWParagraph paragraph = document.LastSection.AddParagraph();
            paragraph.ParagraphFormat.BackColor = Color.Green;
            paragraph.ParagraphFormat.LeftIndent = 72;

            IWTextRange textrange = paragraph.AppendText("Customers");
            textrange.CharacterFormat.TextColor = Color.White;
            textrange.CharacterFormat.Bold = true;
            textrange.CharacterFormat.FontSize = 14;

            int orderIndex = 1;
            int custChild = 0;
            bool isFirstOrder = true;
            string customerXpath =  empPath+ "Customers[" + custIndex + "]/";
            foreach(CustomXMLNode customerChild in customerNode.ChildNodes)
            {
                if (customerChild.HasChildNodes())
                {                    
                    //Insert a content controls and maps Orders details to it.
                    InsertAndMapOrders(document, customerChild, docIOxmlPart, customerXpath, orderIndex,isFirstOrder);
                    document.LastSection.AddParagraph();
                    isFirstOrder = false;
                    orderIndex++;
                }
                else
                {
                    //Insert a content controls and maps Customer details other than Order details to it.
                    paragraph = document.LastSection.AddParagraph();
                    paragraph.ParagraphFormat.LeftIndent = 72;

                    paragraph.AppendText(customersDetails[custChild] + ": ");
                    MapCustomXMLPart(paragraph, customerXpath + customersDetails[custChild].Replace(" ", ""), docIOxmlPart);
                }
                custChild++;
            }
        }
        /// <summary>
        /// Insert a content controls and maps Orders details to it.
        /// </summary>
        /// <param name="document">Word document instance.</param>
        /// <param name="orderNode">CustomXMLNode of order.</param>
        /// <param name="docIOxmlPart">CustomXMLPart instance.</param>
        /// <param name="custPath">Current customer index</param>
        /// <param name="orderIndex">Current order index</param>
        /// <param name="isFirst">Indicates whether it is the first order of the customer.</param>
        private void InsertAndMapOrders(WordDocument document,CustomXMLNode orderNode, CustomXMLPart docIOxmlPart,string custPath,int orderIndex,bool isFirst)
        {
            //Column names of order element.
            string[] ordersDetails = { "Order ID", "Customer ID", "Order Date", "Shipped Date", "Required Date" };

            IWParagraph paragraph = null;
            IWTextRange textrange = null;
            if (isFirst)
            {
                document.LastSection.AddParagraph();
                //Adds new paragraph to the section
                paragraph = document.LastSection.AddParagraph();
                paragraph.ParagraphFormat.BackColor = Color.Red;
                paragraph.ParagraphFormat.LeftIndent = 128;

                textrange = paragraph.AppendText("Orders");
                textrange.CharacterFormat.TextColor = Color.White;
                textrange.CharacterFormat.Bold = true;
                textrange.CharacterFormat.FontSize = 14;
            }
            int orderChildIndex = 0;
            string customerXpath = custPath + "Orders[" + orderIndex + "]/";
            foreach(CustomXMLNode orderChild in orderNode.ChildNodes)
            {
                //Adds new paragraph to the section
                paragraph = document.LastSection.AddParagraph();
                paragraph.ParagraphFormat.LeftIndent = 128;

                paragraph.AppendText(ordersDetails[orderChildIndex] + ": ");
                MapCustomXMLPart(paragraph, customerXpath + "/" + ordersDetails[orderChildIndex].Replace(" ", ""), docIOxmlPart);
                orderChildIndex++;
            }
        }

        #endregion
    }
}

