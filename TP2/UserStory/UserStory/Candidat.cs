using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStory
{
    public class Candidat
    {
        public string nom;
        public int pourcentage;

        public Candidat(string nom, int nombreDeVoix, int nombreDeVoixTotal)
        {
            this.nom = nom;
            this.pourcentage = nombreDeVoix * 100 / nombreDeVoixTotal;
        }
    }
}
