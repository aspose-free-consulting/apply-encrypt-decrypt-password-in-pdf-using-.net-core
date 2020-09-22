using System;
using System.ComponentModel;
using System.Windows.Forms;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace PDFEncryption
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "License Files (*.lic)|*.lic|All files (*.*)|*.*";
            fd.InitialDirectory = @"C:\";
            fd.Title = "Please select a License file to Use.";
            fd.Multiselect = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtLicense.Text = fd.FileName;
                Aspose.Pdf.License lic = new Aspose.Pdf.License();
                lic.SetLicense(txtLicense.Text);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
            fd.InitialDirectory = @"C:\";
            fd.Title = "Please select a PDF file to upload.";
            fd.Multiselect = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                lnkPDF.Text = fd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtLicense.Text) && !lnkPDF.Text.Equals("Select a PDF File To Encrypt"))
                {
                    Document document = new Document(lnkPDF.Text);
                    // Apply restrictions on all privileges
                    DocumentPrivilege documentPrivilege = rdoForbid.Checked == true ? DocumentPrivilege.ForbidAll : DocumentPrivilege.AllowAll;
                    documentPrivilege.AllowScreenReaders = chkScreenReaders.Checked;
                    documentPrivilege.AllowAssembly = chkAssembly.Checked;
                    documentPrivilege.AllowCopy = chkCopy.Checked;
                    documentPrivilege.AllowModifyAnnotations = chkModifyAnnotations.Checked;
                    documentPrivilege.AllowModifyContents = chkModifyContent.Checked;
                    documentPrivilege.AllowPrint = chkPrint.Checked;
                    // Encrypt the file with User and Owner password.
                    // Need to set the password, so that once the user views the file with user password
                    document.Encrypt(txtUser.Text, txtOwner.Text, documentPrivilege, CryptoAlgorithm.AESx128, false);
                    // Save updated document
                    document.Save("SetPrivileges_out.pdf");
                    MessageBox.Show("PDF has been encrypted successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Please select License and PDF file first.", "No File Selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
