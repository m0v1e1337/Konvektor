namespace Konvektor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь до файла (вместе с названием), который вы хотите открыть");
            Console.WriteLine("---------------------------------------------------------------------");
            List<Figure>? figures = ReadSave.Read(Console.ReadLine());
            figures = TextChange.Change(figures);
            Console.Clear();
            Console.WriteLine("Введите путь до файла (вместе с названием), куда вы хотите сохранить текст");
            Console.WriteLine("---------------------------------------------------------------------");
            ReadSave.Save(Console.ReadLine(), figures);


        }
    }
}