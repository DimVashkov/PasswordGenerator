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
            int length = 8;
            Generator passwordGenerator;
            try
            {
                 length = int.Parse(tbPasswordLength.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{exception}");
            }

            if(!cbSymbols.Checked && !cbNumbers.Checked && !cbLowercaseChars.Checked && !cbUppercaseChars.Checked)
            {
                // If nothing is checked, generate a default password of numbers and letters.
                passwordGenerator = new Generator(length, false, true, true, false, false, false);
            }
            else
            {
                passwordGenerator = new Generator(length, cbSymbols.Checked, cbNumbers.Checked, cbLowercaseChars.Checked, cbUppercaseChars.Checked, cbSimilarChars.Checked, cbAmbiguousChars.Checked);
            }

            tbGeneratedPassword.Text = passwordGenerator.GeneratePassword();
        }
    }
}
