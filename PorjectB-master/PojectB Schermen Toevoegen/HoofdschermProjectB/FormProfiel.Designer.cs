﻿namespace ProjectB

{
    partial class FormProfiel
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
            this.panelBoven = new System.Windows.Forms.Panel();
            this.labelMyAccount = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelMovis = new System.Windows.Forms.Label();
            this.iconContact = new System.Windows.Forms.PictureBox();
            this.iconMyAccount = new System.Windows.Forms.PictureBox();
            this.iconMovis = new System.Windows.Forms.PictureBox();
            this.panelAanmelden = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWachtword = new System.Windows.Forms.TextBox();
            this.textBoxGebruiksnaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelMyProfile = new System.Windows.Forms.Panel();
            this.panelBoven.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMyAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMovis)).BeginInit();
            this.panelAanmelden.SuspendLayout();
            this.panelMyProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBoven
            // 
            this.panelBoven.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelBoven.Controls.Add(this.labelMyAccount);
            this.panelBoven.Controls.Add(this.labelContact);
            this.panelBoven.Controls.Add(this.labelMovis);
            this.panelBoven.Controls.Add(this.iconContact);
            this.panelBoven.Controls.Add(this.iconMyAccount);
            this.panelBoven.Controls.Add(this.iconMovis);
            this.panelBoven.Location = new System.Drawing.Point(-1, 0);
            this.panelBoven.Margin = new System.Windows.Forms.Padding(2);
            this.panelBoven.Name = "panelBoven";
            this.panelBoven.Size = new System.Drawing.Size(1129, 106);
            this.panelBoven.TabIndex = 0;
            // 
            // labelMyAccount
            // 
            this.labelMyAccount.AutoSize = true;
            this.labelMyAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyAccount.Location = new System.Drawing.Point(872, 37);
            this.labelMyAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyAccount.Name = "labelMyAccount";
            this.labelMyAccount.Size = new System.Drawing.Size(236, 46);
            this.labelMyAccount.TabIndex = 14;
            this.labelMyAccount.Text = "My account";
            this.labelMyAccount.MouseLeave += new System.EventHandler(this.labelMyAccount_MouseLeave);
            this.labelMyAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMyAccount_MouseMove);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(491, 37);
            this.labelContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(166, 46);
            this.labelContact.TabIndex = 13;
            this.labelContact.Text = "Contact";
            this.labelContact.Click += new System.EventHandler(this.labelContact_Click);
            this.labelContact.MouseLeave += new System.EventHandler(this.labelContact_MouseLeave);
            this.labelContact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelContact_MouseMove);
            // 
            // labelMovis
            // 
            this.labelMovis.AutoSize = true;
            this.labelMovis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMovis.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovis.Location = new System.Drawing.Point(112, 37);
            this.labelMovis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMovis.Name = "labelMovis";
            this.labelMovis.Size = new System.Drawing.Size(152, 46);
            this.labelMovis.TabIndex = 12;
            this.labelMovis.Tag = "";
            this.labelMovis.Text = "Movies";
            this.labelMovis.Click += new System.EventHandler(this.labelMovis_Click);
            this.labelMovis.MouseLeave += new System.EventHandler(this.labelMovis_MouseLeave);
            this.labelMovis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMovis_MouseMove);
            // 
            // iconContact
            // 
            this.iconContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconContact.Image = global::HoofdschermProjectB.Properties.Resources.img_542845;
            this.iconContact.Location = new System.Drawing.Point(381, 8);
            this.iconContact.Margin = new System.Windows.Forms.Padding(2);
            this.iconContact.Name = "iconContact";
            this.iconContact.Size = new System.Drawing.Size(93, 88);
            this.iconContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconContact.TabIndex = 11;
            this.iconContact.TabStop = false;
            this.iconContact.Tag = "";
            this.iconContact.Click += new System.EventHandler(this.iconContact_Click);
            this.iconContact.MouseLeave += new System.EventHandler(this.labelContact_MouseLeave);
            this.iconContact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelContact_MouseMove);
            // 
            // iconMyAccount
            // 
            this.iconMyAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMyAccount.Image = global::HoofdschermProjectB.Properties.Resources.img_568656;
            this.iconMyAccount.Location = new System.Drawing.Point(761, 13);
            this.iconMyAccount.Margin = new System.Windows.Forms.Padding(2);
            this.iconMyAccount.Name = "iconMyAccount";
            this.iconMyAccount.Size = new System.Drawing.Size(93, 83);
            this.iconMyAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMyAccount.TabIndex = 10;
            this.iconMyAccount.TabStop = false;
            this.iconMyAccount.Tag = "";
            this.iconMyAccount.MouseLeave += new System.EventHandler(this.labelMyAccount_MouseLeave);
            this.iconMyAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMyAccount_MouseMove);
            // 
            // iconMovis
            // 
            this.iconMovis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMovis.Image = global::HoofdschermProjectB.Properties.Resources._83519;
            this.iconMovis.Location = new System.Drawing.Point(20, 6);
            this.iconMovis.Margin = new System.Windows.Forms.Padding(2);
            this.iconMovis.Name = "iconMovis";
            this.iconMovis.Size = new System.Drawing.Size(88, 93);
            this.iconMovis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMovis.TabIndex = 9;
            this.iconMovis.TabStop = false;
            this.iconMovis.Tag = "";
            this.iconMovis.Click += new System.EventHandler(this.iconMovis_Click);
            this.iconMovis.MouseLeave += new System.EventHandler(this.labelMovis_MouseLeave);
            this.iconMovis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMovis_MouseMove);
            // 
            // panelAanmelden
            // 
            this.panelAanmelden.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelAanmelden.Controls.Add(this.button2);
            this.panelAanmelden.Controls.Add(this.label8);
            this.panelAanmelden.Controls.Add(this.label7);
            this.panelAanmelden.Controls.Add(this.label6);
            this.panelAanmelden.Controls.Add(this.label5);
            this.panelAanmelden.Controls.Add(this.textBox6);
            this.panelAanmelden.Controls.Add(this.textBox5);
            this.panelAanmelden.Controls.Add(this.textBox4);
            this.panelAanmelden.Controls.Add(this.textBox3);
            this.panelAanmelden.Controls.Add(this.label4);
            this.panelAanmelden.Controls.Add(this.button1);
            this.panelAanmelden.Controls.Add(this.label3);
            this.panelAanmelden.Controls.Add(this.label2);
            this.panelAanmelden.Controls.Add(this.textBoxWachtword);
            this.panelAanmelden.Controls.Add(this.textBoxGebruiksnaam);
            this.panelAanmelden.Controls.Add(this.label1);
            this.panelAanmelden.Location = new System.Drawing.Point(0, 106);
            this.panelAanmelden.Margin = new System.Windows.Forms.Padding(2);
            this.panelAanmelden.Name = "panelAanmelden";
            this.panelAanmelden.Size = new System.Drawing.Size(1141, 665);
            this.panelAanmelden.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(234, 409);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "ACCOUNT AANMAKEN";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 325);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Herhaal wachtwoord";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Wachtwoord";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-mailadres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Naam";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(145, 85);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(266, 20);
            this.textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(148, 165);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(266, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(148, 244);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(266, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 325);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(140, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "U kunt hier aanmelden";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(907, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "INLOGGEN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(664, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wachtwoord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(642, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gebruikersnaam";
            // 
            // textBoxWachtword
            // 
            this.textBoxWachtword.Location = new System.Drawing.Point(760, 155);
            this.textBoxWachtword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWachtword.Name = "textBoxWachtword";
            this.textBoxWachtword.Size = new System.Drawing.Size(266, 20);
            this.textBoxWachtword.TabIndex = 2;
            // 
            // textBoxGebruiksnaam
            // 
            this.textBoxGebruiksnaam.Location = new System.Drawing.Point(760, 85);
            this.textBoxGebruiksnaam.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGebruiksnaam.Name = "textBoxGebruiksnaam";
            this.textBoxGebruiksnaam.Size = new System.Drawing.Size(266, 20);
            this.textBoxGebruiksnaam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(766, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ik heb al een account";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(15, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mijn gegevens";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(20, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Naam: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(20, 205);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "E-mail: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(682, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 26);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mijn reserveringen";
            // 
            // panelMyProfile
            // 
            this.panelMyProfile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMyProfile.Controls.Add(this.label12);
            this.panelMyProfile.Controls.Add(this.label11);
            this.panelMyProfile.Controls.Add(this.label10);
            this.panelMyProfile.Controls.Add(this.label9);
            this.panelMyProfile.Location = new System.Drawing.Point(0, 107);
            this.panelMyProfile.Margin = new System.Windows.Forms.Padding(2);
            this.panelMyProfile.Name = "panelMyProfile";
            this.panelMyProfile.Size = new System.Drawing.Size(1141, 665);
            this.panelMyProfile.TabIndex = 16;
            // 
            // FormProfiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 629);
            this.Controls.Add(this.panelBoven);
            this.Controls.Add(this.panelMyProfile);
            this.Controls.Add(this.panelAanmelden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProfiel";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProfiel_FormClosed);
            this.panelBoven.ResumeLayout(false);
            this.panelBoven.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMyAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMovis)).EndInit();
            this.panelAanmelden.ResumeLayout(false);
            this.panelAanmelden.PerformLayout();
            this.panelMyProfile.ResumeLayout(false);
            this.panelMyProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBoven;
        private System.Windows.Forms.Label labelMyAccount;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelMovis;
        private System.Windows.Forms.PictureBox iconContact;
        private System.Windows.Forms.PictureBox iconMyAccount;
        private System.Windows.Forms.PictureBox iconMovis;
        private System.Windows.Forms.Panel panelAanmelden;
        private System.Windows.Forms.TextBox textBoxWachtword;
        private System.Windows.Forms.TextBox textBoxGebruiksnaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelMyProfile;
    }
}
