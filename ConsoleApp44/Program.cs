using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector();
            
            int a = vector.X1 = 2;
            int b = vector.Y1 = 2;
            int c = vector.X2 = 3;
            int d = vector.Y2 = 3;
            int sommax;
            int sommay;
            vector.Vector3 = int.Parse("4; 4");
            Console.WriteLine(vector.Somma(ref a, ref b, ref  c, ref d, out sommax, out sommay));
        }
    }
}
