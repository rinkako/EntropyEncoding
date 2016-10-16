namespace DCT
{
	partial class ReDCTForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReDCTForm));
			this.input_textBox4 = new System.Windows.Forms.TextBox();
			this.input_textBox3 = new System.Windows.Forms.TextBox();
			this.input_textBox2 = new System.Windows.Forms.TextBox();
			this.input_textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// input_textBox4
			// 
			this.input_textBox4.Location = new System.Drawing.Point(398, 146);
			this.input_textBox4.Multiline = true;
			this.input_textBox4.Name = "input_textBox4";
			this.input_textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.input_textBox4.Size = new System.Drawing.Size(380, 128);
			this.input_textBox4.TabIndex = 13;
			this.input_textBox4.Text = "C3 C0 C5 CF D5 C7 99 89\r\nA7 A3 9C 9E A6 A2 89 91\r\n99 96 92 90 90 8C 8C 96\r\n90 88 " +
    "87 81 7F 8B 98 9A\r\n74 70 74 78 8C A2 9D 94\r\n80 85 8D 99 A0 A1 94 8D\r\n9C 9E A1 A1" +
    " A1 9D 8D 94\r\nA6 A5 A5 A6 A1 99 96 95";
			// 
			// input_textBox3
			// 
			this.input_textBox3.Location = new System.Drawing.Point(12, 146);
			this.input_textBox3.Multiline = true;
			this.input_textBox3.Name = "input_textBox3";
			this.input_textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.input_textBox3.Size = new System.Drawing.Size(380, 128);
			this.input_textBox3.TabIndex = 12;
			this.input_textBox3.Text = "76 7A 7C 87 91 A3 B3 C3\r\n7F 83 7F 7E 89 96 9A A2\r\n7A 7F 81 7F 7F 8C 90 90\r\n7F 7B " +
    "77 77 7A 81 84 87\r\n84 7E 7C 76 74 70 72 74\r\n85 81 87 88 83 7C 78 7C\r\n88 89 92 96" +
    " 96 9A 9D 9D\r\n94 94 9C A1 A5 AB B2 AE";
			// 
			// input_textBox2
			// 
			this.input_textBox2.Location = new System.Drawing.Point(398, 12);
			this.input_textBox2.Multiline = true;
			this.input_textBox2.Name = "input_textBox2";
			this.input_textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.input_textBox2.Size = new System.Drawing.Size(380, 128);
			this.input_textBox2.TabIndex = 11;
			this.input_textBox2.Text = "B2 C9 EA E4 C9 B8 D3 E2\r\nB3 CB E2 EA D3 CD E6 E2\r\nA7 A9 B7 BC D4 D8 C0 B2\r\n84 83 " +
    "92 91 9D A2 98 90\r\n6F 6B 7A 7F 8B 85 5D 4E\r\n51 5F 6D 72 77 67 5C 54\r\n72 72 7F 89" +
    " 8D 94 8B 7E\r\nAE AF BE C9 CC C7 A2 89";
			// 
			// input_textBox1
			// 
			this.input_textBox1.Location = new System.Drawing.Point(12, 12);
			this.input_textBox1.Multiline = true;
			this.input_textBox1.Name = "input_textBox1";
			this.input_textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.input_textBox1.Size = new System.Drawing.Size(380, 128);
			this.input_textBox1.TabIndex = 10;
			this.input_textBox1.Text = resources.GetString("input_textBox1.Text");
			// 
			// ReDCTForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 279);
			this.Controls.Add(this.input_textBox4);
			this.Controls.Add(this.input_textBox3);
			this.Controls.Add(this.input_textBox2);
			this.Controls.Add(this.input_textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ReDCTForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "反向计算结果";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox input_textBox4;
		private System.Windows.Forms.TextBox input_textBox3;
		private System.Windows.Forms.TextBox input_textBox2;
		private System.Windows.Forms.TextBox input_textBox1;
	}
}