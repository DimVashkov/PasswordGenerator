
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
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Include Symbols:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Include Numbers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Include Lowercase Characters:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Include Uppercase Characters:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Exclude Similar Characters:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Exclude Ambiguous Characters:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Your New Password:";
            // 
            // tbGeneratedPassword
            // 
            this.tbGeneratedPassword.Location = new System.Drawing.Point(200, 328);
            this.tbGeneratedPassword.Name = "tbGeneratedPassword";
            this.tbGeneratedPassword.Size = new System.Drawing.Size(344, 20);
            this.tbGeneratedPassword.TabIndex = 8;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(567, 326);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(200, 275);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(133, 23);
            this.btnGeneratePassword.TabIndex = 10;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // tbPasswordLength
            // 
            this.tbPasswordLength.Location = new System.Drawing.Point(200, 32);
            this.tbPasswordLength.Name = "tbPasswordLength";
            this.tbPasswordLength.Size = new System.Drawing.Size(82, 20);
            this.tbPasswordLength.TabIndex = 11;
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Location = new System.Drawing.Point(200, 69);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(85, 17);
            this.cbSymbols.TabIndex = 12;
            this.cbSymbols.Text = "(e.g. @#$%)";
            this.cbSymbols.UseVisualStyleBackColor = true;
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Location = new System.Drawing.Point(200, 99);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(89, 17);
            this.cbNumbers.TabIndex = 13;
            this.cbNumbers.Text = "(e.g. 123456)";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // cbLowercaseChars
            // 
            this.cbLowercaseChars.AutoSize = true;
            this.cbLowercaseChars.Location = new System.Drawing.Point(200, 129);
            this.cbLowercaseChars.Name = "cbLowercaseChars";
            this.cbLowercaseChars.Size = new System.Drawing.Size(98, 17);
            this.cbLowercaseChars.TabIndex = 14;
            this.cbLowercaseChars.Text = "(e.g. abcdefgh)";
            this.cbLowercaseChars.UseVisualStyleBackColor = true;
            // 
            // cbUppercaseChars
            // 
            this.cbUppercaseChars.AutoSize = true;
            this.cbUppercaseChars.Location = new System.Drawing.Point(200, 161);
            this.cbUppercaseChars.Name = "cbUppercaseChars";
            this.cbUppercaseChars.Size = new System.Drawing.Size(111, 17);
            this.cbUppercaseChars.TabIndex = 15;
            this.cbUppercaseChars.Text = "(e.g. ABCDEFGH)";
            this.cbUppercaseChars.UseVisualStyleBackColor = true;
            // 
            // cbSimilarChars
            // 
            this.cbSimilarChars.AutoSize = true;
            this.cbSimilarChars.Location = new System.Drawing.Point(200, 191);
            this.cbSimilarChars.Name = "cbSimilarChars";
            this.cbSimilarChars.Size = new System.Drawing.Size(125, 17);
            this.cbSimilarChars.TabIndex = 16;
            this.cbSimilarChars.Text = "(e.g. i, l, 1, L, o, O, 0)";
            this.cbSimilarChars.UseVisualStyleBackColor = true;
            // 
            // cbAmbiguousChars
            // 
            this.cbAmbiguousChars.AutoSize = true;
            this.cbAmbiguousChars.Location = new System.Drawing.Point(200, 224);
            this.cbAmbiguousChars.Name = "cbAmbiguousChars";
            this.cbAmbiguousChars.Size = new System.Drawing.Size(106, 17);
            this.cbAmbiguousChars.TabIndex = 17;
            this.cbAmbiguousChars.Text = "( {}[]()/\\\'\"`~,;:.<>)";
            this.cbAmbiguousChars.UseVisualStyleBackColor = true;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "PasswordGenerator";
            this.Text = "Form1";
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

