public class Cours
{
    public string nomProfesseur;
    public string libelleClasse;
    public int capaciteClasse;
    public string[] matieres;
    public IList<int> listeNotes;

    public Cours(string nomProfesseur, string libelleClasse, int capaciteClasse, string[] matieres, IList<int> listeNotes){
        this.nomProfesseur = nomProfesseur;
        this.libelleClasse = libelleClasse;
        this.capaciteClasse = capaciteClasse;
        this.matieres = matieres;
        this.listeNotes = listeNotes;
    }

    public string getNomProfesseur(){
        return this.nomProfesseur;
    }

    public string getLibelleClasse(){
        return this.libelleClasse;
    }

    public string[] getMatieres(){
        return this.matieres;
    }

    public IList<int> getListeNotes(){
        return this.listeNotes;
    }

    
}