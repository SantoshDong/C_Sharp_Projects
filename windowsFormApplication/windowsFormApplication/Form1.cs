using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textName.Text) == true){
                ShowText.Text = "Please enter you name first";
            }else{
                ShowText.Text = "thank you!! " + textName.Text.ToUpper() + " for enter your Name";
            }
        }
    }
}
