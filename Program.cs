Console.Write("Введите свое Ax: ");
var Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свое Ay: ");
var Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свое Bx: ");
var Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свое By: ");
var By = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свое Cx: ");
var Cx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свое Cy: ");
var Cy = Convert.ToDouble(Console.ReadLine());

var AB = (float)Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2));
var BC = (float)Math.Sqrt(Math.Pow((Cx - Bx), 2) + Math.Pow((Cy - By), 2));
var AC = (float)Math.Sqrt(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2));
var P = AB + BC + AC; 
Console.WriteLine($"{AB}");
Console.WriteLine($"{BC}");
Console.WriteLine($"{AC}");
if (Math.Abs(AB - BC) <= 0.001 && Math.Abs(AC - BC) <= 0.001)
    Console.WriteLine("Равносторонний");
else
    Console.WriteLine("Не равносторонний");
if (Math.Abs(BC - AB) <= 0.001 | Math.Abs(AC - AB) <= 0.001 | Math.Abs(AC - BC) <= 0.001)
    Console.WriteLine("Равнобедренный");
else
    Console.WriteLine("Не Равнобедренный");

var minArray = (new[] { AC, AB, BC })[0];
var maxArray = (new[] { AC, AB, BC })[0];
for (int i = 1; i < (new[] { AC, AB, BC }).Length; i++)
{
    if (minArray > (new[] { AC, AB, BC })[i])
        minArray = (new[] { AC, AB, BC })[i];

    if (maxArray < (new[] { AC, AB, BC })[i])
        maxArray = (new[] { AC, AB, BC })[i];
}
var agsArray = P - minArray - maxArray;
var m = Math.Pow(maxArray, 2) - Math.Pow(minArray, 2) - Math.Pow(agsArray, 2);
if (Math.Abs(m) <= 0.001)
    Console.WriteLine("Прямоугольный");
else
    Console.WriteLine("Не Прямоугольный");
Console.WriteLine($"{P}");
for (int i = 0; i * 2 < P; i++)
    Console.WriteLine($"{2 * i}");