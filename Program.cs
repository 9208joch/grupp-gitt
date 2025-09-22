static void Main()
{
    int alder;
    Console.WriteLine("Vad är erat för eller efternamn?");
    string namn = Console.ReadLine();
    namn = char.ToUpper(namn[0]) + namn.Substring(1).ToLower();


    if (namn == "Joachim" || namn == "Christiansson")
    {
        // joachim christiansson
        
        alder = 33;
        Console.WriteLine($"Välkommen {namn}! ");
        Console.WriteLine($"Ock ni år {alder} gammal ");

    }

    if (namn == "Person2 förnamn" || namn == "Person2 efernamn")
    {
        //alder = Person2 ålder;
        Console.WriteLine($"Välkommen {namn}! ");
        Console.WriteLine($"Ock ni år {alder} gammal ");

    }

    if (namn == "Person3 förnamn" || namn == "Person3 efernamn")
    {
        //alder = Person3 ålder;
        Console.WriteLine($"Välkommen {namn}! ");
        Console.WriteLine($"Ock ni år {alder} gammal ");

    }
}