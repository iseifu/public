using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enumtest_DT {
	public partial class Form1:Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender,EventArgs e) {
			
			var names = Enum.GetNames(typeof(MessageBoxDefaultButton));
			var values = (MessageBoxDefaultButton[])Enum.GetValues(typeof(MessageBoxDefaultButton));
			textBox1.AppendText($"public enum {nameof(MessageBoxDefaultButton)}{{{Environment.NewLine}");
			for(int i = 0;i < names.Length;i++) {
				textBox1.AppendText($"\t/// <summary>{Environment.NewLine}");
				textBox1.AppendText($"\t/// {Environment.NewLine}");
				textBox1.AppendText($"\t/// </summary>{Environment.NewLine}");
				textBox1.AppendText($"\t{names[i]} = {(int)values[i]}");
				if(i < names.Length - 1) {
					textBox1.AppendText($",{Environment.NewLine}{Environment.NewLine}");
				}
			}
			textBox1.AppendText($"{Environment.NewLine}}}{Environment.NewLine}");
		}
	}
}
