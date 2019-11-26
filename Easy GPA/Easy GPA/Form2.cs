using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;
using System.Text.RegularExpressions;

namespace Easy_GPA
{
    public partial class Form2 : Form
    {
        string tb;
        int flag = 0;
        public Form2()  {}
        public Form2(string tb)
        {
            InitializeComponent();
            this.tb = tb;
            
            try
            {
                string sql = "SELECT name FROM sqlite_master WHERE type='table' AND name != 'sqlite_sequence' ";
                string q1 = "SELECT ROWID AS 'S.no', sem AS Semester, credit AS 'Credit Hour/Course', gpa AS 'GPA per Course' FROM '" + tb + "'; ";
                radDropDownList1.DataSource = source(sql);
                radDropDownList1.ValueMember = "name";
                radDropDownList1.DisplayMember = "name";
                radDropDownList1.SelectedValue = tb;
                this.radDropDownList1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                radGridView1.DataSource = source(q1);
                radGridView1.Columns["S.no"].ReadOnly = true;
                this.radGridView1.Columns[0].BestFit();

                string q2 = "SELECT DISTINCT sem FROM '" + tb + "' ";
                radCheckedDropDownList1.DataSource = source(q2);
                radCheckedDropDownList1.ValueMember = "sem";
                radCheckedDropDownList1.DisplayMember = "sem";
                radCheckedDropDownList1.Text = "All";
                flag = 2;

            }
            catch { radDropDownList1.SelectedValue = null; MessageBox.Show("No such user exists. Please select a User Name from the DropDown List."); flag = 2; }
        }

        




        // ********************************DELETE***************************************


        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (radDropDownList1.SelectedItem == null) { MessageBox.Show("Select a name from the list to Delete first"); }
                else if (radCheckedDropDownList1.Text == "" || radCheckedDropDownList1.Text == "All")
                {
                    if (MessageBox.Show("Entire record along with the user is about to be Deleted. Press OK to continue...", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
                    {
                        flag = 0;
                        string account = radDropDownList1.SelectedItem.ToString();
                        string q2 = "DROP TABLE '" + account + "'; ";
                        string q3 = "SELECT name FROM sqlite_master WHERE type='table' AND name != 'sqlite_sequence' ";
                        insert(q2);
                        radGridView1.DataSource = null;
                        radDropDownList1.DataSource = source(q3);
                        radDropDownList1.ValueMember = "name";
                        radDropDownList1.DisplayMember = "name";
                        radDropDownList1.Text = null;
                        radCheckedDropDownList1.DataSource = null;
                        MessageBox.Show("All Record Cleared!");
                        flag = 2;
                    }
                }
                else
                {
                    try
                    {
                        string account = radDropDownList1.Text.ToString();
                        string strip = Regex.Replace(radCheckedDropDownList1.Text, "[^0-9.]", ",");
                        String q5 = "DELETE FROM '" + account + "' WHERE sem IN (" + strip + "0); ";
                        string q6 = "SELECT DISTINCT sem FROM '" + account + "' ";
                        if (MessageBox.Show("All records of SELECTED semester are about to be Deleted. Press OK to continue...", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
                        {
                            insert(q5);
                            radGridView1.DataSource = null;
                            radCheckedDropDownList1.DataSource = source(q6);
                            MessageBox.Show("Selected Records Were Cleared!");
                        }
                    }
                    catch (Exception d) { MessageBox.Show(d.ToString()); }
                }
            }
            catch { }
        }






        // ********************************VIEW***************************************
            

        private void view_Click(object sender, EventArgs e)
        {
            try
            {
                string getname = radDropDownList1.Text.ToString();
                if (radDropDownList1.SelectedItem == null) { MessageBox.Show("Select a name from the list to View first"); }
                else
                {
                    if (radCheckedDropDownList1.Text == "" || radCheckedDropDownList1.Text == "All")
                    {
                        string q4 = "SELECT ROWID AS 'S.no', sem AS Semester, credit AS 'Credit Hour/Course', gpa AS 'GPA per Course' FROM '" + getname + "'; ";
                        radGridView1.DataSource = source(q4);
                        radGridView1.Columns["S.no"].ReadOnly = true;
                        this.radGridView1.Columns[0].BestFit();
                    }
                    else
                    {
                        try
                        {
                            string strip = Regex.Replace(radCheckedDropDownList1.Text, "[^0-9.]", ",");
                            String q5 = "SELECT ROWID AS 'S.no', sem AS Semester,  credit AS 'Credit Hour/Course', gpa AS 'GPA Per Course' FROM '" + getname + "' WHERE sem IN (" + strip + "0); ";
                            radGridView1.DataSource = source(q5);
                            radGridView1.Columns["S.no"].ReadOnly = true;
                            this.radGridView1.Columns[0].BestFit();
                        }catch { MessageBox.Show("No such record found!"); }
                    } 
                }
            }
            catch {  }
        }
       
         



        // ********************************CGPA***************************************


        private void cgpa_Click(object sender, EventArgs e)
        {
            try
            {
                string account = radDropDownList1.SelectedItem.ToString();
                if (radDropDownList1.SelectedItem == null) { MessageBox.Show("Select a Name from the DropDown List first"); }
                else if (radCheckedDropDownList1.Text == "" || radCheckedDropDownList1.Text == "All")
                {
                    string q2 = "SELECT round(SUM(credit * gpa)/SUM(credit),2) as 'Total' FROM '" + account + "'; ";
                    DataTable dt = source(q2);
                    MessageBox.Show(account + " your CGPA for all semesters is: " + dt.Rows[0][0].ToString());
                }
                else
                {
                    string strip = Regex.Replace(radCheckedDropDownList1.Text, "[^0-9.]", ",");
                    string q3 = "SELECT round(SUM(credit * gpa)/SUM(credit),2) as 'Total' FROM '" + account + "' where sem IN ("+strip+"0) ";
                    DataTable dt = source(q3);
                    MessageBox.Show(account + " your CGPA for the selected semesters is: " + dt.Rows[0][0].ToString());
                }

            }
            catch { }
        }





        // ********************************UPDATE_THROUGH_GRID***************************************


        private void radGridView1_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                string getsno = radGridView1.Rows[e.RowIndex].Cells["S.no"].Value.ToString();
                string getsem = radGridView1.Rows[e.RowIndex].Cells["Semester"].Value.ToString();
                string getcredit = radGridView1.Rows[e.RowIndex].Cells["Credit Hour/Course"].Value.ToString();
                string getgpa = radGridView1.Rows[e.RowIndex].Cells["GPA per Course"].Value.ToString();
                string account = radDropDownList1.Text.ToString();
                string q1 = "UPDATE '" + account + "' SET sem = '" + getsem + "', credit = '" + getcredit + "', gpa = '" + getgpa + "' WHERE ROWID = '" + getsno + "'   ";

                if (getsem.Any(char.IsLetter) || getsem == "") {
                    MessageBox.Show("Invalid Input!"); }
                else if (Convert.ToInt32(getsem) < 1 || Convert.ToInt32(getsem) > 11) {
                    MessageBox.Show("The range lies between 1 - 11.Pls enter a sensible value"); }
                else if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    insert(q1);
                }

                string q2 = "SELECT ROWID AS 'S.no', sem AS Semester, credit AS 'Credit Hour/Course', gpa AS 'GPA Per Course' FROM '" + account + "'; ";
                radGridView1.DataSource = source(q2);
                radCheckedDropDownList1.DataSource = source("SELECT DISTINCT sem FROM '" + account + "' " );
                radCheckedDropDownList1.Text = "All";
            }   
            catch { MessageBox.Show("Select a Name from the DropDown List first"); }
        }







        // ********************************DROPDOWN_LIST_1***************************************

        private void radDropDownList1_SelectedValueChanged(object sender, EventArgs e)
        {
            radGridView1.DataSource = null;
            radCheckedDropDownList1.DataSource = null;
            try
            {
                if (flag == 2)
                {
                    string account = radDropDownList1.Text.ToString();
                    string q1 = "SELECT DISTINCT sem FROM '" + account + "' ";
                    radCheckedDropDownList1.DataSource = source(q1);
                    radCheckedDropDownList1.ValueMember = "sem";
                    radCheckedDropDownList1.DisplayMember = "sem";
                    radCheckedDropDownList1.Text = "All";
                }
            }
            catch { }
        }


 
 






        public void insert(string q)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;New=False;Compress=True;");
            con.Open();
            SQLiteCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable source(string q)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;New=False;Compress=True;");
            con.Open();
            SQLiteCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = q;
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            adapt.SelectCommand = cmd;
            adapt.Fill(dt);
            con.Close();
            return dt;
        }


    }
}

