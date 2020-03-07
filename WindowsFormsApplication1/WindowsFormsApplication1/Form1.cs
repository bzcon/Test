using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			// 실행되는 프로그램 코드 입력.
			string str1 = "Hello !!!";
			MessageBox.Show(str1,"Hi");
			this.runInputDisplay.Text = str1;
		}

		private void button2_Click(object sender, EventArgs e) {

		}
	}
}
