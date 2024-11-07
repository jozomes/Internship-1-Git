using System;

namespace TextCentering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite maksimalnu širinu linije: ");
            int maxWidth = int.Parse(Console.ReadLine());

            Console.Write("Unesite minimalnu širinu linije: ");
            int minWidth = int.Parse(Console.ReadLine());

            Console.Write("Unesite tekst: ");
            string text = Console.ReadLine();

            CenterText(text, maxWidth, minWidth);
            Console.ReadLine();
        }

        static void CenterText(string text, int maxWidth, int minWidth)
        {
            string[] words = text.Split(' ', ',', '.', '!'); // Split on spaces, commas, dots, and exclamation marks

            string currentLine = "";

            foreach (string word in words)
            {
                if (currentLine.Length + word.Length + 1 <= maxWidth)
                {
                    currentLine += " " + word;
                }
                else
                {
                    int numSpaces = maxWidth - currentLine.Length;
                    if (numSpaces < 0)
                    {
                        numSpaces = minWidth - currentLine.Length;
                    }
                    int leftSpaces = numSpaces / 2;
                    int rightSpaces = numSpaces - leftSpaces;
                    Console.WriteLine(new string(' ', leftSpaces) + currentLine.Trim() + new string(' ', rightSpaces));
                    currentLine = word;
                }
            }

            // Ispis posljednje linije
            int numspaces = maxWidth - currentLine.Length;
            if (numspaces < 0)
            {
                numspaces = minWidth - currentLine.Length;
            }
            int leftspaces = numspaces / 2;
            int rightspaces = numspaces - leftspaces;
            Console.WriteLine(new string(' ', leftspaces) + currentLine.Trim() + new string(' ', rightspaces));
        }
    }
}