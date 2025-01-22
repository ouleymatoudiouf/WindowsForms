using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fERMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cRUDClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCLASSE formClasse = new FormCLASSE();
            formClasse.MdiParent = this;
            formClasse.Show();
        }

        private void cRUDEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormETUDIANT formEtudiant = new FormETUDIANT();
            formEtudiant.MdiParent = this;
            formEtudiant.Show();
        }
    }
}
