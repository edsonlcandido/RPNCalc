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
        }

        private void FormMainCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button btn;
            Debug.WriteLine(e.KeyChar);
            Char c = e.KeyChar;
            if (Char.IsDigit(c))
            {
                btn = (Button)this.Controls.Find("buttonNum"+c,true)[0];                
                btn.PerformClick();
            }else if (e.KeyChar == (char)Keys.Enter | c.ToString() == "/" | c.ToString() == "*" | c.ToString() == "-" | c.ToString() == "+")
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btn = (Button)this.Controls.Find("buttonEnter", true)[0];
                    btn.PerformClick();
                }
                else
                {
                    switch (c.ToString())
                    {
                        case "/":
                            btn = (Button)this.Controls.Find("buttonDivide", true)[0];
                            btn.PerformClick();
                            break;
                        case "*":
                            btn = (Button)this.Controls.Find("buttonMultiply", true)[0];
                            btn.PerformClick();
                            break;
                        case "-":
                            btn = (Button)this.Controls.Find("buttonSubtract", true)[0];
                            btn.PerformClick();
                            break;
                        case "+":
                            btn = (Button)this.Controls.Find("buttonAdd", true)[0];
                            btn.PerformClick();
                            break;
                        default:
                            break;
                    }
                }             
                
            }
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string operatorSymbol = btn.Text;
            switch (operatorSymbol)
            {
                case "/":
                    Debug.Print("divide");
                    break;
                case "*":
                    Debug.Print("multiply");
                    break;
                case "-":
                    Debug.Print("subtract");
                    break;
                case "+":
                    Debug.Print("sum");
                    break;
                default:
                    break;
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("ENTER");
        }
    }
}
