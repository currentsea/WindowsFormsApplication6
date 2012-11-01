using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Outlook;
namespace WindowsFormsApplication6
{
    public partial class PStampForm : Form
    {
        private Microsoft.Office.Interop.Outlook.Application a; 
        public PStampForm()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            label1.Text = openFileDialog1.FileName; 
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Begin Process for PST Extraction Here here....
        }

        // PST File Selecting Event Handler Method
        private void button1_Click(object sender, EventArgs e)
        {
            // Bring up PST File Selection 

            openFileDialog1.DefaultExt = "pst";
            openFileDialog1.Filter = "PST Files (*.pst)|*.PST|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.ShowDialog(); 

            // Verify Selected file is an OST Here... 

        }

        // Output Directory Selection Event Handler Method
        private void button2_Click(object sender, EventArgs e)
        {
            
            // Prompts user for output path selection...
            if (OutputDirChooser.ShowDialog() == DialogResult.OK)
            {
                label2.Text = OutputDirChooser.SelectedPath; 
            } 


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // SEND TO PST PROCESSOR...................
            // File is 
            PSTProcessor p = new PSTProcessor(label1.Text, label2.Text); 


        }


    }
}
