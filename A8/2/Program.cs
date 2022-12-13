System.Console.WriteLine("1 - Pedra");
System.Console.WriteLine("2 - Paper");
System.Console.WriteLine("3 - Estisores");
System.Console.WriteLine("");
int contador1 = 0;
int contador2 = 0;

for (int i = 1; i <= 5; i++)
{
    System.Console.WriteLine("Triau la vostra opció:     1 / 2 / 3");
    int a = int.Parse(System.Console.ReadLine());
    int b = new Random().Next(1, 4);

    if (b == 1) System.Console.WriteLine("L'oponent ha seleccionat pedra");
    else if (b == 2) System.Console.WriteLine("L'oponent ha seleccionat paper");
    else if (b == 3) System.Console.WriteLine("L'oponent ha seleccionat estisores");

    if (a == 1 && b == 2)
    {
        contador2++;
        System.Console.WriteLine("Has perdut la ronda " + i);
    }

    else if (a == 1 && b == 3)
    {
        contador1++;
        System.Console.WriteLine("Has guanyat la ronda " + i);
    }

    else if (a == 2 && b == 1)
    {
        contador1++;
        System.Console.WriteLine("Has guanyat la ronda " + i);
    }
    
    else if (a == 2 && b == 3)
    {
        contador2++;
        System.Console.WriteLine("Has perdut la ronda " + i);

    }   

    else if (a == 3 && b == 1)
    {
        contador2++;
        System.Console.WriteLine("Has perdut la ronda " + i);

    }

    else if (a == 3 && b == 2)
    {
        contador1++;
        System.Console.WriteLine("Has guanyat la ronda " + i);

    }

    else if (a == b)
    {
        System.Console.WriteLine("Has empatat la ronda " + i + ", es repetirá la ronda");
        i--;
    }
        
    else 
    {
        System.Console.WriteLine("No has triat una opció vàlida, es repetirá la ronda " + i);
        i--;
    }
 
    System.Console.WriteLine("");

}   
    if (contador1 > contador2) System.Console.WriteLine("Has guanyat la partida");
    else if (contador1 > contador1) System.Console.WriteLine("Has perdut la partida");
    else System.Console.WriteLine("Has empatat la partida");
