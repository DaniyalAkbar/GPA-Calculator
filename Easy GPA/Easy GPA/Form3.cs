using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_GPA
{
    public partial class Form3 : Form
    {
        Form2 f2 = new Form2();
        public Form3()
        {
            InitializeComponent();
            string sql = "SELECT name FROM sqlite_master WHERE type='table' AND name != 'sqlite_sequence' ";
            radDropDownList1.DataSource = f2.source(sql);
            radDropDownList1.ValueMember = "name";
            radDropDownList1.DisplayMember = "name";
            radDropDownList1.Text = null;
            this.radDropDownList1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.radDropDownList1.Text = "Click to Select from List";
        }

        

        private void ok_Click(object sender, EventArgs e)
        {
            if (radDropDownList1.SelectedValue == null && radDropDownList1.Text.Length < 1)
            {
                MessageBox.Show("Please select a value from the list or just type");
            }
            else 
            {
                string tb = radDropDownList1.Text.ToString();
                Form2 f22 = new Form2(tb);
                this.Close();
                f22.ShowDialog();
            }
                        


        }

        
    }
}
