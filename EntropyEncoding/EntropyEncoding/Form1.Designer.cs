namespace EntropyEncoding
{
  partial class Form1
  {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent()
    {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.input_textbox_huffman_pattern = new System.Windows.Forms.TextBox();
			this.res_treeview_huffman_tree = new System.Windows.Forms.TreeView();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.res_treeview_huffman_tree);
			this.groupBox1.Controls.Add(this.input_textbox_huffman_pattern);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(292, 398);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "哈夫曼";
			// 
			// input_textbox_huffman_pattern
			// 
			this.input_textbox_huffman_pattern.Location = new System.Drawing.Point(6, 20);
			this.input_textbox_huffman_pattern.Multiline = true;
			this.input_textbox_huffman_pattern.Name = "input_textbox_huffman_pattern";
			this.input_textbox_huffman_pattern.Size = new System.Drawing.Size(280, 65);
			this.input_textbox_huffman_pattern.TabIndex = 0;
			// 
			// res_treeview_huffman_tree
			// 
			this.res_treeview_huffman_tree.Location = new System.Drawing.Point(6, 91);
			this.res_treeview_huffman_tree.Name = "res_treeview_huffman_tree";
			this.res_treeview_huffman_tree.Size = new System.Drawing.Size(280, 268);
			this.res_treeview_huffman_tree.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(211, 365);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "刷新";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 422);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "熵编码";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox input_textbox_huffman_pattern;
    private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TreeView res_treeview_huffman_tree;
	}
}

