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
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using Syncfusion.Office;
using ComboBox = System.Windows.Forms.ComboBox;

namespace EssentialDocIOSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private ButtonAdv button1;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox comboBoxSmartArtType;
        private Label label1;
        private IContainer components;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //			
            InitializeComponent();
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
            string filePath = @"common\SyncfusionLicense.txt";

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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxSmartArtType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(144, 34);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.KeepFocusRectangle = false;
            this.button1.Location = new System.Drawing.Point(330, 270);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generate";
            this.button1.ThemeName = "Metro";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 85);
            this.label2.TabIndex = 72;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxSmartArtType
            // 
            this.comboBoxSmartArtType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSmartArtType.FormattingEnabled = true;
            this.comboBoxSmartArtType.Items.AddRange(new object[] {
            "List",
            "Process",
            "Cycle",
            "Hierarchy",
            "Relationship",
            "Matrix",
            "Pyramid",
            "Picture"});
            this.comboBoxSmartArtType.Location = new System.Drawing.Point(190, 206);
            this.comboBoxSmartArtType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSmartArtType.Name = "comboBoxSmartArtType";
            this.comboBoxSmartArtType.Size = new System.Drawing.Size(159, 25);
            this.comboBoxSmartArtType.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(2, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "Choose SmartArt Type: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(490, 320);
            this.Controls.Add(this.comboBoxSmartArtType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create SmartArt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //Get Template document and database path.
            string dataPath = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\DocIO\";
            //Loads the template document.
            WordDocument document = new WordDocument(Path.Combine(dataPath, @"CreateSmartArtInput.docx"));

            string filename = "";
            // Select SmartArt type based on user choice.
            switch (comboBoxSmartArtType.SelectedIndex)
            {
                case 0:
                    // Create a List SmartArt diagram.
                    CreateListSmartArt(document);
                    filename = "CreateListSmartArt.docx";
                    break;
                case 1:
                    // Create a Process SmartArt diagram.
                    CreateProcessSmartArt(document);
                    filename = "CreateProcessSmartArt.docx";
                    break;
                case 2:
                    // Create a Cycle SmartArt diagram.
                    CreateCycleSmartArt(document);
                    filename = "CreateCycleSmartArt.docx";
                    break;
                case 3:
                    // Create a Hierarchy SmartArt diagram.
                    CreateHierarchySmartArt(document);
                    filename = "CreateHierarchySmartArt.docx";
                    break;
                case 4:
                    // Create a Relationship SmartArt diagram.
                    CreateRelationshipSmartArt(document);
                    filename = "CreateRelationshipSmartArt.docx";
                    break;
                case 5:
                    // Create a Matrix SmartArt diagram.
                    CreateMatrixSmartArt(document);
                    filename = "CreateMatrixSmartArt.docx";
                    break;
                case 6:
                    // Create a Pyramid SmartArt diagram.
                    CreatePyramidSmartArt(document);
                    filename = "CreatePyramidSmartArt.docx";
                    break;
                case 7:
                    // Create a Picture SmartArt diagram.
                    CreatePictureSmartArt(document);
                    filename = "CreatePictureSmartArt.docx";
                    break;
            }

            try
            {
                //Saving the document as .docx
                document.Save(filename, FormatType.Docx);
                //Message box confirmation to view the created document.
                if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]#if NETCORE
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo(filename) { UseShellExecute = true };
                            process.Start();
#else
                        System.Diagnostics.Process.Start(filename);
#endif
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxSmartArtType.SelectedIndex = 0;
            this.comboBoxSmartArtType.Enabled = true;
            this.label1.Enabled = true;
        }


        /// <summary>
        /// Creates a list SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateListSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];
            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            IWTextRange textRange = paragraph.AppendText("Project Planning List");
            textRange.CharacterFormat.FontSize = 28f;
            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Vertical Chevron List" layout.
            WSmartArt verticalChevronListSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.VerticalChevronList, 432, 252);

            // Add the "Planning" phase node.
            IOfficeSmartArtNode planningNode = verticalChevronListSmartArt.Nodes[0];
            planningNode.TextBody.Text = "Planning";
            planningNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(planningNode, "Set clear objectives.", "Allocate resources effectively.", 23f);

            // Add the "Execution" phase node.
            IOfficeSmartArtNode executionNode = verticalChevronListSmartArt.Nodes[1];
            executionNode.TextBody.Text = "Execution";
            executionNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(executionNode, "Assign tasks to the team.", "Track progress regularly.", 23f);

            // Add the "Review" phase node.
            IOfficeSmartArtNode reviewNode = verticalChevronListSmartArt.Nodes[2];
            reviewNode.TextBody.Text = "Review";
            reviewNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(reviewNode, "Analyze outcomes.", "Identify lessons learned.", 23f);

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Horizontal BulletList" layout
            WSmartArt horizontalBulletListSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.HorizontalBulletList, 432, 252);
            // Add the "Planning" phase node.
            planningNode = horizontalBulletListSmartArt.Nodes[0];
            planningNode.TextBody.Text = "Planning";
            planningNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            AddSmartArtChildNode(planningNode, "Set clear objectives.", "Allocate resources effectively.", 20f);

            // Add the "Execution" phase node
            executionNode = horizontalBulletListSmartArt.Nodes[1];
            executionNode.TextBody.Text = "Execution";
            executionNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            AddSmartArtChildNode(executionNode, "Assign tasks to the team.", "Track progress regularly.", 20f);

            // Add the "Review" phase node
            reviewNode = horizontalBulletListSmartArt.Nodes[2];
            reviewNode.TextBody.Text = "Review";
            reviewNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            AddSmartArtChildNode(reviewNode, "Analyze outcomes.", "Identify lessons learned.", 20f);
        }

        /// <summary>
        /// Creates a Process SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateProcessSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Healthy Lifestyle Journey");
            textRange1.CharacterFormat.FontSize = 28f;
            textRange1.CharacterFormat.FontName = "Times New Roman";
            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Segmented Process" layout
            WSmartArt segmentedProcessSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.SegmentedProcess, 432, 252);

            // Add the "Start" phase node
            IOfficeSmartArtNode startProcess = segmentedProcessSmartArt.Nodes[0];
            startProcess.TextBody.Text = "Start";
            startProcess.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(startProcess, "Begin exercise and eat balanced meals.", "Stay hydrated and prioritize sleep.", 12f);

            // Add the "Track" phase node
            IOfficeSmartArtNode trackProcess = segmentedProcessSmartArt.Nodes[1];
            trackProcess.TextBody.Text = "Track";
            trackProcess.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(trackProcess, "Record physical activity and food intake.", "Use a fitness app or journal.", 12f);

            // Add the "Sustain" phase node
            IOfficeSmartArtNode sustainProcess = segmentedProcessSmartArt.Nodes[2];
            sustainProcess.TextBody.Text = "Sustain";
            sustainProcess.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(sustainProcess, "Maintain healthy habits consistently.", "Set goals for continuous improvement.", 12f);

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "StepUp Process" layout
            WSmartArt stepUpProcessSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.StepUpProcess, 432, 252);

            // Add the "Start" phase node
            IOfficeSmartArtNode startNode = stepUpProcessSmartArt.Nodes[0];
            startNode.TextBody.Text = "Start";
            startNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 17f;
            startNode.ChildNodes.Add();
            startNode.ChildNodes.Add();
            AddSmartArtChildNode(startNode, "Begin exercise and eat balanced meals.", "Stay hydrated and prioritize sleep.", 13f);

            // Add the "Track" phase node
            IOfficeSmartArtNode trackNode = stepUpProcessSmartArt.Nodes[1];
            trackNode.TextBody.Text = "Track";
            trackNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 17f;
            trackNode.ChildNodes.Add();
            trackNode.ChildNodes.Add();
            AddSmartArtChildNode(trackNode, "Record physical activity and food intake.", "Use a fitness app or journal.", 13f);

            // Add the "Sustain" phase node
            IOfficeSmartArtNode sustainNode = stepUpProcessSmartArt.Nodes[2];
            sustainNode.TextBody.Text = "Sustain";
            sustainNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 17f;
            sustainNode.ChildNodes.Add();
            sustainNode.ChildNodes.Add();
            AddSmartArtChildNode(sustainNode, "Maintain healthy habits consistently.", "Set goals for continuous improvement.", 13f);
        }

        /// <summary>
        /// Creates a Cycle SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateCycleSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Customer Service Cycle");
            textRange1.CharacterFormat.FontSize = 28f;
            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Block Cycle" layout
            WSmartArt blockCycleSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.BlockCycle, 432, 252);

            // Add the "Inquiry" phase node
            IOfficeSmartArtNode inquiryNode = blockCycleSmartArt.Nodes[0];
            inquiryNode.TextBody.Text = "Inquiry";
            inquiryNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;

            // Add the "Response" phase node
            IOfficeSmartArtNode responseNode = blockCycleSmartArt.Nodes[1];
            responseNode.TextBody.Text = "Response";
            responseNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;

            // Add the "Resolution" phase node
            IOfficeSmartArtNode resolutionNode = blockCycleSmartArt.Nodes[2];
            resolutionNode.TextBody.Text = "Resolution";
            resolutionNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;

            // Add the "Feedback" phase node
            IOfficeSmartArtNode feedBackNode = blockCycleSmartArt.Nodes[3];
            feedBackNode.TextBody.Text = "Feedback";
            feedBackNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;

            // Add the "Follow-up" phase node
            IOfficeSmartArtNode followupNode = blockCycleSmartArt.Nodes[4];
            followupNode.TextBody.Text = "Follow-up";
            followupNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Basic Cycle" layout
            WSmartArt basicCycleSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.BasicCycle, 432, 252);

            // Add the "Inquiry" phase node
            IOfficeSmartArtNode inquiryCycleNode = basicCycleSmartArt.Nodes[0];
            inquiryCycleNode.TextBody.Text = "Inquiry";
            inquiryCycleNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 11f;

            // Add the "Response" phase node
            IOfficeSmartArtNode responseCycleNode = basicCycleSmartArt.Nodes[1];
            responseCycleNode.TextBody.Text = "Response";
            responseCycleNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 11f;

            // Add the "Resolution" phase node
            IOfficeSmartArtNode resolutionCycleNode = basicCycleSmartArt.Nodes[2];
            resolutionCycleNode.TextBody.Text = "Resolution";
            resolutionCycleNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 11f;

            // Add the "Feedback" phase node
            IOfficeSmartArtNode feedbackCycleNode = basicCycleSmartArt.Nodes[3];
            feedbackCycleNode.TextBody.Text = "Feedback";
            feedbackCycleNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 11f;

            // Add the "Follow-up" phase node
            IOfficeSmartArtNode followupCycleNode = basicCycleSmartArt.Nodes[4];
            followupCycleNode.TextBody.Text = "Follow-up";
            followupCycleNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 11f;

        }

        /// <summary>
        /// Creates a Hierarchy SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateHierarchySmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Company Organizational Structure");
            textRange1.CharacterFormat.FontSize = 28f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Hierarchy" layout
            WSmartArt hierarchySmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.Hierarchy, 432, 252);

            // Configure the "Manager" node and its hierarchy
            IOfficeSmartArtNode manager = hierarchySmartArt.Nodes[0];
            manager.TextBody.Text = "Manager";
            manager.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            manager.ChildNodes[0].TextBody.Text = "Team Lead 1";
            manager.ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            manager.ChildNodes[0].ChildNodes[0].TextBody.Text = "Employee 1";
            manager.ChildNodes[0].ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            manager.ChildNodes[0].ChildNodes[1].TextBody.Text = "Employee 2";
            manager.ChildNodes[0].ChildNodes[1].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            manager.ChildNodes[1].TextBody.Text = "Team Lead 2";
            manager.ChildNodes[1].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            manager.ChildNodes[1].ChildNodes[0].TextBody.Text = "Employee 3";
            manager.ChildNodes[1].ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Horizontal Hierarchy" layout
            WSmartArt horizontalHierarchySmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.HorizontalHierarchy, 432, 252);
            // Configure the "Manager" node and its hierarchy
            IOfficeSmartArtNode horizontalHierarchy = horizontalHierarchySmartArt.Nodes[0];
            horizontalHierarchy.TextBody.Text = "Manager";
            horizontalHierarchy.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
            horizontalHierarchy.ChildNodes[0].TextBody.Text = "Team Lead 1";
            horizontalHierarchy.ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
            horizontalHierarchy.ChildNodes[0].ChildNodes[0].TextBody.Text = "Employee 1";
            horizontalHierarchy.ChildNodes[0].ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
            horizontalHierarchy.ChildNodes[0].ChildNodes[1].TextBody.Text = "Employee 2";
            horizontalHierarchy.ChildNodes[0].ChildNodes[1].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
            horizontalHierarchy.ChildNodes[1].TextBody.Text = "Team Lead 2";
            horizontalHierarchy.ChildNodes[1].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
            horizontalHierarchy.ChildNodes[1].ChildNodes[0].TextBody.Text = "Employee 3";
            horizontalHierarchy.ChildNodes[1].ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
        }

        /// <summary>
        /// Creates a Relationship SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateRelationshipSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Remote Work vs Office Work");
            textRange1.CharacterFormat.FontSize = 28f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Counter Balance Arrows" layout
            WSmartArt counterBalanceArrowsSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.CounterBalanceArrows, 432, 252);
            // Add the "Remote Work" phase node
            IOfficeSmartArtNode remoteWorkNode = counterBalanceArrowsSmartArt.Nodes[0];
            remoteWorkNode.TextBody.Text = "Remote Work";
            remoteWorkNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 19f;
            remoteWorkNode.ChildNodes.Add();
            remoteWorkNode.ChildNodes.Add();
            AddSmartArtChildNode(remoteWorkNode, "Flexibility", "Work-Life Balance", 15f);

            // Add the "Office Work" phase node
            IOfficeSmartArtNode officeWorkNode = counterBalanceArrowsSmartArt.Nodes[1];
            officeWorkNode.TextBody.Text = "Office Work";
            officeWorkNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 19f;
            officeWorkNode.ChildNodes.Add();
            officeWorkNode.ChildNodes.Add();
            AddSmartArtChildNode(officeWorkNode, "Collaboration", "Structured Environment", 15f);

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Opposing Ideas" layout
            WSmartArt opposingIdeasSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.OpposingIdeas, 432, 252);

            // Add the "Remote Work" phase node
            remoteWorkNode = opposingIdeasSmartArt.Nodes[0];
            remoteWorkNode.TextBody.Text = "Remote Work";
            remoteWorkNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            remoteWorkNode.ChildNodes.Add();
            AddSmartArtChildNode(remoteWorkNode, "Flexibility", "Work-Life Balance", 20f);

            // Add the "Office Work" phase node
            officeWorkNode = opposingIdeasSmartArt.Nodes[1];
            officeWorkNode.TextBody.Text = "Office Work";
            officeWorkNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            officeWorkNode.ChildNodes.Add();
            AddSmartArtChildNode(officeWorkNode, "Collaboration", "Structured Environment", 20f);
        }

        /// <summary>
        /// Creates a Matrix SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateMatrixSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Marketing Campaign Process");
            textRange1.CharacterFormat.FontSize = 28f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Grid Matrix" layout
            WSmartArt gridMatrixSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.GridMatrix, 432, 252);

            // Add the "Planning" phase node
            IOfficeSmartArtNode planningNode = gridMatrixSmartArt.Nodes[0];
            planningNode.TextBody.Text = "Planning";
            planningNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 13f;
            planningNode.ChildNodes.Add();
            planningNode.ChildNodes.Add();
            AddSmartArtChildNode(planningNode, "Define goals and target audience.", "Identify key messaging and channels.", 10f);

            // Add the "Execution" phase node
            IOfficeSmartArtNode executionNode = gridMatrixSmartArt.Nodes[1];
            executionNode.TextBody.Text = "Execution";
            executionNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 13f;
            executionNode.ChildNodes.Add();
            executionNode.ChildNodes.Add();
            AddSmartArtChildNode(executionNode, "Create content and implement strategies.", "Launch campaigns across chosen platforms.", 10f);

            // Add the "Monitoring" phase node
            IOfficeSmartArtNode monitoringNode = gridMatrixSmartArt.Nodes[2];
            monitoringNode.TextBody.Text = "Monitoring";
            monitoringNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 13f;
            monitoringNode.ChildNodes.Add();
            monitoringNode.ChildNodes.Add();
            AddSmartArtChildNode(monitoringNode, "Track performance and engagement.", "Collect data and identify trends.", 10f);

            // Add the "Optimization" phase node
            IOfficeSmartArtNode optimizingNode = gridMatrixSmartArt.Nodes[3];
            optimizingNode.TextBody.Text = "Optimization";
            optimizingNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 13f;
            optimizingNode.ChildNodes.Add();
            optimizingNode.ChildNodes.Add();
            AddSmartArtChildNode(optimizingNode, "Adjust strategies based on insights.", "Fine-tune campaigns for better results.", 10f);

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Cycle Matrix" layout
            WSmartArt cycleMatrixSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.CycleMatrix, 432, 252);

            // Add the "Planning" phase node
            planningNode = cycleMatrixSmartArt.Nodes[0];
            planningNode.TextBody.Text = "Planning";
            planningNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 12f;
            planningNode.ChildNodes.Add();
            AddSmartArtChildNode(planningNode, "Define goals and target audience.", "Identify key messaging and channels.", 8f);

            // Add the "Execution" phase node
            executionNode = cycleMatrixSmartArt.Nodes[1];
            executionNode.TextBody.Text = "Execution";
            executionNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 12f;
            executionNode.ChildNodes.Add();
            AddSmartArtChildNode(executionNode, "Create content and implement strategies.", "Launch campaigns across chosen platforms.", 8f);

            // Add the "Monitoring" phase node
            monitoringNode = cycleMatrixSmartArt.Nodes[2];
            monitoringNode.TextBody.Text = "Monitoring";
            monitoringNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 12f;
            monitoringNode.ChildNodes.Add();
            AddSmartArtChildNode(monitoringNode, "Track performance and engagement.", "Collect data and identify trends.", 8f);

            // Add the "Optimization" phase node
            optimizingNode = cycleMatrixSmartArt.Nodes[3];
            optimizingNode.TextBody.Text = "Optimization";
            optimizingNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 12f;
            optimizingNode.ChildNodes.Add();
            AddSmartArtChildNode(optimizingNode, "Adjust strategies based on insights.", "Fine-tune campaigns for better results.", 8f);

        }

        /// <summary>
        /// Creates a Pyramid SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreatePyramidSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Personal Growth");
            textRange1.CharacterFormat.FontSize = 28f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Basic Pyramid" layout
            WSmartArt basicPyramidSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.BasicPyramid, 432, 252);

            // Add the "Achievement" phase node
            IOfficeSmartArtNode achievementNode = basicPyramidSmartArt.Nodes[0];
            achievementNode.TextBody.Text = "Achievement";
            achievementNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 26f;

            // Add the "Skill Development" phase node
            IOfficeSmartArtNode SkilldevelopmentNode = basicPyramidSmartArt.Nodes[1];
            SkilldevelopmentNode.TextBody.Text = "Skill Development";
            SkilldevelopmentNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 26f;

            // Add the "Self-Awareness" phase node
            IOfficeSmartArtNode selfAwarenessNode = basicPyramidSmartArt.Nodes[2];
            selfAwarenessNode.TextBody.Text = "Self-Awareness";
            selfAwarenessNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 26f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Pyramid List" layout
            WSmartArt pyramidListSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.PyramidList, 432, 252);

            // Add the "Self-Awareness" phase node
            selfAwarenessNode = pyramidListSmartArt.Nodes[0];
            selfAwarenessNode.TextBody.Text = "Self-Awareness";
            selfAwarenessNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;

            // Add the "Skill Development" phase node
            SkilldevelopmentNode = pyramidListSmartArt.Nodes[1];
            SkilldevelopmentNode.TextBody.Text = "Skill Development";
            SkilldevelopmentNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;

            // Add the "Achievement" phase node
            achievementNode = pyramidListSmartArt.Nodes[2];
            achievementNode.TextBody.Text = "Achievement";
            achievementNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
        }

        /// <summary>
        /// Creates a Picture SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreatePictureSmartArt(WordDocument document)
        {
            //Get Template document and database path.
            string dataPath = Application.StartupPath + @"..\..\..\..\..\..\..\common\Images\DocIO\";
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            WTextRange textRange1 = paragraph.AppendText("Employee Report") as WTextRange;
            textRange1.CharacterFormat.FontSize = 28f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            // Add SmartArt with "Picture Strips" layout
            WSmartArt pictureStripsSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.PictureStrips, 432, 252);

            // Add the "Employee1" phase node
            IOfficeSmartArtNode employeeNode1 = pictureStripsSmartArt.Nodes[0];
            employeeNode1.TextBody.Text = "Nancy Davolio";
            employeeNode1.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 25f;
            AddPicture(employeeNode1, dataPath + "Nancy Davolio.png");

            // Add the "Employee2" phase node
            IOfficeSmartArtNode employeeNode2 = pictureStripsSmartArt.Nodes[1];
            employeeNode2.TextBody.Text = "Andrew Fuller";
            employeeNode2.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 25f;
            AddPicture(employeeNode2, dataPath + "Andrew Fuller.png");

            // Add the "Employee3" phase node
            IOfficeSmartArtNode employeeNode3 = pictureStripsSmartArt.Nodes[2];
            employeeNode3.TextBody.Text = "Janet Leverling";
            employeeNode3.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 25f;
            AddPicture(employeeNode3, dataPath + "Janet Leverling.png");
        }

        /// <summary>
        /// Adds two child nodes to a given SmartArt node and applies formatting.
        /// </summary>
        /// <param name="node">The SmartArt node to which child nodes will be added.</param>
        /// <param name="childText1">Text content for the first child node.</param>
        /// <param name="childText2">Text content for the second child node.</param>
        /// <param name="fontSize">Font size to be applied to the child nodes.</param>
        private void AddSmartArtChildNode(IOfficeSmartArtNode node, string childText1, string childText2, float fontSize)
        {
            node.ChildNodes[0].TextBody.Text = childText1;
            node.ChildNodes[1].TextBody.Text = childText2;
            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
                node.ChildNodes[i].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = fontSize;
            }
        }

        /// <summary>
        /// Loads an image from the specified file path and assigns it to the given SmartArt node.
        /// </summary>
        /// <param name="node">The SmartArt node where the image will be applied.</param>
        /// <param name="imagePath">The file path of the image to be assigned.</param>
        private void AddPicture(IOfficeSmartArtNode node, string imagePath)
        {
            // Load the image and assign it to the SmartArt node
            FileStream pictureStream = new FileStream(imagePath, FileMode.Open);
            MemoryStream memoryStream = new MemoryStream();
            pictureStream.CopyTo(memoryStream);

            //Convert the memory stream into a byte array
            byte[] picByte = memoryStream.ToArray();
            node.Shapes[1].Fill.FillType = OfficeShapeFillType.Picture;
            node.Shapes[1].Fill.PictureFill.ImageBytes = picByte;
            //Dispose the image stream.
            pictureStream.Dispose();
            memoryStream.Dispose();
        }
    }
}
