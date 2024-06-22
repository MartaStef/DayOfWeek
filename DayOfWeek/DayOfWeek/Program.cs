Console.WriteLine("Witaj w programie DayOfWeek");

while(true)
{
    Console.WriteLine("Podaj liczbę od 1 do 7 aby poznać dzień tygodnia");
    var inputNumber = Console.ReadLine();
    if(inputNumber == "exit")
    { break; }
   
    switch (inputNumber)
    {
        case "1": Console.WriteLine("poniedziałek");
            break;
        case "2": Console.WriteLine("wtorek");
            break;
        case "3": Console.WriteLine("środa");
            break;
        case "4": Console.WriteLine("czwartek");
            break;
        case "5": Console.WriteLine("piątek");
            break;
        case "6": Console.WriteLine("sobota");
            break;
        case "7": Console.WriteLine("niedziela");
            break;
        default: Console.WriteLine("podano nieprawidłową liczbę");
            break;
    }
}