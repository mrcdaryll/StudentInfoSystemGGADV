namespace GGAD_StudentInfoSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentNumber = new System.Windows.Forms.TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pinNumber = new System.Windows.Forms.TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signIn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.appErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(411, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pamantasan ng Lungsod ng Muntinlupa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(522, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Portal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(516, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fill out the form to log in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(501, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student Number";
            // 
            // studentNumber
            // 
            this.studentNumber.Location = new System.Drawing.Point(501, 168);
            this.studentNumber.MaxLength = 8;
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(209, 23);
            this.studentNumber.TabIndex = 5;
            this.studentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentNumber_KeyPress);
            this.studentNumber.Validating += new System.ComponentModel.CancelEventHandler(this.studentNumber_Validating);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.InitialImage")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(471, 168);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(24, 23);
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(501, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pin";
            // 
            // pinNumber
            // 
            this.pinNumber.Location = new System.Drawing.Point(501, 230);
            this.pinNumber.MaxLength = 6;
            this.pinNumber.Name = "pinNumber";
            this.pinNumber.PasswordChar = '*';
            this.pinNumber.ShortcutsEnabled = false;
            this.pinNumber.Size = new System.Drawing.Size(209, 23);
            this.pinNumber.TabIndex = 8;
            this.pinNumber.TextChanged += new System.EventHandler(this.pinNumber_TextChanged);
            this.pinNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pinNumber_KeyPress);
            this.pinNumber.Validating += new System.ComponentModel.CancelEventHandler(this.pinNumber_Validating);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.BackgroundImage")));
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.InitialImage")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(471, 230);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(24, 23);
            this.guna2PictureBox2.TabIndex = 9;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(630, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Forgot Pin?";
            // 
            // signIn
            // 
            this.signIn.BackColor = System.Drawing.Color.Transparent;
            this.signIn.BorderRadius = 15;
            this.signIn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.signIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signIn.FillColor = System.Drawing.Color.DarkGreen;
            this.signIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signIn.ForeColor = System.Drawing.Color.White;
            this.signIn.Location = new System.Drawing.Point(501, 296);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(209, 30);
            this.signIn.TabIndex = 11;
            this.signIn.Text = "Sign in";
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(471, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Activate my Account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(634, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Contact us";
            // 
            // appErrorProvider
            // 
            this.appErrorProvider.ContainerControl = this;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.BackgroundImage = global::GGAD_StudentInfoSystem.Properties.Resources.bg_side_final__2_;
            this.guna2PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(44, 67);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(406, 301);
            this.guna2PictureBox3.TabIndex = 14;
            this.guna2PictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GGAD_StudentInfoSystem.Properties.Resources.bg_side__Presentation__169____1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 439);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.pinNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.studentNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label8;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button signIn;
        private Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private TextBox pinNumber;
        private Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private TextBox studentNumber;
        private Label label4;
        private ErrorProvider appErrorProvider;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
    }
}