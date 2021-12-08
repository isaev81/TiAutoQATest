
const double delta = 0.01;
bool tr90(double a, double b, double c) {
    if ((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) < delta) { return true; }
    else { return false; }
}

Console.WriteLine("введите 6 координат точек теругольника : ");
Console.WriteLine("Введите координаты точки А  - X : ");
string inp = Console.ReadLine();
double ax = double.Parse(inp);
Console.WriteLine("Введите координаты точки А  - Y : ");
string inp2 = Console.ReadLine();
double ay = double.Parse(inp2);
Console.WriteLine("Координаты точки А (X,Y) : (" + inp+","+inp2+")");
Console.WriteLine("Введите координаты точки B -  X : ");
inp = Console.ReadLine();
double bx = double.Parse(inp);
Console.WriteLine("Введите координаты точки B  - Y : ");
inp2 = Console.ReadLine();
double by = double.Parse(inp2);
Console.WriteLine("Координаты точки B (X,Y) : (" + inp + "," + inp2 + ")");
Console.WriteLine("Введите координаты точки C  - X : ");
inp = Console.ReadLine();
double cx = double.Parse(inp);
Console.WriteLine("Введите координаты точки C  - Y : ");
inp2 = Console.ReadLine();
double cy = double.Parse(inp2);
Console.WriteLine("Координаты точки C (X,Y) : (" + inp + "," + inp2 + ")");
double ab = Math.Sqrt(Math.Pow(by-ay, 2)+ Math.Pow(bx - ax, 2));
Console.WriteLine("Длина стороны AB : " + ab);
double bc = Math.Sqrt(Math.Pow(by - cy, 2) + Math.Pow(cx - bx, 2));
Console.WriteLine("Длина стороны BC : " + bc);
double ac = Math.Sqrt(Math.Pow(ay - cy, 2) + Math.Pow(cx - ax, 2));
Console.WriteLine("Длина стороны AC : " + ac);
if (ac>0 && bc>0 && ab>0) { 
    int kol = 0;
    if ((Math.Abs(ab - bc)) < delta) { kol++; }
    if ((Math.Abs(ab - ac)) < delta) { kol++; }
    if ((Math.Abs(bc - ac)) < delta) { kol++; }
    //if ((Math.Abs(Math.Round(ab) - Math.Round(bc))) < delta) { kol++; }
    //if ((Math.Abs(Math.Round(ab) - Math.Round(ac))) < delta) { kol++; }
    //if ((Math.Abs(Math.Round(bc) - Math.Round(ac))) < delta) { kol++; }

    if (kol == 3) { Console.WriteLine("Треугольник равносторонний"); }  
    if (kol == 1) { Console.WriteLine("Треугольник равнобедренный"); }
    if ( tr90(ac,ab,bc)==true | tr90(ab, bc, ac) == true | tr90(bc, ac, ab) == true) { Console.WriteLine("Треугольник прямоугольный"); }
    double p = (ab + bc + ac);
    Console.WriteLine("Периметр треугольника : "+ (ab + bc + ac));
    Console.WriteLine("Четные числа : ");
    for (int i = 2; i <= p; i++) {
        double result = Math.IEEERemainder(i, 2);
        if (result == 0) { Console.Write(i+","); }
    }

}
else { Console.WriteLine("Это не треугольник"); }

 
//
//if (  (Math.Round(ab) == Math.Round(bc)) | (Math.Round(ab) == Math.Round(ac))  | (Math.Round(bc) == Math.Round(ac)) ) { Console.WriteLine("Треугольник равнобедренный"); }
//if (((Math.Abs(Math.Round(ab) - Math.Round(bc))) < delta) | ((Math.Abs(Math.Round(ab) - Math.Round(ac))) < delta)) { Console.WriteLine("Треугольник равносторонний"); }