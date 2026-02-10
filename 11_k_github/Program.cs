namespace _11_k_github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diszno> disznok = FileManager.ReadFile("disznok2.csv");
            Console.WriteLine(String.Join('\n',disznok));
        }
    }
}
