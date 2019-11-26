namespace Easy_GPA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.comboBox1 = new Telerik.WinControls.UI.RadDropDownList();
            this.reset = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.calc = new Telerik.WinControls.UI.RadButton();
            this.cross = new Telerik.WinControls.UI.RadButton();
            this.jump = new Telerik.WinControls.UI.RadButton();
            this.radOffice2007ScreenTipElement1 = new Telerik.WinControls.UI.RadOffice2007ScreenTipElement();
            this.enter = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(92, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Number of Courses";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBox1.Location = new System.Drawing.Point(352, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 25);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Transparent;
            this.reset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.reset.Location = new System.Drawing.Point(722, 46);
            this.reset.Name = "reset";
            // 
            // 
            // 
            this.reset.RootElement.FocusBorderColor = System.Drawing.SystemColors.ControlDark;
            this.reset.Size = new System.Drawing.Size(118, 31);
            this.reset.TabIndex = 13;
            this.reset.Text = "StartOver";
            this.reset.Click += new System.EventHandler(this.reset_Click_1);
            ((Telerik.WinControls.UI.RadButtonElement)(this.reset.GetChildAt(0))).Text = "StartOver";
            ((Telerik.WinControls.UI.RadButtonElement)(this.reset.GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.RadButtonElement)(this.reset.GetChildAt(0))).Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.UI.RadButtonElement)(this.reset.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.reset.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.reset.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.reset.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.reset.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.reset.GetChildAt(0).GetChildAt(2))).Width = 2F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.reset.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.reset.GetChildAt(0).GetChildAt(2))).Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.Radius = 8;
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.Color.Transparent;
            this.calc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calc.BackgroundImage")));
            this.calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calc.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.calc.Location = new System.Drawing.Point(575, 84);
            this.calc.Name = "calc";
            // 
            // 
            // 
            this.calc.RootElement.BorderHighlightColor = System.Drawing.Color.Transparent;
            this.calc.RootElement.HighlightColor = System.Drawing.Color.Transparent;
            this.calc.RootElement.RippleAnimationColor = System.Drawing.Color.Transparent;
            this.calc.Size = new System.Drawing.Size(265, 39);
            this.calc.TabIndex = 14;
            this.calc.Text = "Calculate";
            this.calc.Click += new System.EventHandler(this.calc_Click_1);
            ((Telerik.WinControls.UI.RadButtonElement)(this.calc.GetChildAt(0))).Text = "Calculate";
            ((Telerik.WinControls.UI.RadButtonElement)(this.calc.GetChildAt(0))).RippleAnimationColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadButtonElement)(this.calc.GetChildAt(0))).HighlightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadButtonElement)(this.calc.GetChildAt(0))).BorderHighlightColor = System.Drawing.Color.Crimson;
            ((Telerik.WinControls.UI.RadButtonElement)(this.calc.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.calc.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Crimson;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.calc.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.calc.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.calc.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Salmon;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.calc.GetChildAt(0).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.calc.GetChildAt(0).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.calc.GetChildAt(0).GetChildAt(0))).AngleTransform = 0F;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.calc.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.calc.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.calc.GetChildAt(0).GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.calc.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.calc.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).Width = 2F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).LeftWidth = 1F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).TopWidth = 1F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).RightWidth = 1F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).BottomWidth = 1F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).LeftShadowColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).TopShadowColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).RightShadowColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).BottomShadowColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).BorderDashPattern = new float[0];
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).InnerColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Crimson;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.calc.GetChildAt(0).GetChildAt(2))).AngleTransform = 0F;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.calc.GetChildAt(0).GetChildAt(3))).InnerColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.calc.GetChildAt(0).GetChildAt(3))).InnerColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.calc.GetChildAt(0).GetChildAt(3))).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.calc.GetChildAt(0).GetChildAt(3))).BackColor = System.Drawing.Color.Transparent;
            // 
            // cross
            // 
            this.cross.BackColor = System.Drawing.Color.Coral;
            this.cross.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cross.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cross.Location = new System.Drawing.Point(1031, 12);
            this.cross.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(28, 28);
            this.cross.TabIndex = 15;
            this.cross.Text = "X";
            this.cross.TextWrap = true;
            this.cross.Click += new System.EventHandler(this.button1_Click_1);
            ((Telerik.WinControls.UI.RadButtonElement)(this.cross.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            ((Telerik.WinControls.UI.RadButtonElement)(this.cross.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.cross.GetChildAt(0))).TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            ((Telerik.WinControls.UI.RadButtonElement)(this.cross.GetChildAt(0))).Text = "X";
            ((Telerik.WinControls.UI.RadButtonElement)(this.cross.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.Gray;
            ((Telerik.WinControls.UI.RadButtonElement)(this.cross.GetChildAt(0))).FocusBorderWidth = 3;
            ((Telerik.WinControls.UI.RadButtonElement)(this.cross.GetChildAt(0))).ToolTipText = "CLose Application";
            ((Telerik.WinControls.UI.RadButtonElement)(this.cross.GetChildAt(0))).Opacity = 1D;
            ((Telerik.WinControls.UI.RadButtonElement)(this.cross.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadButtonElement)(this.cross.GetChildAt(0))).ScaleTransform = new System.Drawing.SizeF(1.35F, 1F);
            // 
            // jump
            // 
            this.jump.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.jump.Location = new System.Drawing.Point(575, 129);
            this.jump.Name = "jump";
            // 
            // 
            // 
            this.jump.RootElement.ApplyShapeToControl = false;
            this.jump.RootElement.BorderHighlightColor = System.Drawing.Color.WhiteSmoke;
            this.jump.RootElement.BorderHighlightThickness = 1;
            this.jump.RootElement.Enabled = true;
            this.jump.RootElement.HighlightColor = System.Drawing.SystemColors.Control;
            this.jump.RootElement.UseSystemSkin = Telerik.WinControls.UseSystemSkinMode.YesLocal;
            this.jump.Size = new System.Drawing.Size(265, 39);
            this.jump.TabIndex = 17;
            this.jump.Text = "View Records";
            this.jump.Click += new System.EventHandler(this.delete_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.jump.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            ((Telerik.WinControls.UI.RadButtonElement)(this.jump.GetChildAt(0))).UseDefaultDisabledPaint = false;
            ((Telerik.WinControls.UI.RadButtonElement)(this.jump.GetChildAt(0))).TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            ((Telerik.WinControls.UI.RadButtonElement)(this.jump.GetChildAt(0))).Text = "View Records";
            ((Telerik.WinControls.UI.RadButtonElement)(this.jump.GetChildAt(0))).BackColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadButtonElement)(this.jump.GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            ((Telerik.WinControls.UI.RadButtonElement)(this.jump.GetChildAt(0))).Enabled = true;
            ((Telerik.WinControls.UI.RadButtonElement)(this.jump.GetChildAt(0))).ShouldPaint = false;
            ((Telerik.WinControls.UI.RadButtonElement)(this.jump.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadButtonElement)(this.jump.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.jump.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.jump.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.jump.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.jump.GetChildAt(0).GetChildAt(2))).Width = 2F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.jump.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.RoyalBlue;
            // 
            // radOffice2007ScreenTipElement1
            // 
            this.radOffice2007ScreenTipElement1.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTipElement1.Name = "radOffice2007ScreenTipElement1";
            this.radOffice2007ScreenTipElement1.TemplateType = null;
            this.radOffice2007ScreenTipElement1.TipSize = new System.Drawing.Size(0, 0);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.enter.Location = new System.Drawing.Point(575, 47);
            this.enter.Name = "enter";
            // 
            // 
            // 
            this.enter.RootElement.FocusBorderColor = System.Drawing.SystemColors.ControlDark;
            this.enter.Size = new System.Drawing.Size(118, 31);
            this.enter.TabIndex = 14;
            this.enter.Text = "Enter";
            this.enter.Click += new System.EventHandler(this.enter_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.enter.GetChildAt(0))).Text = "Enter";
            ((Telerik.WinControls.UI.RadButtonElement)(this.enter.GetChildAt(0))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadButtonElement)(this.enter.GetChildAt(0))).Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.UI.RadButtonElement)(this.enter.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.enter.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.enter.GetChildAt(0).GetChildAt(2))).Width = 2F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.enter.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Easy_GPA.Properties.Resources.gpa_backgound_cropped2;
            this.pictureBox1.Location = new System.Drawing.Point(561, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 354);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1066, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.jump);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Data Entry";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel label1;
        private Telerik.WinControls.UI.RadDropDownList comboBox1;
        private Telerik.WinControls.UI.RadButton reset;
        private Telerik.WinControls.UI.RadButton calc;
        private Telerik.WinControls.UI.RadButton cross;
        private Telerik.WinControls.UI.RadButton jump;
        private Telerik.WinControls.UI.RadOffice2007ScreenTipElement radOffice2007ScreenTipElement1;
        private Telerik.WinControls.UI.RadButton enter;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

