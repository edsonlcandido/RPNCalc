using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPNCalc
{
    public partial class FormMainCalc : Form
    {
        string allInput;
        string numInput;

        public FormMainCalc()
        {
            InitializeComponent();
            listBoxRowsValues.Items.AddRange(new string[10] {"","","","","","","","","","" });
            
        }


        private void numButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int digit = int.Parse(btn.Text);

            numInput += digit.ToString();
            listBoxRowsValues.Items[listBoxRowsValues.Items.Count - 1] = numInput;
            //Debug.WriteLine(digit.ToString());
        }

        private void FormMainCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            if (Char.IsDigit(c))
            {
                Button btn = (Button)this.Controls.Find("buttonNum"+c,true)[0];
                //Debug.WriteLine(btn.Text);
                btn.PerformClick();
                //numInput += c;
            }
            //listBoxRowsValues.Items[listBoxRowsValues.Items.Count-1] = numInput;
            //allInput += c;
            //Debug.WriteLine(allInput, "|" +  numInput);           
        }

        private void FormMainCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
