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
			this.button1 = new System.Windows.Forms.Button();
			this.res_treeview_huffman_tree = new System.Windows.Forms.TreeView();
			this.input_textbox_huffman_pattern = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.output_textbox_math_decodeproc = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.output_textbox_math_encodeproc = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.output_textbox_math_decoded = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.output_textbox_math_encoded = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.output_textbox_math_symbols = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.input_textbox_math_pattern = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.output_textbox_lzw_encodeproc = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.output_textbox_lzw_decodeproc = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			this.groupBox1.Text = "哈夫曼树";
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
			// res_treeview_huffman_tree
			// 
			this.res_treeview_huffman_tree.Location = new System.Drawing.Point(6, 76);
			this.res_treeview_huffman_tree.Name = "res_treeview_huffman_tree";
			this.res_treeview_huffman_tree.Size = new System.Drawing.Size(280, 283);
			this.res_treeview_huffman_tree.TabIndex = 1;
			// 
			// input_textbox_huffman_pattern
			// 
			this.input_textbox_huffman_pattern.Location = new System.Drawing.Point(6, 20);
			this.input_textbox_huffman_pattern.Multiline = true;
			this.input_textbox_huffman_pattern.Name = "input_textbox_huffman_pattern";
			this.input_textbox_huffman_pattern.Size = new System.Drawing.Size(280, 50);
			this.input_textbox_huffman_pattern.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.output_textbox_math_decodeproc);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.output_textbox_math_encodeproc);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.output_textbox_math_decoded);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.output_textbox_math_encoded);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.output_textbox_math_symbols);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.input_textbox_math_pattern);
			this.groupBox2.Location = new System.Drawing.Point(310, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(609, 398);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "算术编码";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(153, 308);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 12);
			this.label7.TabIndex = 21;
			this.label7.Text = "长度：";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(155, 323);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(75, 21);
			this.textBox1.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(236, 209);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 12);
			this.label6.TabIndex = 19;
			this.label6.Text = "解码过程：";
			// 
			// output_textbox_math_decodeproc
			// 
			this.output_textbox_math_decodeproc.Location = new System.Drawing.Point(236, 224);
			this.output_textbox_math_decodeproc.Multiline = true;
			this.output_textbox_math_decodeproc.Name = "output_textbox_math_decodeproc";
			this.output_textbox_math_decodeproc.Size = new System.Drawing.Size(367, 163);
			this.output_textbox_math_decodeproc.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(236, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 12);
			this.label5.TabIndex = 17;
			this.label5.Text = "编码过程：";
			// 
			// output_textbox_math_encodeproc
			// 
			this.output_textbox_math_encodeproc.Location = new System.Drawing.Point(236, 35);
			this.output_textbox_math_encodeproc.Multiline = true;
			this.output_textbox_math_encodeproc.Name = "output_textbox_math_encodeproc";
			this.output_textbox_math_encodeproc.Size = new System.Drawing.Size(367, 171);
			this.output_textbox_math_encodeproc.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 308);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 15;
			this.label4.Text = "解码数：";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 323);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(138, 21);
			this.textBox2.TabIndex = 14;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(155, 242);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 13;
			this.button4.Text = "生成符号表";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// output_textbox_math_decoded
			// 
			this.output_textbox_math_decoded.Location = new System.Drawing.Point(6, 362);
			this.output_textbox_math_decoded.Name = "output_textbox_math_decoded";
			this.output_textbox_math_decoded.Size = new System.Drawing.Size(138, 21);
			this.output_textbox_math_decoded.TabIndex = 12;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(155, 360);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "刷新";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 347);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "解码结果：";
			// 
			// output_textbox_math_encoded
			// 
			this.output_textbox_math_encoded.Location = new System.Drawing.Point(6, 273);
			this.output_textbox_math_encoded.Name = "output_textbox_math_encoded";
			this.output_textbox_math_encoded.Size = new System.Drawing.Size(138, 21);
			this.output_textbox_math_encoded.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 253);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "编码结果：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "符号表：";
			// 
			// output_textbox_math_symbols
			// 
			this.output_textbox_math_symbols.Location = new System.Drawing.Point(6, 91);
			this.output_textbox_math_symbols.Multiline = true;
			this.output_textbox_math_symbols.Name = "output_textbox_math_symbols";
			this.output_textbox_math_symbols.Size = new System.Drawing.Size(224, 145);
			this.output_textbox_math_symbols.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(155, 271);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "刷新";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// input_textbox_math_pattern
			// 
			this.input_textbox_math_pattern.Location = new System.Drawing.Point(6, 20);
			this.input_textbox_math_pattern.Multiline = true;
			this.input_textbox_math_pattern.Name = "input_textbox_math_pattern";
			this.input_textbox_math_pattern.Size = new System.Drawing.Size(224, 50);
			this.input_textbox_math_pattern.TabIndex = 5;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.output_textbox_lzw_decodeproc);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.button5);
			this.groupBox3.Controls.Add(this.output_textbox_lzw_encodeproc);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Location = new System.Drawing.Point(12, 417);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(907, 204);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "LZW编码";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(16, 32);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(175, 166);
			this.textBox3.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 22;
			this.label8.Text = "串：";
			// 
			// output_textbox_lzw_encodeproc
			// 
			this.output_textbox_lzw_encodeproc.Location = new System.Drawing.Point(278, 32);
			this.output_textbox_lzw_encodeproc.Multiline = true;
			this.output_textbox_lzw_encodeproc.Name = "output_textbox_lzw_encodeproc";
			this.output_textbox_lzw_encodeproc.Size = new System.Drawing.Size(301, 166);
			this.output_textbox_lzw_encodeproc.TabIndex = 23;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(197, 104);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 5;
			this.button5.Text = "计算";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(276, 17);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 12);
			this.label9.TabIndex = 24;
			this.label9.Text = "编码过程：";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(597, 17);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 12);
			this.label10.TabIndex = 26;
			this.label10.Text = "解码过程：";
			// 
			// output_textbox_lzw_decodeproc
			// 
			this.output_textbox_lzw_decodeproc.Location = new System.Drawing.Point(599, 32);
			this.output_textbox_lzw_decodeproc.Multiline = true;
			this.output_textbox_lzw_decodeproc.Name = "output_textbox_lzw_decodeproc";
			this.output_textbox_lzw_decodeproc.Size = new System.Drawing.Size(301, 166);
			this.output_textbox_lzw_decodeproc.TabIndex = 25;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 626);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "熵编码";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox input_textbox_huffman_pattern;
    private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TreeView res_treeview_huffman_tree;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox input_textbox_math_pattern;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox output_textbox_math_decoded;
		public System.Windows.Forms.TextBox output_textbox_math_encoded;
		public System.Windows.Forms.TextBox output_textbox_math_symbols;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox output_textbox_math_encodeproc;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox output_textbox_math_decodeproc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox output_textbox_lzw_decodeproc;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox output_textbox_lzw_encodeproc;
	}
}

