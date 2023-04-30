
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
 

        private void Loadcombobox()
        {

            comboBox.Items.Add("Uzza Biswas");
            comboBox.Items.Add("Kumar Biswas");
            comboBox.Items.Add("Bijoy Biswas");
            comboBox.Items.Add("Ripon Biswas");

             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showname.Text= comboBox.Text.ToString();
        }
        bool valu = false;
        private void begun_CheckedChanged(object sender, EventArgs e)

        {
            valu =! valu;

            if (valu == true)
            {
                Alu.Checked = true;
                potol.Checked = true;
                moric.Checked = true;
            }
            else {
                Alu.Checked = false;
                potol.Checked = false;
                moric.Checked = false;
            }
        }

        private void addEmplopyeebtn_Click(object sender, EventArgs e)
        {
            String name=nametextBox.Text;
            String phone=phonetextBox.Text;

            ListViewItem item=new ListViewItem(name);
            item.SubItems.Add(phone);
            AddlistView.Items.Add(item);



        }

        private void employeeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
