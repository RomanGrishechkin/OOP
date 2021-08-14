using System;

namespace _3DFigures
{
    class Figaro
    {
        private int[] H = { 0, 0, 7 };
        private double R = 5;
        private int N = 6;
        private double[,] pi;
        public Figaro()
        {
            pi = new double[6, 3];
        }
        public Figaro(int h, double r, int n)
        {
            R = r;
            N = n;
            pi = new double[n, 3];
            H[2] = h;
        }
        public void Pi()
        {
            for (int i = 0; i < N; i++)
            {
                pi[i, 0] = R * Math.Cos(2 * Math.PI * i / (N - 1));
                pi[i, 1] = R * Math.Sin(2 * Math.PI * i / (N - 1));
                pi[i, 2] = 0;
            }
        }
        public void PrintTriangle()
        {
            for (int i = N - 1; i >= 0; i--)
            {
                if (i !=0)
                {
                    Console.WriteLine("{3}#:\n{0}\t{1}\t{2}", pi[i, 0], pi[i, 1], pi[i, 2], i + 1);
                    Console.WriteLine("\n{0}\t{1}\t{2}", pi[i - 1, 0], pi[i - 1, 1], pi[i - 1, 2]);
                    Console.WriteLine("\n{0}\t{1}\t{2}\n", H[0], H[1], H[2]);
                }
                else
                {
                    Console.WriteLine("{3}#:\n{0}\t{1}\t{2}", pi[i, 0], pi[i, 1], pi[i, 2], i + 1);
                    Console.WriteLine("\n{0}\t{1}\t{2}", pi[N-1, 0], pi[N - 1, 1], pi[N - 1, 2]);
                    Console.WriteLine("\n{0}\t{1}\t{2}\n", H[0], H[1], H[2]);
                }
            }
        }
        public void Normal()
        {

            double vx1, vy1, vz1, vx2, vy2, vz2;


            for (int i = 0; i < N; i++)
            {
                vx1 = H[0] - pi[i, 0];
                vy1 = H[1] - pi[i, 1];
                vz1 = H[2] - pi[i, 2];
                if (i == N - 1)
                {
                    vx2 = pi[i, 0] - pi[0, 0];
                    vy2 = pi[i, 1] - pi[0, 1];
                    vz2 = pi[i, 2] - pi[0, 2];
                }
                else
                {
                    vx2 = pi[i, 0] - pi[i + 1, 0];
                    vy2 = pi[i, 1] - pi[i + 1, 1];
                    vz2 = pi[i, 2] - pi[i + 1, 2];
                }
                Console.WriteLine("Pi{0}#Normal\n{1}\t{2}\t{3}", i + 1, vy1 * vz2 - vz1 * vy2, vz1 * vx2 - vx1 * vz2, vx1 * vy2 - vy1 * vx2);
            }

        }
    }
}
