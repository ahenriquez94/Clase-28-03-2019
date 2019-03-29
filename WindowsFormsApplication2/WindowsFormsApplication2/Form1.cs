using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {

                radioButton1.Checked = true;
                radioButton4.Checked = true;

                label1.Text = "Selecciono el Check1";

            }

            if (this.checkBox2.Checked == true)
            {
                radioButton2.Checked = true;
                radioButton4.Checked = true;
                label1.Text = "Selecciono el Check2";
            }

            if (this.checkBox3.Checked == true)
            {
                radioButton1.Checked = true;
                radioButton4.Checked = true;
                label1.Text = "Selecciono el Check3";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "un solo click";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "dos click";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.BackColor = Color.Red;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                label1.BackColor = Color.Blue;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                label1.BackColor = Color.Green;


                this.BackColor = Color.Brown;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10;i++ )
            {
                comboBox1.Items.Add( i.ToString());
            }
        }
    }
}
