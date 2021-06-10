using Anket_Home_Work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ev_Tap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var filename = File_name_txt_box.Text;
            Human hum = new Human(Name_txt_box.Text,Surname_txt_box.Text,Age_txt_box.Text,Adress_txt_box.Text,Father_name_txt_box.Text,Gmail_txt_box.Text);
            Helper.JsonSerialization(hum,filename);
        }
    }
}
