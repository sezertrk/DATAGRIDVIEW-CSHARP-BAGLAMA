using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kisiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
            bag.Open();
            OleDbDataAdapter kur = new OleDbDataAdapter("select * from kisi", bag);
            DataSet hamal = new DataSet();
            kur.Fill(hamal);
            dataGridView1.DataSource = hamal.Tables[0];

            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
            bag.Open();
            OleDbDataAdapter kur = new OleDbDataAdapter("select * from kisi where ad='" +textBox1.Text+ "'",bag); 
            DataSet hamal = new DataSet();
            kur.Fill(hamal);
            dataGridView1.DataSource = hamal.Tables[0];
        }
    }
}
