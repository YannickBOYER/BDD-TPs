namespace UserStory
{
    public class Scrutin
    {
        public List<Candidat> candidats = new List<Candidat>();
        public bool estCloture = false;
        public Candidat? candidatGagnant;
        public int tourEnCours = 0;

        public void AnalyserLeTour()
        {
            tourEnCours++;
            if (tourEnCours > 2)
            {
                throw new Exception("Le scrutin est déjà clôturé");
            }

            if (candidats.Any(Candidat => Candidat.pourcentage > 50))
            {
                candidatGagnant = candidats.First(Candidat => Candidat.pourcentage > 50);
                estCloture = true;
                return;
            }

            if (tourEnCours == 1)
            {
                List<Candidat> candidatsRestants = candidats.OrderByDescending(Candidat => Candidat.pourcentage).Take(3).ToList();
                candidats.Clear();
                candidats.Add(candidatsRestants[0]);
                candidatsRestants.RemoveAt(0);
                // Dans le cas d'une égalité entre le 2ème et le 3ème, on garde le premier dans l'ordre alphabétique
                if (candidatsRestants[0].pourcentage == candidatsRestants[1].pourcentage)
                {
                    candidatsRestants = candidatsRestants.OrderBy(Candidat => Candidat.nom).Take(2).ToList();
                }
                candidats.Add(candidatsRestants[0]);
                return;
            }

            if (tourEnCours == 2)
            {
                estCloture = true;
                return;
            }
        }

        public void AfficherLesResultats()
        {
            if (estCloture)
            {
                if (candidatGagnant != null)
                {
                    Console.WriteLine("Le candidat gagnant est " + candidatGagnant.nom);
                }
                else
                {
                    Console.WriteLine("Il y a égalité entre les candidats " + candidats[0].nom + " et " + candidats[1].nom + ". Pas de gagnant");
                }
            }
            else
            {
                foreach (Candidat candidat in candidats)
                {
                    Console.WriteLine("Le candidat " + candidat.nom + " a obtenu " + candidat.pourcentage + "% des voix");
                }
            }
        }
        
        public bool aGagne(string nom)
        {
            return estCloture && candidatGagnant?.nom == nom;
        }
    }
}
