﻿
Console.WriteLine("Ingrese ultimo digito de la placa del vehiculo: ");
String digito = Convert.ToString(Console.ReadLine());
digito = digito.ToUpper();
int contaV = 0;
int contaA = 0;
int contaR = 0;
int ndigito = Convert.ToInt16(digito);
if (digito == "f" || ndigito < 10 && ndigito > -1)
{
    while (digito != "F")
    {

        if (ndigito < 4)
        {

            contaV += 1;
        }
        else if (ndigito < 7)
        {

            contaA += 1;
        }
        else if (ndigito < 10)
        {
            contaR += 1;
        }
        Console.WriteLine("Ingrese ultimo digito de la placa del vehiculo: ");
        digito = Convert.ToString(Console.ReadLine());
        digito = digito.ToUpper();


    }
    Console.WriteLine($"han pasado {contaV} con la pegatina verde, {contaA} con la pegatina Azul y {contaR} con la pegatina Roja");
}
else
{
    Console.WriteLine("Error al ingresar caracteres no validos, intente en una proxima ocasion");
}