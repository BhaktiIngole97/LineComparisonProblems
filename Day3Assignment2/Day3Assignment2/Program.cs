int x1 = 2, x2 = 6, y1 = 3, y2 = 3;
int x3 = 4, x4 = 7, y3 = 3, y4 = 5;
double line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
Console.WriteLine(line1.Equals(line2));