using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SolrNet.Utils;

namespace ConsoleApp44
{
    internal class Vector
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int Vector3 { get; set; }
        public Vector (int x1, int y1, int x2, int y2, int vector3)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Vector3 = vector3;
        }

        public Vector()
        {
            
        }

        int sommax;
        int sommay;
        public void Somma(ref int x1, ref int y1, ref int x2, ref int y2, out int sommax, out int sommay)
        {
           sommax = x1 + x2;
           sommay = y1 + y2;
        }
    }
}
