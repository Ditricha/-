using System;

namespace HomeWork1.App
{
    class Program
    {
        static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
        static int LevenshteinDistance(string firstWord, string secondWord)
        {
            var n = firstWord.Length + 1;
            var m = secondWord.Length + 1;
            var matrixD = new int[n, m];

            const int deletionCost = 1;
            const int insertionCost = 1;

            for (var i = 0; i < n; i++)
            {
                matrixD[i, 0] = i;
            }
            for (var j = 0; j < m; j++)
            {
                matrixD[0, j] = j;
            }
            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    var substitutionCost = firstWord[i - 1] == secondWord[j - 1] ? 0 : 1;

                        matrixD[i, j] = Minimum(matrixD[i - 1, j] + deletionCost,
                                                matrixD[i, j - 1] + insertionCost,
                                                matrixD[i - 1, j - 1] + substitutionCost);
                }
            }
            return matrixD[n - 1, m - 1];
        }

        static void Main(string[] args)
        {
            string[] options = new[] { "Let the sun beat down upon my face", "The forests will echo with laughter", "Been dazed and confused for so long",
                                       "I am gonna ramble on, sing my song", "Upon us all a little rain must fall" };

            var esc = ConsoleKey.Escape;
            ConsoleKeyInfo cki;

            Console.WriteLine("Press 'Enter' to start writing a line.");
            cki = Console.ReadKey(true);

            do {
                Random rnd = new Random();
                int random = rnd.Next(0, options.Length);

                DateTime startedAt = DateTime.Now;

                //Console.WriteLine("\n" + options[rnd.Next(0, options.Length)]);
                Console.WriteLine("\n" + options[random]);
                string line = Console.ReadLine();

                TimeSpan span = DateTime.Now - startedAt;

                if (String.Compare(options[random], line) == 0)
                {
                    Console.WriteLine($"\nYour print speed is {span.TotalSeconds}\n");
                }
                else
                {
                    var s1 = options[random];
                    var s2 = line;
                    Console.WriteLine($"\nYour print speed is {span.TotalSeconds}\n" + "Mistakes: {0}", LevenshteinDistance(s1, s2));
                }
                Console.WriteLine("Let's try one more time!");
                Console.WriteLine("Press 'Enter' to start writing a line or 'Esc' to quit.");
                cki = Console.ReadKey(true);
            } while (cki.Key != esc);
        }
    }
}
