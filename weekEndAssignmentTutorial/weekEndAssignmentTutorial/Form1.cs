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

namespace weekEndAssignmentTutorial
{
    struct phoneBookEntry
    {
        public string name;
        public string phone;
    }
    public partial class Form1 : Form
    {
        //Field to hold the list of PhoneBookEntry objects.
        private List<phoneBookEntry> phoneList = new List<phoneBookEntry>();
        public Form1()
        {
            InitializeComponent();
        }

        //The readfile method reads the contents of the of the phoneList.txt file and stores it as phoneBookEntrty
        //objects in the phoneList
        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;   //To read the file
                string line;  //To hold the file

                //Create an instance of the PhoneBookEntry structure.
                phoneBookEntry entry = new phoneBookEntry();

                //Create a delimiter array.
                char[] delim = { ',' };

                //Open the phoneList file.
                inputFile = File.OpenText("phneNumber.txt");

                //Read the lines from the file.
                while (!inputFile.EndOfStream)
                {
                    //Read  a line from the file.
                    line = inputFile.ReadLine();

                    //Tokenize the line.
                    string[] tokens = line.Split(delim);

                    //Store the tokens in the entry objects.
                    entry.name = tokens[0];
                    entry.phone = tokens[1];

                    //Add the entry object to the list.
                    phoneList.Add(entry);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //The displayNames method display the list of names in the listBox1 control.
        private void DisplayNames()
        {
            foreach(phoneBookEntry entry in phoneList)
            {
                listBox1.Items.Add(entry.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Read the phoneList.txt file
            ReadFile();

            //Display the names.
            DisplayNames();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the indes in the selected item.
            int index = listBox1.SelectedIndex;

            //Display the corresponding phone number.
            label1.Text = phoneList[index].phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
