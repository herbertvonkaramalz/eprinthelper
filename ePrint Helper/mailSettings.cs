using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ePrint_Helper
{
    public partial class mailSettings : Form
    {
        public mailSettings()
        {
            InitializeComponent();
        }

        private void mailSettings_Load(object sender, EventArgs e)
        {
            label1.Text = "Bitte geben Sie die Adresse des Druckers ein!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email = mailValue.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success) {
                saveMail(mailValue.Text);
                this.Close();
            }

            else {
                MessageBox.Show("Bitte überprüfen Sie das Format der eingegebenen E-Mail-Adresse!");
            }
        }

        private void saveMail(string mail) {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Add("printer", mail);
            config.Save(ConfigurationSaveMode.Minimal);
        }
    }
}
