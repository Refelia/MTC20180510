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


namespace Members
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string delimiter = ",";
            string tablename = "memList";
            DataSet dataset = new DataSet();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(filename);
                string csv = File.ReadAllText(openFileDialog1.FileName);

                dataset.Tables.Add(tablename);
                dataset.Tables[tablename].Columns.Add("FirstName");
                dataset.Tables[tablename].Columns.Add("LastName");
                dataset.Tables[tablename].Columns.Add("BirthDate");
                dataset.Tables[tablename].Columns.Add("City");
                dataset.Tables[tablename].Columns.Add("State");
                dataset.Tables[tablename].Columns.Add("DateJoin");


                string allData = sr.ReadToEnd();
                string[] rows = allData.Split("\r".ToCharArray());


                foreach (string r in rows)
                {
                    string[] items = r.Split(delimiter.ToCharArray());
                    dataset.Tables[tablename].Rows.Add(items);
                }

                //Display the result to the datagrid.
                foreach (string value in rows)
                {
                    memSortDatagrid.DataSource = dataset.Tables[0];
                }
            }
        }

        private void reformatDateBtn_Click(object sender, EventArgs e)
        {
            //memSortDatagrid.Rows.Clear();
           
           
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string pathFinder = "members.csv";
            StreamWriter stwtr = new StreamWriter(pathFinder);

            foreach (string listOfMembers in memSortDatagrid.DataBindings)
            {
                //write a text file.
               stwtr.WriteLine(listOfMembers.ToString());

                //Display message
                MessageBox.Show("Exported!");
            }
        }
    }
}



