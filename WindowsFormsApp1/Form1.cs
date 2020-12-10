using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Marka");
            dataTable.Columns.Add("Model");
            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Price");
            string filePath = textBox1.Text;
            StreamReader streamReader = new StreamReader(filePath);
            string[] totalData = new string[File.ReadAllLines(filePath).Length];
            totalData = streamReader.ReadLine().Split(',');
            while (!streamReader.EndOfStream)
            {
                totalData = streamReader.ReadLine().Split(',');
                dataTable.Rows.Add(totalData[0], totalData[1], totalData[2], totalData[3]);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
