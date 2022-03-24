using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public static class ClassCouncil
    {
        public static void SchoolMeans(string input, string output)
        {
            /*   DRAFT
            string path = Directory.GetCurrentDirectory();
            StreamReader
            string[] lecture = File.ReadallLines(path + "@\fichier_data");
            */

            string path = Directory.GetCurrentDirectory();
            //string[] streamReader = new StreamReader(path + @"\fichier.txt");


            Dictionary<string, List<float>> Tableau_classe = new Dictionary<string, List<float>>();

            using (StreamReader streamReader = new StreamReader(input))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] column_values = line.Split(';');
                    string nom = column_values[0];
                    string matiere = column_values[1];
                    string note = column_values[2].Replace('.', ',');
                    // remplacer le . par , pour eviter des bug dans le traitement en windows francais

                    if (Tableau_classe.ContainsKey(matiere))  // matiere
                    {
                        Console.WriteLine($" {nom}{matiere} console1");
                        // dictionaire dictionnaire[clé] = valeur
                        Tableau_classe[matiere].Add(float.Parse(note));
                        //Tableau_classe[column_values[1]].Add(float.Parse(column_values[2]));
                    }
                    else
                    {
                        Console.WriteLine($" {nom}{column_values[1]} console2");
                        Tableau_classe.Add(matiere, new List<float>() { float.Parse(note) });
                        //Tableau_classe[column_values[1]].Add(float.Parse(column_values[2]));
                    }

                }

                streamReader.Dispose();
            }

            using (StreamWriter sortie = new StreamWriter(output))
            {
                foreach (KeyValuePair<string, List<float>> X in Tableau_classe)
                {
                    sortie.WriteLine(X.Key + ';' + X.Value.Average());
                }
            }

        }
    }
}
