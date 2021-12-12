Console.Write("Enter cordinate x of dot A: ");
var Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter cordinate y of dot A: ");
var Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter cordinate x of dot B: ");
var Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter cordinate Y of dot B: ");
var By = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter cordinate x of dot C: ");
var Cx = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter cordinate Y of dot C: ");
var Cy = Convert.ToDouble(Console.ReadLine());

var AB = (float)Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2));
var BC = (float)Math.Sqrt(Math.Pow((Cx - Bx), 2) + Math.Pow((Cy - By), 2));
var AC = (float)Math.Sqrt(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2));
var P = AB + BC + AC; 
Console.WriteLine($"Length of AB is: {AB}");
Console.WriteLine($"Length of BC is: {BC}");
Console.WriteLine($"Length of AC is: {AC}");
if (Math.Abs(AB - BC) <= 0.001 && Math.Abs(AC - BC) <= 0.001)
    Console.WriteLine("Triangle is equilateral");
else
    Console.WriteLine("Triangle is not equilateral");
if (Math.Abs(BC - AB) <= 0.001 | Math.Abs(AC - AB) <= 0.001 | Math.Abs(AC - BC) <= 0.001)
    Console.WriteLine("Triangle is isosceles");
else
    Console.WriteLine("Triangle is not isosceles");

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
    Console.WriteLine("Triangle is rectangular");
else
    Console.WriteLine("Triangle is not rectangular");
Console.WriteLine($"Perimeter: {P}");
for (int i = 0; i * 2 < P; i++)
    Console.WriteLine($"{2 * i}");