namespace CSharp_ProgressBarAndStatusLabel
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FetchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.URLDropDown = new System.Windows.Forms.ComboBox();
            this.UrlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DesignTimeDataSet1 = new CSharp_ProgressBarAndStatusLabel.DataSet1();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesignTimeDataSet1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 64);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(903, 534);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FetchButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.URLDropDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 64);
            this.panel1.TabIndex = 4;
            // 
            // FetchButton
            // 
            this.FetchButton.Location = new System.Drawing.Point(554, 22);
            this.FetchButton.Name = "FetchButton";
            this.FetchButton.Size = new System.Drawing.Size(75, 23);
            this.FetchButton.TabIndex = 6;
            this.FetchButton.Text = "Fetch";
            this.FetchButton.UseVisualStyleBackColor = true;
            this.FetchButton.Click += new System.EventHandler(this.FetchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Google Map Location";
            // 
            // URLDropDown
            // 
            this.URLDropDown.DataSource = this.UrlBindingSource;
            this.URLDropDown.DisplayMember = "Title";
            this.URLDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.URLDropDown.FormattingEnabled = true;
            this.URLDropDown.Location = new System.Drawing.Point(25, 22);
            this.URLDropDown.Name = "URLDropDown";
            this.URLDropDown.Size = new System.Drawing.Size(523, 21);
            this.URLDropDown.TabIndex = 4;
            this.URLDropDown.ValueMember = "Url";
            // 
            // UrlBindingSource
            // 
            this.UrlBindingSource.DataMember = "Url";
            this.UrlBindingSource.DataSource = this.DesignTimeDataSet1;
            // 
            // DesignTimeDataSet1
            // 
            this.DesignTimeDataSet1.DataSetName = "DataSet1";
            this.DesignTimeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(903, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Ready...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(250, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 620);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Exciting Google Map locations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesignTimeDataSet1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FetchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox URLDropDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.BindingSource UrlBindingSource;
        private DataSet1 DesignTimeDataSet1;
    }
}

