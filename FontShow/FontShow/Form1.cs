using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FontShow
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = new FontDialog();
			if (fontDialog.ShowDialog() != DialogResult.Cancel)
			{
				this.textBox1.Font = fontDialog.Font;
			}
		}
	}
}
