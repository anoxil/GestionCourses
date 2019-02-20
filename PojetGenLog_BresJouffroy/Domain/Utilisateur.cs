using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur
    {
        public virtual int IdUtilisateur { get; set; }
        public virtual string Email { get; set; }
        public virtual string MotDePasse { get; set; }

        public virtual bool EstConnecte { get; set; }

        public Utilisateur()
        {
        }

        public Utilisateur(int id, string email, string motDePasse, bool estConnecte)
        {
            IdUtilisateur = id;
            Email = email;
            MotDePasse = motDePasse;
            EstConnecte = estConnecte;
        }
    }
}
