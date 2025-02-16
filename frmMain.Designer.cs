namespace GroupboxCheckboxEx
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbProperties = new System.Windows.Forms.GroupBox();
			this.cbItalic = new System.Windows.Forms.CheckBox();
			this.cbBold = new System.Windows.Forms.CheckBox();
			this.llExample = new System.Windows.Forms.Label();
			this.gbProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbProperties
			// 
			this.gbProperties.Controls.Add(this.cbBold);
			this.gbProperties.Controls.Add(this.cbItalic);
			this.gbProperties.Location = new System.Drawing.Point(12, 12);
			this.gbProperties.Name = "gbProperties";
			this.gbProperties.Size = new System.Drawing.Size(162, 96);
			this.gbProperties.TabIndex = 0;
			this.gbProperties.TabStop = false;
			this.gbProperties.Text = "Properties";
			// 
			// cbItalic
			// 
			this.cbItalic.AutoSize = true;
			this.cbItalic.Location = new System.Drawing.Point(16, 27);
			this.cbItalic.Name = "cbItalic";
			this.cbItalic.Size = new System.Drawing.Size(51, 19);
			this.cbItalic.TabIndex = 0;
			this.cbItalic.Text = "Italic";
			this.cbItalic.UseVisualStyleBackColor = true;
			this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
			// 
			// cbBold
			// 
			this.cbBold.AutoSize = true;
			this.cbBold.Location = new System.Drawing.Point(16, 61);
			this.cbBold.Name = "cbBold";
			this.cbBold.Size = new System.Drawing.Size(50, 19);
			this.cbBold.TabIndex = 1;
			this.cbBold.Text = "Bold";
			this.cbBold.UseVisualStyleBackColor = true;
			this.cbBold.CheckedChanged += new System.EventHandler(this.cbBold_CheckedChanged);
			// 
			// llExample
			// 
			this.llExample.AutoSize = true;
			this.llExample.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.llExample.Location = new System.Drawing.Point(12, 122);
			this.llExample.Name = "llExample";
			this.llExample.Size = new System.Drawing.Size(150, 32);
			this.llExample.TabIndex = 1;
			this.llExample.Text = "Example text";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 171);
			this.Controls.Add(this.llExample);
			this.Controls.Add(this.gbProperties);
			this.Name = "Form1";
			this.Text = "Groupbox and checkbox example";
			this.gbProperties.ResumeLayout(false);
			this.gbProperties.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GroupBox gbProperties;
		private CheckBox cbBold;
		private CheckBox cbItalic;
		private Label llExample;
	}
}