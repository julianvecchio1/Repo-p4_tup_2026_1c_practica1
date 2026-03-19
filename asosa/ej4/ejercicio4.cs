    Console.WriteLine("Ingrese el primer numero");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine($"El numero {num1} es mayor que {num2}");
        }
        else if(num1 == num2)
        {
            Console.WriteLine($"Los numeros son iguales");
        } else
        {
                        Console.WriteLine($"El numero {num2} es mayor que {num1}");
        };