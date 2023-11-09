namespace Konvektor
{
    internal class TextChange
    {
        public static List<Figure>? Change(List<Figure>? figures)
        {
            string?[] text = new string?[9];
            int i = 0, j = 0;
            int position = 2;
            ConsoleKeyInfo key;
            do
            {
                text[i] = figures[j].Name;
                text[i + 1] = figures[j].Height.ToString();
                text[i + 2] = figures[j].Width.ToString();
                i += 3;
                j++;
            } while (text.Length > i);
            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Сохранить файл в одном из трёх форматов (txt, json, xml) - F1. Закрыть программу - Escape");
                Console.WriteLine("---------------------------------------------------------------------");

                j = 2;
                foreach (string? item in text)
                {
                    Console.SetCursorPosition(0, j);
                    Console.WriteLine("  " + item);
                    j++;
                }
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.Write("  ");
                if (key.Key == ConsoleKey.UpArrow && position >= 3)
                {
                    position--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Write("                       ");
                    Console.SetCursorPosition(2, position);
                    string? change = Console.ReadLine();
                    text[position - 2] = change;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            } while (key.Key != ConsoleKey.F1);
            i = 0;
            figures.Clear();
            do
            {
                Figure newFigure = new Figure(text[i], int.Parse(text[i + 1] ?? string.Empty), int.Parse(text[i + 2] ?? string.Empty));
                figures.Add(newFigure);
                i += 3;
            } while (text.Length > i);
            return figures;
        }
    }
}