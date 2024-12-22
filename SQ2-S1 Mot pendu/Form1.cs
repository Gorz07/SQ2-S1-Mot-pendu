using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQ2_S1_Mot_pendu
{
    public partial class frmPendu : Form
    {
        public string motAChercher;
        public int comptePendu = 0;
        public List<char> lettresTrouvees = new List<char>();
        public void CreationAlphabet()
        {
            // remplisage d'alphabet dans le combo
            for (int k = 0; k<26; k++)
            {
                cmbAlphabet.Items.Add((char)('A' + k)).ToString();
            }

            cmbAlphabet.SelectedIndex = 0;
        }
        public frmPendu()
        {
            InitializeComponent();
            CreationAlphabet();
            txtMot.Focus();
        }

        private void txtMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Saisie de mot à chercher
            try
            {
                if (txtMot.Text != "")
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        motAChercher = txtMot.Text.ToUpper();
                        txtMot.Clear();
                        txtMot.Visible = false;
                        btnValider.Visible = false;
                        lblMotAChercher.Text = "Devinez le mot!";
                        groupBox1.Visible = true;
                    }
                }
            }
            catch
            {
                Exception ex;
            }            
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            txtMot_KeyPress(null, new KeyPressEventArgs((char)Keys.Enter));
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            char lettreSelectionnee = (char)cmbAlphabet.SelectedItem;
            foreach (char lettre in motAChercher)
            {
                // Test de lettre selectionné
                if ((char)cmbAlphabet.SelectedItem == lettre)
                {
                    // Lettre trouvée dans le mot
                    lettresTrouvees.Add((char)cmbAlphabet.SelectedItem);
                    lblMotAChercher.Text = $"Lettre(s) trouvée(s){string.Join(",",lettresTrouvees)}";
                }
                else
                {
                    // Lettre pas trouvée dans le mot
                    comptePendu++; 
                }
            }
        }
    }
}
