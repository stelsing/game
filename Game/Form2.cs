using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                Program.data.EventHandler(1);
            if (this.radioButton2.Checked)
                Program.data.EventHandler(2);
            if (this.radioButton3.Checked)
                Program.data.EventHandler(3);
            if (this.radioButton4.Checked)
                Program.data.EventHandler(4);
            this.Close();
        }
    }
}
