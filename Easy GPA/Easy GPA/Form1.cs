using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data.SQLite;
using System.Data;
using Telerik.WinControls.UI;
using System.Text.RegularExpressions;

namespace Easy_GPA
{
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form1()
        {
            InitializeComponent();
            enter.Enabled = false;
            calc.Enabled = false;
            for (int i = 1; i <= 9; i++) { comboBox1.Items.Add(i.ToString()); }
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        Telerik.WinControls.UI.RadLabel l = new Telerik.WinControls.UI.RadLabel();
        ToolTip t1 = new ToolTip();
        SQLiteConnection con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;New=False;Compress=True;");
        SQLiteCommand cmd;
        string tb;



        private void enter_Click(object sender, EventArgs e)
        {
            try
            {
                Telerik.WinControls.UI.RadLabel l3 = new Telerik.WinControls.UI.RadLabel();
                l3.Name = "l3";
                l3.Text = "?";
                l3.ForeColor = System.Drawing.Color.Red;
                l3.AutoSize = true;
                l3.AutoSize = true;
                t1.SetToolTip(l3, "This is where you enter the fixed total credit hour of a perticular course");
                l3.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                l3.Location = new System.Drawing.Point(130, 110);
                this.Controls.Add(l3);
                Telerik.WinControls.UI.RadLabel l4 = new Telerik.WinControls.UI.RadLabel();
                l4.Name = "l3";
                l4.Text = "?";
                l4.ForeColor = System.Drawing.Color.Red;
                l4.AutoSize = true;
                t1.SetToolTip(l4, "Enter the the GPA you have earned in a perticualr course");
                l4.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                l4.Location = new System.Drawing.Point(330, 110);
                this.Controls.Add(l4);

                int courses = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                int y = 145;
                for (int j = 1; j <= courses; j++)
                {

                    l.Name = "txt1";
                    l.Text = "Credit Hour";
                    l.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                    l.AutoSize = true;
                    l.Location = new System.Drawing.Point(150, 110);
                    this.Controls.Add(l);
                    Telerik.WinControls.UI.RadLabel l2 = new Telerik.WinControls.UI.RadLabel();
                    l2.Name = "txt2";
                    l2.Text = "Your GPA";
                    l2.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                    l2.AutoSize = true;
                    l2.Location = new System.Drawing.Point(350, 110);
                    this.Controls.Add(l2);

                    Telerik.WinControls.UI.RadDropDownList cb = new Telerik.WinControls.UI.RadDropDownList();
                    cb.Name = "course" + j;
                    cb.Text = "1";
                    cb.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                    cb.Location = new System.Drawing.Point(145, y);
                    cb.Size = new System.Drawing.Size(100, 20);
                    this.Controls.Add(cb);
                    for (int i = 1; i <= 5; i++) { cb.Items.Add(i.ToString()); }
                    Telerik.WinControls.UI.RadTextBox t = new Telerik.WinControls.UI.RadTextBox();
                    t.Name = "score" + j;
                    t.Text = "4";
                    t.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                    t.Location = new System.Drawing.Point(340, y);
                    t.Size = new System.Drawing.Size(100, 20);
                    this.Controls.Add(t);

                    y += 50;
                }
                comboBox1.Enabled = false;
                enter.Enabled = false;
                calc.Enabled = true;
            }
            catch { MessageBox.Show("Can Not Have Zero Courses"); }
        }








        private void calc_Click_1(object sender, EventArgs e)
        {
            try
            {
                float totalgpa = 0, numerator = 0, u = 0, p = 0;
                for (int i = 1; i <= 10; i++)
                {
                    foreach (Control childc in Controls)
                    {
                        if (childc is RadDropDownList && childc.Name.Equals(Convert.ToString("course" + i)))
                        {
                            u = float.Parse(childc.Text.ToString());
                            totalgpa = totalgpa + float.Parse(childc.Text.ToString());
                        }
                        else if (childc is RadTextBox && childc.Name.Equals(Convert.ToString("score" + i)))
                        {
                            p = float.Parse(childc.Text.ToString());
                        }
                    }
                    numerator = numerator + (u * p);
                    u = p = 0;
                }



                float total = (numerator / totalgpa);
                if (MessageBox.Show("Your GPA is: " + total.ToString() + "! \n\nDo you want to save your current record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    tb = Microsoft.VisualBasic.Interaction.InputBox("Name the person whose record this is? ", "Whose Account is This...", "I'M BATMAN");
                    if (tb.Length < 1) { MessageBox.Show("NO RECORD HAS BEEN SAVED!"); }
                    else if (tb.Equals("I'M BATMAN")) { MessageBox.Show("NO RECORD HAS BEEN SAVED!"); }
                    else
                    {
                        string sem = Microsoft.VisualBasic.Interaction.InputBox("Which Semester record is this? ", "Semester#", "");
                        sem = Regex.Replace(sem, "[^0-9.]", "");
                        if (sem.Length < 1) { MessageBox.Show("No record has been saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else if (Convert.ToInt32(sem) < 1 || Convert.ToInt32(sem) > 11) { MessageBox.Show("The range lies between 1-11. Pls enter a sensible value"); }
                        else
                        {
                            u = 0; p = 0;
                            int x = 0;
                            var t = DialogResult.None;
                            con.Open();
                            try
                            {
                                string sql = "CREATE TABLE '" + tb + "'(ROWID INTEGER PRIMARY KEY, sem int, credit float, gpa float); ";
                                cmd = con.CreateCommand();
                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }
                            catch { t = MessageBox.Show("The User '"+tb+"' already exists. Press OK to add more to this account, or go back and try a differnt user name", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); }
                            if (t == DialogResult.Cancel) { con.Close(); }
                            else if (t == DialogResult.OK || x == 0)
                            {
                                {
                                    for (int i = 1; i <= 10; i++)
                                    {
                                        foreach (Control childc in Controls)
                                        {
                                            if (childc is RadDropDownList && childc.Name.Equals(Convert.ToString("course" + i)))
                                            {
                                                u = int.Parse(childc.Text.ToString());
                                            }
                                            else if (childc is RadTextBox && childc.Name.Equals(Convert.ToString("score" + i)))
                                            {
                                                p = float.Parse(childc.Text.ToString());
                                            }
                                        }
                                        string q1 = "INSERT INTO '" + tb + "'(sem,credit,gpa) VALUES('" + sem + "', '" + u + "', '" + p + "' ); ";
                                        cmd = con.CreateCommand();
                                        cmd.CommandText = q1;

                                        if (u == 0 && p == 0) { break; }
                                        else cmd.ExecuteNonQuery();
                                        u = p = 0;

                                    }
                                    if (t == DialogResult.OK || x == 0) MessageBox.Show("Your GPA record is now saved!");
                                }
                                con.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception d) { MessageBox.Show(d.ToString()); }
        }
        





        private void delete_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }



        private void reset_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!comboBox1.SelectedItem.Equals("")) { enter.Enabled = true; }
        }

        
    }
}
