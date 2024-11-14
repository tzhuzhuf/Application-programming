public class Player
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Player(int startX, int startY)
    {
        X = startX;
        Y = startY;
    }

    // Логика обработки ввода
    public void HandleInput(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
                Y--;
                break;
            case ConsoleKey.DownArrow:
                Y++;
                break;
            case ConsoleKey.LeftArrow:
                X--;
                break;
            case ConsoleKey.RightArrow:
                X++;
                break;
        }
    }
}