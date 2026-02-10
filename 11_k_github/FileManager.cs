using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_k_github
{
    public class FileManager
    {
        public static List<Diszno> ReadFile(string fileName)
        {
            List<Diszno> list = new();
			try
			{
                foreach (string item in File.ReadAllLines(fileName, Encoding.UTF8).Skip(1))
                {
                    list.Add(new Diszno(item.Replace('.',',').Split(';')));
                }
			}
			catch (Exception err)
			{
                Console.WriteLine(err.Message);
			}
            return list;
        }
    }
}
