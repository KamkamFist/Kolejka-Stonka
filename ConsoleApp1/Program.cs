Console.WriteLine("Herzlich Wilkommen! stonka");

int klienci = 0;

string[] imie = new string[5] {"Marek", "Anna", "Kajetan", "xd", "lol" };

string[] kolejka = new string[5];




while (true)
{
    var rand = new Random().Next(5);
    Console.WriteLine("Przyszedł nowy klient! Co robisz (dodaj do kolejki[+]/kick[-])");

    klienci++;

    string decyzjaKlient = Console.ReadLine();

    if (decyzjaKlient == "+")
    {
        kolejka[klienci] = imie[rand];
        Console.WriteLine("Bierząca kolejka: ");
        for (int i = 0; i < kolejka.Length; i++)
        {
            Console.WriteLine(kolejka[i]);
        }

       

    }
    else if (decyzjaKlient == "-")
    {
        Console.WriteLine("Klient zostal zgladzony");
    }
    else
    {
        Console.WriteLine("Nieprawidłowa decyzja!");
    }
}
