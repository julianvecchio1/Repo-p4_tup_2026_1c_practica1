   var listaPar = new List<int>();
       var  listaDivisiblePor3 = new List<int>();
        for  (int i = 1;i <= 100;i++)
        {
            if(i % 2 == 0)
            {
                listaPar.Add(i);
            }

            if(i % 3 == 0)
            {
                listaDivisiblePor3.Add(i);
            }
            
        }
        Console.WriteLine("Lista de numeros pares");
        foreach (var item in listaPar)
        {
            Console.WriteLine(
                item
            );

    }


    Console.WriteLine("Lista de numeros divisibles por 3");
     foreach (var item in listaDivisiblePor3)
        {
            Console.WriteLine(
                item
            );

    }