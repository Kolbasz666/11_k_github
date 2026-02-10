using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_k_github
{
    public class Diszno
    {
        public string name { get; set; }
        public string gender { get; set; }
        public double weight { get; set; }
        public int age { get; set; }
        public Diszno(string[] data)
        {
            name = data[0].Trim(' ');
            gender = data[1].Trim(' ');
            weight = double.Parse(data[2]);
            age = int.Parse(data[3]);
        }
        public string Rename(string newName)
        {
            name = newName;
            return $"Az új név: {name}";
        }
        public double Feed()
        {
            return weight *= 1.01;
        }
        public override string ToString()
        {
            return $"Disznó neve: {name}, neme: {gender}, súlya: {weight}, kora: {age}";
        }
    }
}
