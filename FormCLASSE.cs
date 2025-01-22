using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms
{
    public partial class FormCLASSE : Form
    {
        public FormCLASSE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBScolaire())
                {
                    // Création d'une nouvelle classe
                    Classe classe = new Classe
                    {
                        Libelle = txtLibelle.Text
                    };

                    // Ajout de la classe dans la base de données
                    db.Classe.Add(classe);
                    db.SaveChanges();

                    // Actualiser la DataGridView
                    Actualiser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualiser()
        {
            try
            {
                using (var db = new DBScolaire())
                {
                    // Chargement des données dans la DataGridView
                    dataGridView1.DataSource = db.Classe.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'actualisation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormCLASSE_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBScolaire())
                {
                    // Chargement des classes dans le ComboBox
                    comboBox1.DataSource = db.Classe.ToList();
                    comboBox1.DisplayMember = "Libelle";
                    comboBox1.ValueMember = "Id";
                }

                // Actualiser la DataGridView
                Actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
