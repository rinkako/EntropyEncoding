namespace ToGray
{
	partial class Form2
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.previewPicture = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.previewPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(593, 400);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "效果预览";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.previewPicture);
			this.panel1.Location = new System.Drawing.Point(6, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(587, 380);
			this.panel1.TabIndex = 8;
			// 
			// previewPicture
			// 
			this.previewPicture.Location = new System.Drawing.Point(0, 0);
			this.previewPicture.Name = "previewPicture";
			this.previewPicture.Size = new System.Drawing.Size(581, 377);
			this.previewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.previewPicture.TabIndex = 3;
			this.previewPicture.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(513, 418);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "另存为";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 448);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preview";
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.previewPicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox previewPicture;
		private System.Windows.Forms.Button button1;
	}
}