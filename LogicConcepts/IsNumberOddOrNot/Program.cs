do 
{
    Console.Write("Ingrese número entero o presione Ctrl + C para salir: ");
    var nummberString = Console.ReadLine(); //"45"
    var numberInt = 0;
    if (int.TryParse(nummberString, out numberInt));
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt} es par");
        }
        else
        {
            Console.WriteLine($"El número {numberInt} es impar");
        }
    }

    else 
    {
        Console.WriteLine($"El número que ingresaste {nummberString} no es válido (número entero)");
    }
    

    

}while (true);
