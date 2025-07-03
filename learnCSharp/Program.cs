// See https://aka.ms/new-console-template for more information

// int nb = 32;
// string[] matieres = new string[] {"geo", "histoire", "physique", "math"};
// IList<int> listeNote = new List<int>();
// listeNote.Add(18);
// listeNote.Add(20);
// listeNote.Add(14);
// Cours classe = new Cours("louis", "D102", nb, matieres, listeNote);
// string[] tabMatieres = classe.getMatieres();
// foreach (string matiere in tabMatieres)
// {
//     Console.WriteLine(matiere);
// }
// IList<int> notes = classe.getListeNotes();
// notes.RemoveAt(2);
// notes.Add(16);
// float moyenne = 0;
// foreach (var note in notes)
// {
//     moyenne += note;
// }
// moyenne /= notes.Count;
// Console.WriteLine("Moyenne : " + moyenne);

Animal cat = new Chat("lucien le chat", "blanc");
Animal fish = new Poisson("rob la carangue", "gris", "carnivore");
cat.toString();
fish.toString();
