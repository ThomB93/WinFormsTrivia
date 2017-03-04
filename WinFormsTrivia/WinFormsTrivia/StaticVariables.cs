using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTrivia
{
    public static class StaticVariables
    {
        public static string Question { get; set; }
        public static List<string> Answers { get; set; }
        public static string CorrectAnswer { get; set; }
        public static int Points { get; set; }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
