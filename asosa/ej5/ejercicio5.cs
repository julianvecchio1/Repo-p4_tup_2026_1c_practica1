        Console.WriteLine("Ingrese el dia");
        string? dia = Console.ReadLine()?.ToLower().Trim();
       switch (dia)
       {
           case "lunes":
           case "martes":
           case "miercoles":
           case "jueves":
           case "viernes":
          
                Console.WriteLine("No es fin de semana");
                break;
        case "domingo":
        case "sabado":
                Console.WriteLine("Es fin de semana");
                break;
           default:
                Console.WriteLine("No existe ese dia");
                break;
       }

       