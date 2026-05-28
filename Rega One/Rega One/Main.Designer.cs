namespace Rega_One
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainHeader_pn = new System.Windows.Forms.Panel();
            this.minimize_picbox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn_picbox = new System.Windows.Forms.PictureBox();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.mainHead_lbl = new System.Windows.Forms.Label();
            this.userID_lbl = new System.Windows.Forms.Label();
            this.userID_txtbox = new System.Windows.Forms.TextBox();
            this.firstName_txtbox = new System.Windows.Forms.TextBox();
            this.firstName_lbl = new System.Windows.Forms.Label();
            this.surname_txtbox = new System.Windows.Forms.TextBox();
            this.surname_lbl = new System.Windows.Forms.Label();
            this.age_txtbox = new System.Windows.Forms.TextBox();
            this.age_lbl = new System.Windows.Forms.Label();
            this.occupation_lbl = new System.Windows.Forms.Label();
            this.occupation_txtbox = new System.Windows.Forms.TextBox();
            this.country_lbl = new System.Windows.Forms.Label();
            this.country_txtbox = new System.Windows.Forms.TextBox();
            this.mail_lbl = new System.Windows.Forms.Label();
            this.mail_txtbox = new System.Windows.Forms.TextBox();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.inputMain_btn = new System.Windows.Forms.Button();
            this.gender_cmbbox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.successMsg_lbl = new System.Windows.Forms.Label();
            this.failMsg_lbl = new System.Windows.Forms.Label();
            this.mainHeader_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainHeader_pn
            // 
            this.mainHeader_pn.Controls.Add(this.minimize_picbox);
            this.mainHeader_pn.Controls.Add(this.pictureBox1);
            this.mainHeader_pn.Controls.Add(this.exitBtn_picbox);
            this.mainHeader_pn.Controls.Add(this.search_txtbox);
            this.mainHeader_pn.Controls.Add(this.search_lbl);
            this.mainHeader_pn.Controls.Add(this.mainHead_lbl);
            this.mainHeader_pn.Location = new System.Drawing.Point(12, 8);
            this.mainHeader_pn.Name = "mainHeader_pn";
            this.mainHeader_pn.Size = new System.Drawing.Size(1021, 101);
            this.mainHeader_pn.TabIndex = 0;
            // 
            // minimize_picbox
            // 
            this.minimize_picbox.Image = ((System.Drawing.Image)(resources.GetObject("minimize_picbox.Image")));
            this.minimize_picbox.Location = new System.Drawing.Point(926, 5);
            this.minimize_picbox.Name = "minimize_picbox";
            this.minimize_picbox.Size = new System.Drawing.Size(34, 34);
            this.minimize_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_picbox.TabIndex = 5;
            this.minimize_picbox.TabStop = false;
            this.minimize_picbox.Click += new System.EventHandler(this.minimize_picbox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exitBtn_picbox
            // 
            this.exitBtn_picbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitBtn_picbox.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn_picbox.Image")));
            this.exitBtn_picbox.Location = new System.Drawing.Point(966, 4);
            this.exitBtn_picbox.Name = "exitBtn_picbox";
            this.exitBtn_picbox.Size = new System.Drawing.Size(36, 35);
            this.exitBtn_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBtn_picbox.TabIndex = 3;
            this.exitBtn_picbox.TabStop = false;
            this.exitBtn_picbox.Click += new System.EventHandler(this.exitBtn_picbox_Click);
            // 
            // search_txtbox
            // 
            this.search_txtbox.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txtbox.Location = new System.Drawing.Point(842, 60);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(160, 28);
            this.search_txtbox.TabIndex = 2;
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_lbl.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lbl.Location = new System.Drawing.Point(745, 57);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(91, 29);
            this.search_lbl.TabIndex = 1;
            this.search_lbl.Text = "Search";
            // 
            // mainHead_lbl
            // 
            this.mainHead_lbl.AutoSize = true;
            this.mainHead_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainHead_lbl.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHead_lbl.Location = new System.Drawing.Point(100, 25);
            this.mainHead_lbl.Name = "mainHead_lbl";
            this.mainHead_lbl.Size = new System.Drawing.Size(206, 52);
            this.mainHead_lbl.TabIndex = 0;
            this.mainHead_lbl.Text = "Rega One";
            // 
            // userID_lbl
            // 
            this.userID_lbl.AutoSize = true;
            this.userID_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userID_lbl.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID_lbl.Location = new System.Drawing.Point(45, 135);
            this.userID_lbl.Name = "userID_lbl";
            this.userID_lbl.Size = new System.Drawing.Size(96, 27);
            this.userID_lbl.TabIndex = 1;
            this.userID_lbl.Text = "User ID";
            // 
            // userID_txtbox
            // 
            this.userID_txtbox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID_txtbox.Location = new System.Drawing.Point(183, 131);
            this.userID_txtbox.Name = "userID_txtbox";
            this.userID_txtbox.Size = new System.Drawing.Size(230, 31);
            this.userID_txtbox.TabIndex = 2;
            // 
            // firstName_txtbox
            // 
            this.firstName_txtbox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_txtbox.Location = new System.Drawing.Point(183, 188);
            this.firstName_txtbox.Name = "firstName_txtbox";
            this.firstName_txtbox.Size = new System.Drawing.Size(230, 31);
            this.firstName_txtbox.TabIndex = 4;
            // 
            // firstName_lbl
            // 
            this.firstName_lbl.AutoSize = true;
            this.firstName_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstName_lbl.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_lbl.Location = new System.Drawing.Point(46, 195);
            this.firstName_lbl.Name = "firstName_lbl";
            this.firstName_lbl.Size = new System.Drawing.Size(60, 27);
            this.firstName_lbl.TabIndex = 3;
            this.firstName_lbl.Text = "Name";
            // 
            // surname_txtbox
            // 
            this.surname_txtbox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_txtbox.Location = new System.Drawing.Point(183, 245);
            this.surname_txtbox.Name = "surname_txtbox";
            this.surname_txtbox.Size = new System.Drawing.Size(230, 31);
            this.surname_txtbox.TabIndex = 6;
            // 
            // surname_lbl
            // 
            this.surname_lbl.AutoSize = true;
            this.surname_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surname_lbl.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_lbl.Location = new System.Drawing.Point(46, 252);
            this.surname_lbl.Name = "surname_lbl";
            this.surname_lbl.Size = new System.Drawing.Size(96, 27);
            this.surname_lbl.TabIndex = 5;
            this.surname_lbl.Text = "Surname";
            // 
            // age_txtbox
            // 
            this.age_txtbox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_txtbox.Location = new System.Drawing.Point(181, 300);
            this.age_txtbox.Name = "age_txtbox";
            this.age_txtbox.Size = new System.Drawing.Size(232, 31);
            this.age_txtbox.TabIndex = 8;
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age_lbl.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_lbl.Location = new System.Drawing.Point(46, 304);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(48, 27);
            this.age_lbl.TabIndex = 7;
            this.age_lbl.Text = "Age";
            // 
            // occupation_lbl
            // 
            this.occupation_lbl.AutoSize = true;
            this.occupation_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.occupation_lbl.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupation_lbl.Location = new System.Drawing.Point(45, 417);
            this.occupation_lbl.Name = "occupation_lbl";
            this.occupation_lbl.Size = new System.Drawing.Size(132, 27);
            this.occupation_lbl.TabIndex = 9;
            this.occupation_lbl.Text = "Occupation";
            // 
            // occupation_txtbox
            // 
            this.occupation_txtbox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupation_txtbox.Location = new System.Drawing.Point(181, 411);
            this.occupation_txtbox.Name = "occupation_txtbox";
            this.occupation_txtbox.Size = new System.Drawing.Size(232, 31);
            this.occupation_txtbox.TabIndex = 12;
            // 
            // country_lbl
            // 
            this.country_lbl.AutoSize = true;
            this.country_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.country_lbl.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_lbl.Location = new System.Drawing.Point(46, 471);
            this.country_lbl.Name = "country_lbl";
            this.country_lbl.Size = new System.Drawing.Size(96, 27);
            this.country_lbl.TabIndex = 11;
            this.country_lbl.Text = "Country";
            // 
            // country_txtbox
            // 
            this.country_txtbox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_txtbox.Location = new System.Drawing.Point(181, 465);
            this.country_txtbox.Name = "country_txtbox";
            this.country_txtbox.Size = new System.Drawing.Size(230, 31);
            this.country_txtbox.TabIndex = 14;
            // 
            // mail_lbl
            // 
            this.mail_lbl.AutoSize = true;
            this.mail_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mail_lbl.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_lbl.Location = new System.Drawing.Point(46, 526);
            this.mail_lbl.Name = "mail_lbl";
            this.mail_lbl.Size = new System.Drawing.Size(60, 27);
            this.mail_lbl.TabIndex = 13;
            this.mail_lbl.Text = "Mail";
            // 
            // mail_txtbox
            // 
            this.mail_txtbox.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_txtbox.Location = new System.Drawing.Point(181, 522);
            this.mail_txtbox.Name = "mail_txtbox";
            this.mail_txtbox.Size = new System.Drawing.Size(230, 31);
            this.mail_txtbox.TabIndex = 16;
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gender_lbl.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lbl.Location = new System.Drawing.Point(46, 362);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(84, 27);
            this.gender_lbl.TabIndex = 15;
            this.gender_lbl.Text = "Gender";
            // 
            // inputMain_btn
            // 
            this.inputMain_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.inputMain_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputMain_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMain_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputMain_btn.Location = new System.Drawing.Point(181, 591);
            this.inputMain_btn.Name = "inputMain_btn";
            this.inputMain_btn.Size = new System.Drawing.Size(232, 57);
            this.inputMain_btn.TabIndex = 17;
            this.inputMain_btn.Text = "Register";
            this.inputMain_btn.UseVisualStyleBackColor = false;
            // 
            // gender_cmbbox
            // 
            this.gender_cmbbox.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_cmbbox.FormattingEnabled = true;
            this.gender_cmbbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_cmbbox.Location = new System.Drawing.Point(181, 357);
            this.gender_cmbbox.Name = "gender_cmbbox";
            this.gender_cmbbox.Size = new System.Drawing.Size(232, 32);
            this.gender_cmbbox.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(560, 422);
            this.dataGridView1.TabIndex = 19;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.update_btn.Location = new System.Drawing.Point(768, 591);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(105, 57);
            this.update_btn.TabIndex = 20;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.MistyRose;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Crimson;
            this.delete_btn.Location = new System.Drawing.Point(909, 591);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(104, 57);
            this.delete_btn.TabIndex = 21;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // successMsg_lbl
            // 
            this.successMsg_lbl.AutoSize = true;
            this.successMsg_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.successMsg_lbl.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successMsg_lbl.ForeColor = System.Drawing.Color.Gold;
            this.successMsg_lbl.Location = new System.Drawing.Point(450, 584);
            this.successMsg_lbl.Name = "successMsg_lbl";
            this.successMsg_lbl.Size = new System.Drawing.Size(274, 24);
            this.successMsg_lbl.TabIndex = 22;
            this.successMsg_lbl.Text = "Successfully registered!";
            // 
            // failMsg_lbl
            // 
            this.failMsg_lbl.AutoSize = true;
            this.failMsg_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.failMsg_lbl.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failMsg_lbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.failMsg_lbl.Location = new System.Drawing.Point(450, 609);
            this.failMsg_lbl.Name = "failMsg_lbl";
            this.failMsg_lbl.Size = new System.Drawing.Size(241, 24);
            this.failMsg_lbl.TabIndex = 23;
            this.failMsg_lbl.Text = "Registration Failure!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1053, 723);
            this.Controls.Add(this.failMsg_lbl);
            this.Controls.Add(this.successMsg_lbl);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gender_cmbbox);
            this.Controls.Add(this.inputMain_btn);
            this.Controls.Add(this.mail_txtbox);
            this.Controls.Add(this.gender_lbl);
            this.Controls.Add(this.country_txtbox);
            this.Controls.Add(this.mail_lbl);
            this.Controls.Add(this.occupation_txtbox);
            this.Controls.Add(this.country_lbl);
            this.Controls.Add(this.occupation_lbl);
            this.Controls.Add(this.age_txtbox);
            this.Controls.Add(this.age_lbl);
            this.Controls.Add(this.surname_txtbox);
            this.Controls.Add(this.surname_lbl);
            this.Controls.Add(this.firstName_txtbox);
            this.Controls.Add(this.firstName_lbl);
            this.Controls.Add(this.userID_txtbox);
            this.Controls.Add(this.userID_lbl);
            this.Controls.Add(this.mainHeader_pn);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rega One";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainHeader_pn.ResumeLayout(false);
            this.mainHeader_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainHeader_pn;
        private System.Windows.Forms.PictureBox exitBtn_picbox;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.Label mainHead_lbl;
        private System.Windows.Forms.Label userID_lbl;
        private System.Windows.Forms.TextBox userID_txtbox;
        private System.Windows.Forms.TextBox firstName_txtbox;
        private System.Windows.Forms.Label firstName_lbl;
        private System.Windows.Forms.TextBox surname_txtbox;
        private System.Windows.Forms.Label surname_lbl;
        private System.Windows.Forms.TextBox age_txtbox;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.Label occupation_lbl;
        private System.Windows.Forms.TextBox occupation_txtbox;
        private System.Windows.Forms.Label country_lbl;
        private System.Windows.Forms.TextBox country_txtbox;
        private System.Windows.Forms.Label mail_lbl;
        private System.Windows.Forms.TextBox mail_txtbox;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Button inputMain_btn;
        private System.Windows.Forms.ComboBox gender_cmbbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label successMsg_lbl;
        private System.Windows.Forms.Label failMsg_lbl;
        private System.Windows.Forms.PictureBox minimize_picbox;
    }
}

