using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Exit the main form when user clicks on Exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Show the student details table with the current registered students details
        private void newRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails();
            sd.Show();
            
        }
    }
}
