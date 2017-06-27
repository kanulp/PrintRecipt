using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace PrintRecipt
{
    public partial class Form1 : Form
    {

        public static string name1 = "";
        public static string name2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Team_Member_Name_1_TextChanged(object sender, EventArgs e)
        {
            if (Team_Member_Name_1.Text.Length == 0)
            {
                errorProvider2.SetError(Team_Member_Name_1, "Error");
            }
            else
            {
                errorProvider2.SetError(Team_Member_Name_1, "");
            }
        }

        private void Team_Member_Name_2_TextChanged(object sender, EventArgs e)
        {
            if (Team_Member_Name_1.Text.Length == 0)
            {
                errorProvider3.SetError(Team_Member_Name_2, "Error");
            }
            else
            {
                errorProvider3.SetError(Team_Member_Name_2, "");
            }
        }
        private void mask_phone_1(object sender, EventArgs e)
        {
            if (Team_Member_Phone_1.Text == "000-0000-000" || Team_Member_Phone_1.Text.Length < 12)
            {
                errorProvider4.SetError(Team_Member_Phone_1, "Error");
            }
            else
            {
                errorProvider4.SetError(Team_Member_Phone_1, "");
            }
        }

        private void Team_Member_1_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Team_Member_1_Branch.SelectedItem.ToString() == "enter branch")
            {
                errorProvider5.SetError(Team_Member_1_Branch, "Error");
            }
            else
            {

                errorProvider5.SetError(Team_Member_1_Branch, "");
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            name1 = Team_Member_Name_1.Text;
            name2 = Team_Member_Name_2.Text;

            print p = new print();
            p.Show();

        }

        private void add_Click(object sender, EventArgs e)
        {
            try {

                //take all the ifo to save in file 
                name1 = Team_Member_Name_1.Text;
                name2 = Team_Member_Name_2.Text;
                

                using (StreamWriter txt = File.AppendText("G:\\app\\data.txt")) {
                    txt.WriteLine("Name1: " + name1 + " Name2: " + name2);
                    //write into as u want 
                    txt.WriteLine("");




                    txt.WriteLine("--------------------------------");
                    txt.Close();
                    MessageBox.Show("Saved in File");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //clear all the textbox
            Team_Member_Name_1.Text = "";
        }
    }
}