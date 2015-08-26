namespace Ungu_CV1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.imageBoxOrig = new Emgu.CV.UI.ImageBox();
            this.imageBoxProcesssed = new Emgu.CV.UI.ImageBox();
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FaceCountButton = new System.Windows.Forms.Button();
            this.listBoxMinNeighbors = new System.Windows.Forms.ListBox();
            this.listBoxPictureList = new System.Windows.Forms.ListBox();
            this.listBoxScaleFactor = new System.Windows.Forms.ListBox();
            this.buttonSaveImg = new System.Windows.Forms.Button();
            this.listBoxMinSize = new System.Windows.Forms.ListBox();
            this.listBoxMax = new System.Windows.Forms.ListBox();
            this.listBoxClassifier = new System.Windows.Forms.ListBox();
            this.listBoxVideos = new System.Windows.Forms.ListBox();
            this.imageWindow1 = new Emgu.CV.UI.ImageBox();
            this.imageWindow2 = new Emgu.CV.UI.ImageBox();
            this.imageWindow3 = new Emgu.CV.UI.ImageBox();
            this.imageWindow4 = new Emgu.CV.UI.ImageBox();
            this.imageWindow5 = new Emgu.CV.UI.ImageBox();
            this.imageWindow6 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxProcesssed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow6)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBoxOrig
            // 
            this.imageBoxOrig.Location = new System.Drawing.Point(5, 1);
            this.imageBoxOrig.Name = "imageBoxOrig";
            this.imageBoxOrig.Size = new System.Drawing.Size(654, 587);
            this.imageBoxOrig.TabIndex = 2;
            this.imageBoxOrig.TabStop = false;
            this.imageBoxOrig.Click += new System.EventHandler(this.imageBoxOrig_Click);
            // 
            // imageBoxProcesssed
            // 
            this.imageBoxProcesssed.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imageBoxProcesssed.ImageLocation = "";
            this.imageBoxProcesssed.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageBoxProcesssed.InitialImage")));
            this.imageBoxProcesssed.Location = new System.Drawing.Point(692, 4);
            this.imageBoxProcesssed.Name = "imageBoxProcesssed";
            this.imageBoxProcesssed.Size = new System.Drawing.Size(1103, 587);
            this.imageBoxProcesssed.TabIndex = 2;
            this.imageBoxProcesssed.TabStop = false;
            this.imageBoxProcesssed.Click += new System.EventHandler(this.imageBox3_Click);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseResume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPauseResume.Location = new System.Drawing.Point(253, 732);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(103, 34);
            this.btnPauseResume.TabIndex = 3;
            this.btnPauseResume.Text = "Start";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(848, 594);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1015, 221);
            this.textBox1.TabIndex = 4;
            // 
            // FaceCountButton
            // 
            this.FaceCountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaceCountButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FaceCountButton.Location = new System.Drawing.Point(253, 677);
            this.FaceCountButton.Name = "FaceCountButton";
            this.FaceCountButton.Size = new System.Drawing.Size(103, 34);
            this.FaceCountButton.TabIndex = 5;
            this.FaceCountButton.Text = "FaceCount";
            this.FaceCountButton.UseVisualStyleBackColor = true;
            this.FaceCountButton.Click += new System.EventHandler(this.FaceCountButton_Click);
            // 
            // listBoxMinNeighbors
            // 
            this.listBoxMinNeighbors.FormattingEnabled = true;
            this.listBoxMinNeighbors.ItemHeight = 16;
            this.listBoxMinNeighbors.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.listBoxMinNeighbors.Location = new System.Drawing.Point(16, 786);
            this.listBoxMinNeighbors.Name = "listBoxMinNeighbors";
            this.listBoxMinNeighbors.Size = new System.Drawing.Size(104, 36);
            this.listBoxMinNeighbors.TabIndex = 7;
            this.listBoxMinNeighbors.SelectedIndexChanged += new System.EventHandler(this.listBoxMinNeighbors_SelectedIndexChanged);
            // 
            // listBoxPictureList
            // 
            this.listBoxPictureList.FormattingEnabled = true;
            this.listBoxPictureList.ItemHeight = 16;
            this.listBoxPictureList.Location = new System.Drawing.Point(603, 598);
            this.listBoxPictureList.Name = "listBoxPictureList";
            this.listBoxPictureList.Size = new System.Drawing.Size(239, 228);
            this.listBoxPictureList.TabIndex = 9;
            this.listBoxPictureList.SelectedIndexChanged += new System.EventHandler(this.listBoxPictureList_SelectedIndexChanged);
            // 
            // listBoxScaleFactor
            // 
            this.listBoxScaleFactor.FormattingEnabled = true;
            this.listBoxScaleFactor.ItemHeight = 16;
            this.listBoxScaleFactor.Items.AddRange(new object[] {
            "1.01",
            "1.02",
            "1.03",
            "1.04",
            "1.05",
            "1.06",
            "1.07",
            "1.08",
            "1.09",
            "1.10",
            "1.15",
            "1.20",
            "1.25",
            "1.30",
            "1.4",
            "1.5"});
            this.listBoxScaleFactor.Location = new System.Drawing.Point(16, 744);
            this.listBoxScaleFactor.Name = "listBoxScaleFactor";
            this.listBoxScaleFactor.Size = new System.Drawing.Size(104, 36);
            this.listBoxScaleFactor.TabIndex = 10;
            this.listBoxScaleFactor.SelectedIndexChanged += new System.EventHandler(this.listBoxScaleFactor_SelectedIndexChanged);
            // 
            // buttonSaveImg
            // 
            this.buttonSaveImg.Location = new System.Drawing.Point(253, 621);
            this.buttonSaveImg.Name = "buttonSaveImg";
            this.buttonSaveImg.Size = new System.Drawing.Size(103, 40);
            this.buttonSaveImg.TabIndex = 11;
            this.buttonSaveImg.Text = "SaveImg";
            this.buttonSaveImg.UseVisualStyleBackColor = true;
            this.buttonSaveImg.Click += new System.EventHandler(this.buttonSaveImg_Click);
            // 
            // listBoxMinSize
            // 
            this.listBoxMinSize.FormattingEnabled = true;
            this.listBoxMinSize.ItemHeight = 16;
            this.listBoxMinSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "28",
            "30",
            "32",
            "36",
            "40",
            "44",
            "48",
            "60",
            "72"});
            this.listBoxMinSize.Location = new System.Drawing.Point(16, 702);
            this.listBoxMinSize.Name = "listBoxMinSize";
            this.listBoxMinSize.Size = new System.Drawing.Size(104, 36);
            this.listBoxMinSize.TabIndex = 12;
            // 
            // listBoxMax
            // 
            this.listBoxMax.FormattingEnabled = true;
            this.listBoxMax.ItemHeight = 16;
            this.listBoxMax.Items.AddRange(new object[] {
            "40",
            "50",
            "60",
            "80",
            "100",
            "120",
            "128",
            "140",
            "150",
            "160",
            "180",
            "200",
            "220",
            "240",
            "260",
            "280",
            "300",
            "320",
            "340",
            "400"});
            this.listBoxMax.Location = new System.Drawing.Point(16, 660);
            this.listBoxMax.Name = "listBoxMax";
            this.listBoxMax.Size = new System.Drawing.Size(104, 36);
            this.listBoxMax.TabIndex = 13;
            // 
            // listBoxClassifier
            // 
            this.listBoxClassifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClassifier.FormattingEnabled = true;
            this.listBoxClassifier.ItemHeight = 18;
            this.listBoxClassifier.Items.AddRange(new object[] {
            "face_cascade",
            "facea_cascade",
            "face2_cascade",
            "facep_cascade",
            "bodyl_cascade",
            "bodyu_cascade",
            "bodyf_cascade"});
            this.listBoxClassifier.Location = new System.Drawing.Point(16, 594);
            this.listBoxClassifier.Name = "listBoxClassifier";
            this.listBoxClassifier.Size = new System.Drawing.Size(154, 58);
            this.listBoxClassifier.TabIndex = 14;
            this.listBoxClassifier.SelectedIndexChanged += new System.EventHandler(this.listBoxClassifier_SelectedIndexChanged);
            // 
            // listBoxVideos
            // 
            this.listBoxVideos.FormattingEnabled = true;
            this.listBoxVideos.ItemHeight = 16;
            this.listBoxVideos.Location = new System.Drawing.Point(362, 598);
            this.listBoxVideos.Name = "listBoxVideos";
            this.listBoxVideos.Size = new System.Drawing.Size(235, 228);
            this.listBoxVideos.TabIndex = 15;
            this.listBoxVideos.SelectedIndexChanged += new System.EventHandler(this.listBoxVideos_SelectedIndexChanged);
            // 
            // imageWindow1
            // 
            this.imageWindow1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imageWindow1.Location = new System.Drawing.Point(840, 4);
            this.imageWindow1.Margin = new System.Windows.Forms.Padding(0);
            this.imageWindow1.Name = "imageWindow1";
            this.imageWindow1.Size = new System.Drawing.Size(91, 78);
            this.imageWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageWindow1.TabIndex = 16;
            this.imageWindow1.TabStop = false;
            this.imageWindow1.Visible = false;
            // 
            // imageWindow2
            // 
            this.imageWindow2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imageWindow2.Location = new System.Drawing.Point(840, 88);
            this.imageWindow2.Name = "imageWindow2";
            this.imageWindow2.Size = new System.Drawing.Size(91, 81);
            this.imageWindow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageWindow2.TabIndex = 17;
            this.imageWindow2.TabStop = false;
            this.imageWindow2.Visible = false;
            // 
            // imageWindow3
            // 
            this.imageWindow3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imageWindow3.Location = new System.Drawing.Point(840, 175);
            this.imageWindow3.Name = "imageWindow3";
            this.imageWindow3.Size = new System.Drawing.Size(91, 86);
            this.imageWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageWindow3.TabIndex = 18;
            this.imageWindow3.TabStop = false;
            this.imageWindow3.Visible = false;
            // 
            // imageWindow4
            // 
            this.imageWindow4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imageWindow4.Location = new System.Drawing.Point(946, 4);
            this.imageWindow4.Name = "imageWindow4";
            this.imageWindow4.Size = new System.Drawing.Size(86, 78);
            this.imageWindow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageWindow4.TabIndex = 19;
            this.imageWindow4.TabStop = false;
            this.imageWindow4.Visible = false;
            // 
            // imageWindow5
            // 
            this.imageWindow5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imageWindow5.Location = new System.Drawing.Point(946, 88);
            this.imageWindow5.Name = "imageWindow5";
            this.imageWindow5.Size = new System.Drawing.Size(86, 81);
            this.imageWindow5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageWindow5.TabIndex = 20;
            this.imageWindow5.TabStop = false;
            this.imageWindow5.Visible = false;
            // 
            // imageWindow6
            // 
            this.imageWindow6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imageWindow6.Location = new System.Drawing.Point(946, 175);
            this.imageWindow6.Name = "imageWindow6";
            this.imageWindow6.Size = new System.Drawing.Size(86, 86);
            this.imageWindow6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageWindow6.TabIndex = 21;
            this.imageWindow6.TabStop = false;
            this.imageWindow6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 827);
            this.Controls.Add(this.imageWindow6);
            this.Controls.Add(this.imageWindow5);
            this.Controls.Add(this.imageWindow4);
            this.Controls.Add(this.imageWindow3);
            this.Controls.Add(this.imageWindow2);
            this.Controls.Add(this.imageWindow1);
            this.Controls.Add(this.listBoxVideos);
            this.Controls.Add(this.listBoxClassifier);
            this.Controls.Add(this.listBoxMax);
            this.Controls.Add(this.listBoxMinSize);
            this.Controls.Add(this.buttonSaveImg);
            this.Controls.Add(this.listBoxScaleFactor);
            this.Controls.Add(this.listBoxPictureList);
            this.Controls.Add(this.listBoxMinNeighbors);
            this.Controls.Add(this.FaceCountButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPauseResume);
            this.Controls.Add(this.imageBoxProcesssed);
            this.Controls.Add(this.imageBoxOrig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxProcesssed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWindow6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxOrig;
        private Emgu.CV.UI.ImageBox imageBoxProcesssed;
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FaceCountButton;
        private System.Windows.Forms.ListBox listBoxMinNeighbors;
        private System.Windows.Forms.ListBox listBoxPictureList;
        private System.Windows.Forms.ListBox listBoxScaleFactor;
        private System.Windows.Forms.Button buttonSaveImg;
        private System.Windows.Forms.ListBox listBoxMinSize;
        private System.Windows.Forms.ListBox listBoxMax;
        private System.Windows.Forms.ListBox listBoxClassifier;
        private System.Windows.Forms.ListBox listBoxVideos;
        private Emgu.CV.UI.ImageBox imageWindow1;
        private Emgu.CV.UI.ImageBox imageWindow2;
        private Emgu.CV.UI.ImageBox imageWindow3;
        private Emgu.CV.UI.ImageBox imageWindow4;
        private Emgu.CV.UI.ImageBox imageWindow5;
        private Emgu.CV.UI.ImageBox imageWindow6;
    }
}

