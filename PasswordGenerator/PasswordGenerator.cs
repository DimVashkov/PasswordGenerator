using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            int length = int.Parse(tbPasswordLength.Text);

            Generator test1 = new Generator(length, cbSymbols.Checked, cbNumbers.Checked, cbLowercaseChars.Checked, cbUppercaseChars.Checked, cbSimilarChars.Checked, cbAmbiguousChars.Checked);
            tbGeneratedPassword.Text = test1.GeneratePassword();
        }
    }
}
