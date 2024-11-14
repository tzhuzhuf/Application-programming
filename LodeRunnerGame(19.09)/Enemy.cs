public class Enemy
{
    public int X { get; private set; }
    public int Y { get; private set; }
    private Player player;
    private char[,] levelLayout;

    public Enemy(int x, int y, Player player, char[,] levelLayout)
    {
        X = x;
        Y = y;
        this.player = player;
        this.levelLayout = levelLayout;
    }

    public void Update()
    {
        // Враги двигаются к игроку, но не переходят через стены
        if (X < player.X && CanMoveTo(X + 1, Y))
        {
            X++; // Двигаемся вправо
        }
        else if (X > player.X && CanMoveTo(X - 1, Y))
        {
            X--; // Двигаемся влево
        }

        // Движение врага по оси Y
        if (Y < player.Y && CanMoveTo(X, Y + 1))
        {
            Y++; // Двигаемся вниз
        }
        else if (Y > player.Y && CanMoveTo(X, Y - 1))
        {
            Y--; // Двигаемся вверх
        }
    }

    private bool CanMoveTo(int x, int y)
    {
        // Проверка на допустимость клетки
        return x >= 0 && x < levelLayout.GetLength(1) && y >= 0 && y < levelLayout.GetLength(0) && levelLayout[y, x] != 'X';
    }

    public void Render()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write("X");
    }
}