using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleAdvertisement
{
    public partial class greenvilleAdvertisement : Form
    {
        public greenvilleAdvertisement()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Welcome " + firstNameInput.Text + " " + lastNameInput.Text;
            outputLabel.Visible = true;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void neverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputLabel.Font = new Font("Arial", 12);
        }

        private void impactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputLabel.Font = new Font("Impact", 50);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputLabel.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputLabel.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputLabel.ForeColor = Color.Blue;
        }
    }
}
