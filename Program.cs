static void Main()
{

    Console.WriteLine("Hello!!!");
    Console.WriteLine("Hello!");
    Console.WriteLine("Hello!");
    Console.WriteLine("Hello!");
    Console.WriteLine("tjena!");

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
    Thread.Sleep(50);

    if (namn == "Ruhollah" || namn == "Karim")
    {
        // Ruhollah Karim
        alder = 20;
        Console.WriteLine($"Välkommen {namn}! ");
        Console.WriteLine($"Ock ni år {alder} gammal ");

    }

    if (namn == "Oscar" || namn == "Svahn")
    {
        alder = 22;
        Console.WriteLine($"Välkommen {namn}! ");
        Console.WriteLine($"Ock ni år {alder} gammal ");

    }
    //test
}