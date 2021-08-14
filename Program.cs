namespace _3DFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Figaro conus = new Figaro();
            conus.Pi();
            conus.PrintTriangle();
            conus.Normal();
            Figaro conus1 = new Figaro(15, 10, 8);
            conus1.Pi();
            conus1.PrintTriangle();
        }
    }
}
