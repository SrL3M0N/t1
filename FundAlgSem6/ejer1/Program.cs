
Console.WriteLine("Ingrese su nombre: ");
String nombre = Convert.ToString(Console.ReadLine());
Console.WriteLine("Ingrese sus ventas de este mes: ");
double ventas= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese su sueldo: ");
double sueldo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese años en la empresa: ");
double anos = Convert.ToInt16(Console.ReadLine());
double bono=0;
if (ventas <= 600)
{
    bono = ventas * 0.05;
}
else if (ventas <= 3000)
{
    bono = ventas * 0.07;
}
else if (ventas > 3000) 
{
     bono = ventas * 0.06 + 300;
}

double sueldoN = sueldo + bono;
double dsct = 0;
if (anos < 4)
{
    dsct = sueldoN * 0.065;
}
else if (anos >= 4) 
{
    dsct = sueldoN * 0.045;
}

double sueldoT = sueldoN - dsct;

Console.WriteLine($"Su nombre es: {nombre}");
Console.WriteLine($"Su sueldo ganado este mes es de: {sueldoN}");
Console.WriteLine($"Su descuento de este mes es de: {dsct}");
Console.WriteLine($"Su sueldo a obtener este mes es de: {sueldoT}");

