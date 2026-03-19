    Console.WriteLine("Ingrese el precio del Producto");
        int precioProducto = Convert.ToInt32(Console.ReadLine());
        
        decimal precioFinal = 0;

        if (precioProducto <= 0) {
            Console.WriteLine(
                    "Valor invalido del producto");
            return;
        }

        Console.WriteLine("Ingrese la forma de pago");
        Console.WriteLine("1 - Efectivo");
        Console.WriteLine("2 - Tarjeta");
        int formaPago = Convert.ToInt32(Console.ReadLine());

        if (formaPago != 1 && formaPago != 2)
        {
            Console.WriteLine("Forma de pago invalida");
            return;
        }

        if (formaPago == 2)
        {
            Console.WriteLine("Ingrese los 16 digitos de la tarjeta");
            string? numTarjeta = Console.ReadLine()?.Trim();


            if (numTarjeta.Length != 16) {
                Console.WriteLine("Numero de tarjeta invalido");
                return;
            }

            precioFinal = precioProducto * 1.10m;
            

        } else
        {
            precioFinal = precioProducto;
        }
        

        Console.WriteLine($"El precio final del producto es: {precioFinal}" );
        