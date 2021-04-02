using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Польская
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ReversePolishNotation rpn = new ReversePolishNotation();

        private void RESH_Click(object sender, EventArgs e)
        {
            if (OUT.Text == "")
                OUT.Text = "Выражение не преобразовано!";
            else
            {
                try
                {
                    OUT.Text = rpn.Calculate();
                }
                catch (Exception)
                {
                    OUT.Text = "Ошибка";
                }
            }
        }

        private void OUT_TextChanged(object sender, EventArgs e)
        {

        }

        private void R_Click(object sender, EventArgs e)
        {
            try
            {
                OUT.Text = rpn.GetExpression(IN.Text);
            }
            catch (Exception)
            {
                OUT.Text = "В записи есть ошибка";
            }
        }

        private void IN_TextChanged(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            OUT.Clear();
            IN.Clear();
        }
    }
}
