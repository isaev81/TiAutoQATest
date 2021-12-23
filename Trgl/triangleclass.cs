namespace Trgl
{
    public class triangleclass 
    {
        public double ab, bc, ac, ax, ay, bx, by, cx, cy, p;
        public string s;
        // public const double delta = 0.01;
        public void Input()
        {
            Console.WriteLine("введите 6 координат точек теругольника : ");
            Console.WriteLine("Введите координаты точки А  - X : ");
            string inp = Console.ReadLine();
            ax = double.Parse(inp);
            Console.WriteLine("Введите координаты точки А  - Y : ");
            string inp2 = Console.ReadLine();
            ay = double.Parse(inp2);
            Console.WriteLine("Координаты точки А (X,Y) : (" + inp + "," + inp2 + ")");
            Console.WriteLine("Введите координаты точки B -  X : ");
            inp = Console.ReadLine();
            bx = double.Parse(inp);
            Console.WriteLine("Введите координаты точки B  - Y : ");
            inp2 = Console.ReadLine();
            by = double.Parse(inp2);
            Console.WriteLine("Координаты точки B (X,Y) : (" + inp + "," + inp2 + ")");
            Console.WriteLine("Введите координаты точки C  - X : ");
            inp = Console.ReadLine();
            cx = double.Parse(inp);
            Console.WriteLine("Введите координаты точки C  - Y : ");
            inp2 = Console.ReadLine();
            cy = double.Parse(inp2);
            Console.WriteLine("Координаты точки C (X,Y) : (" + inp + "," + inp2 + ")");

        }
        public void Side()
        {
            ab = Math.Sqrt(Math.Pow(by - ay, 2) + Math.Pow(bx - ax, 2));
            Console.WriteLine("Длина стороны AB : " + ab);
            bc = Math.Sqrt(Math.Pow(by - cy, 2) + Math.Pow(cx - bx, 2));
            Console.WriteLine("Длина стороны BC : " + bc);
            ac = Math.Sqrt(Math.Pow(ay - cy, 2) + Math.Pow(cx - ax, 2));
            Console.WriteLine("Длина стороны AC : " + ac);
        }

        const double delta = 0.01;
        bool tr90(double a, double b, double c)
        {
            if ((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) < delta) { return true; }
            else { return false; }
        }
        public void Sidecheck()
        {
            if (ac > 0 && bc > 0 && ab > 0)
            {
                int kol = 0;
                if ((Math.Abs(ab - bc)) < delta) { kol++; }
                if ((Math.Abs(ab - ac)) < delta) { kol++; }
                if ((Math.Abs(bc - ac)) < delta) { kol++; }
                if (kol == 3) { Console.WriteLine("Треугольник равносторонний"); }
                if (kol == 1) { Console.WriteLine("Треугольник равнобедренный"); }
                if (tr90(ac, ab, bc) == true | tr90(ab, bc, ac) == true | tr90(bc, ac, ab) == true) { Console.WriteLine("Треугольник прямоугольный"); }
            }
        }
        public void Perimetr()
        {
            p = (ab + bc + ac);
            Console.WriteLine("Периметр треугольника : " + (ab + bc + ac));
        }
        public string Masss()
        {
            int mas = ((int)(p / 2)) * 2;
            //Console.WriteLine(Mass(mas));
            return Mass(mas);
        }
        string Mass(int i)
        {

            if (i == 2) return "Четные числа : 2" + s;
            s = Mass(i - 2) + "; " + i;
            return s;
        }




    }
}