using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CompName
{
    public partial class Form1 : Form
    {
        string chassisType, unattendPath, argPrefix, argChassis, argHostname = String.Empty;
        bool argAutomate, helpWanted = false;
        string serialNumber = Methods.GetSerialNum();
        string[] args = Environment.GetCommandLineArgs();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectXML_Click(object sender, EventArgs e)
        {
            using (var XmlFile = new OpenFileDialog())
            {
                XmlFile.InitialDirectory = Path.GetPathRoot(Application.ExecutablePath);
                XmlFile.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                XmlFile.FilterIndex = 2;
                XmlFile.RestoreDirectory = true;
                if (XmlFile.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = XmlFile.FileName;
                    btnInject.Enabled = true;
                }
                unattendPath = textBox1.Text;
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cbTimeZone.SelectedIndex = 1;
            btnInject.Enabled = false;

        }

        private void form1_Loaded(object sender, EventArgs e)
        {
            
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnInject_Click(this, null);
            }
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (ValidateUnattendLocation(unattendPath))
            {
                if (txtHostname.Text.Length <= 15)
                {
                    try
                    {
                        string text = File.ReadAllText(unattendPath);
                        text = text.Replace("<ComputerName>IMGNAME</ComputerName>", "<ComputerName>" + txtHostname.Text + "</ComputerName>");
                        text = text.Replace("<TimeZone>Eastern Standard Time</TimeZone>", "<TimeZone>" + cbTimeZone.SelectedItem.ToString() + "</TimeZone>");
                        File.WriteAllText(unattendPath, text);
                        error = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.ToString());
                        error = true;
                    }
                }
                else
                {
                    error = true;
                    MessageBox.Show("The hostname is longer than 15 characters! Please shorten your hostname and try again", "Ruh-Roh, Raggy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                error = true;
                MessageBox.Show("The file \"" + unattendPath + "\" could not be located. Please verify it exists and try again", "Ruh-Roh, Raggy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!error)
            {
                Application.Exit();
            }
        }

        private bool ValidateUnattendLocation(string unattend)
        {
            return File.Exists(unattend);
        }

        private void XmlFileExists(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                btnInject.Enabled = true;
            }
        }

    }
}
