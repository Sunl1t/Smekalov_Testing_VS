using System;


public class Program
{
    public static void InputFirstSymbol()
    {
        Console.Write("Ââåäèòå ïåðâûé ñèìâîë: ");
        ch1 = Console.ReadKey().KeyChar;
        Console.WriteLine();
    }

    public static void InputSecondSymbol()
    {
        Console.Write("Ââåäèòå âòîðîé ñèìâîë: ");
        ch2 = Console.ReadKey().KeyChar;
        Console.WriteLine();
    }

    public static void PrintSymbolsAndAsciiCodes()
    {
        Console.WriteLine("Ñèìâîë " + ch1 + " èìååò êîä ASCII " + (int)ch1);
        Console.WriteLine("Ñèìâîë " + ch2 + " èìååò êîä ASCII " + (int)ch2);
    }

    public static void PrintSumOfAsciiCodes()
    {
        int sum = (int)ch1 + (int)ch2;
        Console.WriteLine("Ñóììà êîäîâ ASCII ñèìâîëîâ " + ch1 + " è " + ch2 + " ðàâíà " + sum);
    }

    public static char ch1 = ' '; // ïåðåìåííàÿ äëÿ õðàíåíèÿ ïåðâîãî ñèìâîëà
    public static char ch2 = ' '; // ïåðåìåííàÿ äëÿ õðàíåíèÿ âòîðîãî ñèìâîëà

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Ìåíþ âûáîðà:");
            Console.WriteLine("1. Ââåñòè ïåðâûé ñèìâîë");
            Console.WriteLine("2. Ââåñòè âòîðîé ñèìâîë");
            Console.WriteLine("3. Âûâåñòè êàæäûé ñèìâîë è åãî êîä ASCII");
            Console.WriteLine("4. Âûâåñòè ñóììó êîäîâ ASCII ñèìâîëîâ ch1 è ch2");
            Console.WriteLine("0. Âûéòè");

            Console.Write("Âûáåðèòå ïóíêò ìåíþ: ");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    return; // âûõîä èç ïðîãðàììû
                case 1:
                    InputFirstSymbol();
                    break;
                case 2:
                    InputSecondSymbol();
                    break;
                case 3:
                    PrintSymbolsAndAsciiCodes();
                    break;
            case 4:
                    PrintSumOfAsciiCodes();
                    break;
                default:
                    Console.WriteLine("Íåêîððåêòíûé âûáîð. Ïîïðîáóéòå ñíîâà.");
                    break;
            }
        }
    }
}
