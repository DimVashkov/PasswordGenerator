
namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbGeneratedPassword = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.tbPasswordLength = new System.Windows.Forms.TextBox();
            this.cbSymbols = new System.Windows.Forms.CheckBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.cbLowercaseChars = new System.Windows.Forms.CheckBox();
            this.cbUppercaseChars = new System.Windows.Forms.CheckBox();
            this.cbSimilarChars = new System.Windows.Forms.CheckBox();
            this.cbAmbiguousChars = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Include Symbols:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Include Numbers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Include Lowercase Characters:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Include Uppercase Characters:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Exclude Similar Characters:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Exclude Ambiguous Characters:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 449);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Your New Password:";
            // 
            // tbGeneratedPassword
            // 
            this.tbGeneratedPassword.Location = new System.Drawing.Point(271, 449);
            this.tbGeneratedPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbGeneratedPassword.Name = "tbGeneratedPassword";
            this.tbGeneratedPassword.Size = new System.Drawing.Size(588, 35);
            this.tbGeneratedPassword.TabIndex = 8;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(588, 528);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(150, 53);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(271, 528);
            this.btnGeneratePassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(266, 53);
            this.btnGeneratePassword.TabIndex = 10;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // tbPasswordLength
            // 
            this.tbPasswordLength.Location = new System.Drawing.Point(372, 44);
            this.tbPasswordLength.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbPasswordLength.Name = "tbPasswordLength";
            this.tbPasswordLength.Size = new System.Drawing.Size(160, 35);
            this.tbPasswordLength.TabIndex = 11;
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Location = new System.Drawing.Point(372, 92);
            this.cbSymbols.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(143, 34);
            this.cbSymbols.TabIndex = 12;
            this.cbSymbols.Text = "(e.g. @#$%)";
            this.cbSymbols.UseVisualStyleBackColor = true;
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Location = new System.Drawing.Point(372, 138);
            this.cbNumbers.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(149, 34);
            this.cbNumbers.TabIndex = 13;
            this.cbNumbers.Text = "(e.g. 123456)";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // cbLowercaseChars
            // 
            this.cbLowercaseChars.AutoSize = true;
            this.cbLowercaseChars.Location = new System.Drawing.Point(372, 184);
            this.cbLowercaseChars.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbLowercaseChars.Name = "cbLowercaseChars";
            this.cbLowercaseChars.Size = new System.Drawing.Size(170, 34);
            this.cbLowercaseChars.TabIndex = 14;
            this.cbLowercaseChars.Text = "(e.g. abcdefgh)";
            this.cbLowercaseChars.UseVisualStyleBackColor = true;
            // 
            // cbUppercaseChars
            // 
            this.cbUppercaseChars.AutoSize = true;
            this.cbUppercaseChars.Location = new System.Drawing.Point(372, 230);
            this.cbUppercaseChars.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbUppercaseChars.Name = "cbUppercaseChars";
            this.cbUppercaseChars.Size = new System.Drawing.Size(187, 34);
            this.cbUppercaseChars.TabIndex = 15;
            this.cbUppercaseChars.Text = "(e.g. ABCDEFGH)";
            this.cbUppercaseChars.UseVisualStyleBackColor = true;
            // 
            // cbSimilarChars
            // 
            this.cbSimilarChars.AutoSize = true;
            this.cbSimilarChars.Location = new System.Drawing.Point(372, 276);
            this.cbSimilarChars.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbSimilarChars.Name = "cbSimilarChars";
            this.cbSimilarChars.Size = new System.Drawing.Size(219, 34);
            this.cbSimilarChars.TabIndex = 16;
            this.cbSimilarChars.Text = "(e.g. i, l, 1, L, o, O, 0)";
            this.cbSimilarChars.UseVisualStyleBackColor = true;
            // 
            // cbAmbiguousChars
            // 
            this.cbAmbiguousChars.AutoSize = true;
            this.cbAmbiguousChars.Location = new System.Drawing.Point(372, 322);
            this.cbAmbiguousChars.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbAmbiguousChars.Name = "cbAmbiguousChars";
            this.cbAmbiguousChars.Size = new System.Drawing.Size(216, 34);
            this.cbAmbiguousChars.TabIndex = 17;
            this.cbAmbiguousChars.Text = "(e.g. {}[]()/\\\'\"`~,;:.<>)";
            this.cbAmbiguousChars.UseVisualStyleBackColor = true;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 662);
            this.Controls.Add(this.cbAmbiguousChars);
            this.Controls.Add(this.cbSimilarChars);
            this.Controls.Add(this.cbUppercaseChars);
            this.Controls.Add(this.cbLowercaseChars);
            this.Controls.Add(this.cbNumbers);
            this.Controls.Add(this.cbSymbols);
            this.Controls.Add(this.tbPasswordLength);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbGeneratedPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbGeneratedPassword;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TextBox tbPasswordLength;
        private System.Windows.Forms.CheckBox cbSymbols;
        private System.Windows.Forms.CheckBox cbNumbers;
        private System.Windows.Forms.CheckBox cbLowercaseChars;
        private System.Windows.Forms.CheckBox cbUppercaseChars;
        private System.Windows.Forms.CheckBox cbSimilarChars;
        private System.Windows.Forms.CheckBox cbAmbiguousChars;
    }
}

