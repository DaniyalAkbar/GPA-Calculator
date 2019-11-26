namespace Easy_GPA
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.delete = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.object_e446b7fb_2f55_4f7d_8b96_c3f169178e9e = new Telerik.WinControls.RootRadElement();
            this.view = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.cgpa = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radCheckedDropDownList1 = new Telerik.WinControls.UI.RadCheckedDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgpa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedDropDownList1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.MintCream;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(21, 56);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(433, 369);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellValueChanged);
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Location = new System.Drawing.Point(654, 78);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(190, 20);
            this.radDropDownList1.TabIndex = 1;
            this.radDropDownList1.SelectedValueChanged += new System.EventHandler(this.radDropDownList1_SelectedValueChanged);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.delete.Location = new System.Drawing.Point(750, 153);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(149, 37);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete All Records";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.delete.GetChildAt(0))).Text = "Delete All Records";
            ((Telerik.WinControls.UI.RadButtonElement)(this.delete.GetChildAt(0))).BackColor = System.Drawing.Color.DarkCyan;
            ((Telerik.WinControls.UI.RadButtonElement)(this.delete.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.delete.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.DarkCyan;
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.Radius = 8;
            // 
            // object_e446b7fb_2f55_4f7d_8b96_c3f169178e9e
            // 
            this.object_e446b7fb_2f55_4f7d_8b96_c3f169178e9e.Name = "object_e446b7fb_2f55_4f7d_8b96_c3f169178e9e";
            this.object_e446b7fb_2f55_4f7d_8b96_c3f169178e9e.StretchHorizontally = true;
            this.object_e446b7fb_2f55_4f7d_8b96_c3f169178e9e.StretchVertically = true;
            // 
            // view
            // 
            this.view.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.view.Location = new System.Drawing.Point(563, 153);
            this.view.Name = "view";
            // 
            // 
            // 
            this.view.RootElement.Shape = null;
            this.view.Size = new System.Drawing.Size(149, 37);
            this.view.TabIndex = 3;
            this.view.Text = "View Records";
            this.view.Click += new System.EventHandler(this.view_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.view.GetChildAt(0))).Text = "View Records";
            ((Telerik.WinControls.UI.RadButtonElement)(this.view.GetChildAt(0))).BackColor = System.Drawing.Color.DarkCyan;
            ((Telerik.WinControls.UI.RadButtonElement)(this.view.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.view.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.DarkCyan;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(518, 78);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(117, 20);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "User Name List";
            // 
            // cgpa
            // 
            this.cgpa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cgpa.Location = new System.Drawing.Point(696, 388);
            this.cgpa.Name = "cgpa";
            this.cgpa.Size = new System.Drawing.Size(203, 37);
            this.cgpa.TabIndex = 3;
            this.cgpa.Text = "Calculate CGPA";
            this.cgpa.Click += new System.EventHandler(this.cgpa_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.cgpa.GetChildAt(0))).Text = "Calculate CGPA";
            ((Telerik.WinControls.UI.RadButtonElement)(this.cgpa.GetChildAt(0))).BackColor = System.Drawing.Color.DarkCyan;
            ((Telerik.WinControls.UI.RadButtonElement)(this.cgpa.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.cgpa.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.cgpa.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.DarkGreen;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.cgpa.GetChildAt(0).GetChildAt(0))).AngleTransform = 0F;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Easy_GPA.Properties.Resources._6;
            this.pictureBox1.Location = new System.Drawing.Point(460, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 463);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.radLabel2.Location = new System.Drawing.Point(21, 431);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(228, 19);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "* Double click on a record to update ";
            // 
            // radCheckedDropDownList1
            // 
            this.radCheckedDropDownList1.Location = new System.Drawing.Point(850, 78);
            this.radCheckedDropDownList1.Name = "radCheckedDropDownList1";
            this.radCheckedDropDownList1.Size = new System.Drawing.Size(71, 20);
            this.radCheckedDropDownList1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(962, 486);
            this.Controls.Add(this.radCheckedDropDownList1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.cgpa);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "Users\' Data-records";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgpa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedDropDownList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadButton delete;
        private Telerik.WinControls.RootRadElement object_e446b7fb_2f55_4f7d_8b96_c3f169178e9e;
        private Telerik.WinControls.UI.RadButton view;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton cgpa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckedDropDownList radCheckedDropDownList1;
    }
}