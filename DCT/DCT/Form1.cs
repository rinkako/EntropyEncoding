using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCT
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// 构造器
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			this.DCTContainer = new List<DCTTransformer>();
			this.LuminousContainer = new List<LuminanceQuantisationer>();
			for (int i = 0; i < 4; i++)
			{
				this.DCTContainer.Add(new DCTTransformer());
			}
        }

		/// <summary>
		/// 按钮：前向计算
		/// </summary>
		private void button_CalcForward_Click(object sender, EventArgs e)
		{
			// 变更状态
			this.label_state.Text = "当前显示：正向计算";
			this.label_state.ForeColor = Color.Red;
			// 装入数据
			this.NumberPreprocessor(this.input_textBox1.Text, this.DCTContainer[0]);
			this.NumberPreprocessor(this.input_textBox2.Text, this.DCTContainer[1]);
			this.NumberPreprocessor(this.input_textBox3.Text, this.DCTContainer[2]);
			this.NumberPreprocessor(this.input_textBox4.Text, this.DCTContainer[3]);
			// 集体减128并做DCT变换
			foreach (var dctor in this.DCTContainer)
			{
				dctor.Preprocess();
				dctor.DCT();
			}
			// 输出DCT结果
			this.DCT_output_textBox1.Text = this.DCTContainer[0].GetDCTString();
			this.DCT_output_textBox2.Text = this.DCTContainer[1].GetDCTString();
			this.DCT_output_textBox3.Text = this.DCTContainer[2].GetDCTString();
			this.DCT_output_textBox4.Text = this.DCTContainer[3].GetDCTString();
			// 初始化量化器
			this.LuminousContainer.Clear();
			foreach (var dctor in this.DCTContainer)
			{
				this.LuminousContainer.Add(new LuminanceQuantisationer(dctor.GetDCTMat()));
			}
			// 进行量化
			foreach (var lumi in this.LuminousContainer)
			{
				lumi.Luminous();
			}
			// 输出亮度量化结果
			this.quan_output_textBox1.Text = this.LuminousContainer[0].GetLuminousString();
			this.quan_output_textBox2.Text = this.LuminousContainer[1].GetLuminousString();
			this.quan_output_textBox3.Text = this.LuminousContainer[2].GetLuminousString();
			this.quan_output_textBox4.Text = this.LuminousContainer[3].GetLuminousString();
		}

		/// <summary>
		/// 按钮：反向计算
		/// </summary>
		private void button_CalcBack_Click(object sender, EventArgs e)
		{
			// 变更状态
			this.label_state.Text = "当前显示：反向计算";
			this.label_state.ForeColor = Color.Blue;
			// 反量化
			foreach (var lumi in this.LuminousContainer)
			{
				lumi.Reluminous();
			}
			// 输出反量化结果
			this.requan_output_textBox1.Text = this.LuminousContainer[0].GetReLuminousString();
			this.requan_output_textBox2.Text = this.LuminousContainer[1].GetReLuminousString();
			this.requan_output_textBox3.Text = this.LuminousContainer[2].GetReLuminousString();
			this.requan_output_textBox4.Text = this.LuminousContainer[3].GetReLuminousString();
			// 设置反向计算DCT
			for (int i = 0; i < this.LuminousContainer.Count; i++)
			{
				this.DCTContainer[i].SetReMat(this.LuminousContainer[i].GetRelumiousMat());
				this.DCTContainer[i].ReDCT();
				this.DCTContainer[i].Postprocess();
			}
			// 输出逆向结果
			this.ReDCTResList = new List<string>();
			foreach (var dctor in this.DCTContainer)
			{
				this.ReDCTResList.Add(dctor.GetReDCTString());
			}
			ReDCTForm resForm = new ReDCTForm(this.ReDCTResList);
			resForm.ShowDialog();
        }

		/// <summary>
		/// 将数字转化并装入DCT变换器
		/// </summary>
		/// <param name="parttern">要处理的串</param>
		/// <param name="dct">要装入的DCT变换器</param>
		private void NumberPreprocessor(string parttern, DCTTransformer dct)
		{
			var line = parttern.Replace("\r", "").Split('\n');
			for (int i = 0; i < line.Length; i++)
			{
				var lineitem = line[i].Split();
				for (int j = 0; j < lineitem.Length; j++)
				{
					if (this.radioButton1.Checked)
					{
						dct.SetMat(j, i, Convert.ToInt32(lineitem[j], 16));
					}
					else
					{
						dct.SetMat(j, i, Convert.ToInt32(lineitem[j], 10));
					}
				}
			}
		}

		/// <summary>
		/// DCT处理器容器
		/// </summary>
		List<DCTTransformer> DCTContainer;

		/// <summary>
		/// 量化处理器容器
		/// </summary>
		List<LuminanceQuantisationer> LuminousContainer;

		/// <summary>
		/// 反向计算结果容器
		/// </summary>
		List<string> ReDCTResList;
	}
}
