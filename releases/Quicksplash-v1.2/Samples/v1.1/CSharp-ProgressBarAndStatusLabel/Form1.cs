using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.IO;

using Splashscreen;

namespace CSharp_SampleApplication
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button CloseButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
			Application.Idle += new EventHandler(OnLoaded);
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			SplashscreenController.UpdateStatusLabel("Initialising background stuff...");
			Thread.Sleep(5000);
			SplashscreenController.UpdateStatusLabel("Loading UI stuff...");
			Application.Run(new Form1());
		}

		/// <summary>
		/// Custom "OnLoaded" event.  Fired after form finished loaded & displayed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		protected virtual void OnLoaded(object sender, EventArgs args)
		{
			Application.Idle -= new EventHandler(OnLoaded);
		            
			//Shut down the splashscreen
			SplashscreenController.CloseSplash();
		}

		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}


		#region Windows Form Designer generated code
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(72, 408);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Night arrives over Europe & Africa";
			this.label1.UseMnemonic = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(24, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(500, 375);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(448, 472);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.TabIndex = 2;
			this.CloseButton.Text = "&Close";
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 510);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuickSplash sample";
			this.ResumeLayout(false);

		}
		#endregion

	}
}
