// if (6 >= 3)
// {
//     Console.WriteLine("Hello world");
//     Console.ReadLine();
// }


// Console.WriteLine("Skriv ditt användarnamn");
// string namn = Console.ReadLine();
// Console.WriteLine("Skriv ditt lösenord");
//string password = Console.ReadLine();

// if (namn == "kalleanka" && password == "12345")
// {
//     Console.WriteLine("Welcome!");
// }

// else
// {
//     Console.WriteLine("Wrong username or password");
// }
// Console.ReadLine();

// int i = 0;
// while (i < 32)
// {
//     Console.WriteLine("Hello world");
//     i++;
// }
// Console.ReadLine();

// string password = Console.ReadLine();

// while (password != "12345")
// {
//     Console.WriteLine("Skriv lösenordet");
//     password = Console.ReadLine();
// }


// for (int i = 0; i < 5; i++)
// {
//     Console.Write("Skriv in ett tal: ");
//     int tal = int.Parse(Console.ReadLine());

//     if (tal > 5)
//     {
//         Console.WriteLine("Högre än 5!");
//     }
// }

Console.WriteLine("Eijvans nummer gissning!!!!");
Console.WriteLine("Talet är mellan 1 och 100");

while (true)
{
    string number = Console.ReadLine();
    int result;
    bool lyckad = int.TryParse(number, out result);

    if (result == 7)
    {
        Console.WriteLine("Grattis, det är rätt!");
        break;
    }
    if (result < 7 && lyckad == true)
    {
        Console.WriteLine("Lite högre");
    }
    if (result > 7 && lyckad == true)
    {
        Console.WriteLine("Lite mindre");
    }
    if (lyckad == false)
    {
        Console.WriteLine("Du skrev inget heltal");
    }
}

Console.ReadLine();

