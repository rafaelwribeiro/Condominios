using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Exercicio3 : IExercise
    {
        public void Execute()
        {
            var fileName = "exercicio3.txt";
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            GrantCfgFile(path);
            Console.WriteLine("Informe a string que deseja procurar no arquivo: ");
            var s = Console.ReadLine();
            int count = CountOccurrences(s, path);
            Console.WriteLine($"Palavra: {s}\nOcorrências: {count}");
        }

        private void GrantCfgFile(string path)
        {
            if (File.Exists(path)) return;
            File.WriteAllText(path, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum");
        }

        public int CountOccurrences(string s, string filePath)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    count += CountOccurrencesInLine(line, s);
            }

            return count;
        }

        private int CountOccurrencesInLine(string line, string s)
        {
            int count = 0;
            int index = 0;

            while ((index = line.IndexOf(s, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += s.Length;
            }

            return count;
        }
    }
}
