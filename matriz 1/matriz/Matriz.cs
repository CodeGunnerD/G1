using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Matriz
    {
        const int MAXF = 100;
        const int MAXC = 100;
        private int[,] x;
        private int f, c;


        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0; c = 0;
        }

        public void cargar(int nf, int nc, int a, int b)
        {
            f = nf; c = nc;
            int f1, c1;
            Random r = new Random();
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b);
                }
            }
        }
        public string descargar()
        {
            string s = "";
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x09";
                }
                s = s + "\x0d" + "\x0a";
            }
            return s;
        }

        public void ejercicio1(int nf)
        {
            for (int col1 = 1; col1 < c; col1++)
            {
                for (int col2 = col1 + 1; col2 <= c; col2++)
                {
                    if (x[nf, col1] > x[nf, col2])
                    {
                        intercambiarColumnas(col1, col2);
                    }
                }
            }
        }


        public void intercambiarColumnas(int c1, int c2)
        {
            for (int f1 = 1; f1 <= f; f1++)
            {
                int aux = x[f1, c1];
                x[f1, c1] = x[f1, c2];
                x[f1, c2] = aux;
            }
        }





    }
}
