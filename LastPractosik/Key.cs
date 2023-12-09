namespace LastPractosik;

public class Key
{
    public static int CheckPos(int min, int max)
    {
        int position = min;
        ConsoleKeyInfo key;
        while (true)
        {
            Console.SetCursorPosition(0, position);
            Console.Write("->");
            Console.SetCursorPosition(0, 0);
            key = Console.ReadKey();
            Console.SetCursorPosition(0, position);
            Console.Write("  ");
            if (key.Key == ConsoleKey.UpArrow && position > min)
            {
                position--;
            }
            if (key.Key == ConsoleKey.DownArrow && position < max)
            {
                position++;
            }
            if (key.Key == ConsoleKey.Enter)
            {
                return position;
            }
            if (key.Key == ConsoleKey.F1)
            {
                return -1;
            }
            if (key.Key == ConsoleKey.F2)
            {
                return -2;
            }
            if (key.Key == ConsoleKey.S)
            {
                return -5;
            }
            if (key.Key == ConsoleKey.Escape)
            {
                return -10;
            }
            if (key.Key == ConsoleKey.Delete)
            {
                return -15;
            }
        }
    }
}
