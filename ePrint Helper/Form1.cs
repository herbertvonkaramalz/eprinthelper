using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace ePrint_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["printer"] == null)
            {
                mailSettings editor = new mailSettings();
                editor.ShowDialog();
                ConfigurationManager.RefreshSection("appSettings");
            }


            string partner = ConfigurationManager.AppSettings.Get("printer");
            connection.Text = "Verbundener Drucker: " + partner;

        }

        private void select_Click(object sender, EventArgs e)
        {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "PDF-Dateien|*.pdf";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                    select.BackColor = Color.LimeGreen;
                    select.ForeColor = Color.White;
                    select.Text = "Datei ausgewählt \n " + Path.GetFileName(filePath);
                    print.Enabled = true;
                }

        }

        private void print_Click(object sender, EventArgs e)
        {
            print.Enabled = false;

            try {
                MailMessage mM = new MailMessage();
                mM.From = new MailAddress("yourmail@outlook.de");
                mM.To.Add(ConfigurationManager.AppSettings.Get("printer"));
                mM.Subject = "Print-Job: " + Get8CharacterRandomString();
                mM.Attachments.Add(new Attachment(filePath));
                SmtpClient sC = new SmtpClient("SMTP.office365.com");
                sC.Port = 587;
                sC.Credentials = new NetworkCredential("yourmail@outlook.de", "yourPassword");
                sC.EnableSsl = true;
                sC.Send(mM);

            }
            catch (Exception ex) {
                MessageBox.Show("Unbehandelter Fehler aufgetreten!\n\n" + ex.ToString());
            }

            print.Text = "Wurde versendet und wird demnächst gedruckt...";
            print.BackColor = Color.LimeGreen;
            print.ForeColor = Color.White;

            filePath = "";
            openFileDialog1.Reset();
            print.Enabled = false;

            select.BackColor = Color.Red;
            select.ForeColor = Color.White;

            Thread.Sleep(1500);

            print.Text = "An Drucker senden";
            print.BackColor = default(Color);
            print.ForeColor = default(Color);

            select.Text = "Datei auswählen";
            select.BackColor = Color.Red;
            select.ForeColor = Color.White;

        }

        public string Get8CharacterRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period.
            return path.Substring(0, 8);  // Return 8 character string
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HP ePint Helper\n" +
                "Version: 1.0\n" +
                "SMTP-St: Office 365\n" +
                "Stamp-Key: " + Get8CharacterRandomString() + "\n\n" +
                "Diese Software steht in keinerlei Verbindung zu HP Inc. \noder deren Tochergesellschaften.\n" +
                "Die Weitergabe der Software ist nicht-kommerziell erlaubt, unter Angabe des Entwicklers.\n\n" +
                "© 2019 / 2020 - \n" +
                "https://github.com/herbertvonkaramalz");
        }
    }
}
