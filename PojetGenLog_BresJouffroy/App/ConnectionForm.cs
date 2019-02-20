using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class ConnectionForm : Form
    {
        private IUtilisateurRepository utilisateurRepository;
        public bool IsConnected { get; private set; }

        public ConnectionForm(IUtilisateurRepository utilisateurRepository)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IsConnected = false;
            tbMdpConnexion.PasswordChar = '*';
            this.utilisateurRepository = utilisateurRepository;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string searchValueMail = tbEmailConnexion.Text;
            string searchValueMdp = tbMdpConnexion.Text;
            if(searchValueMail == "" || searchValueMdp == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs demandés");
                return;
            }
            else if (searchValueMail == utilisateurRepository.GetEmail(searchValueMail) && searchValueMdp == utilisateurRepository.GetMdpByMail(searchValueMail))
            {
                IsConnected = true;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Votre mail ou votre mot de passe est incorrect. Veuillez réessayer !");
                return;
            }

        }

        private void lbPasDeCompte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

