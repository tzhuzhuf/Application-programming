public class Level
{
    private char[,] layout;
    public List<Enemy> Enemies { get; private set; }
    public int ExitX { get; private set; }
    public int ExitY { get; private set; }

    public Level(Player player, char[,] layout)
    {
        this.layout = layout;

        // Инициализация врагов
        Enemies = new List<Enemy>
        {
            new Enemy(2, 2, player, layout),
            new Enemy(5, 6, player, layout)
        };

        // Устанавливаем выход на уровень
        ExitX = 9;
        ExitY = 8;
    }

    public void Render()
    {
        for (int i = 0; i < layout.GetLength(0); i++)
        {
            for (int j = 0; j < layout.GetLength(1); j++)
            {
                Console.SetCursorPosition(j, i);
                Console.Write(layout[i, j]);
            }
        }

        // Рендерим врагов
        foreach (var enemy in Enemies)
        {
            enemy.Render();
        }

        // Рендерим выход
        Console.SetCursorPosition(ExitX, ExitY);
        Console.Write("E");
    }

    public void Update()
    {
        // Враги двигаются после того, как игрок сделал ход
        foreach (var enemy in Enemies)
        {
            enemy.Update();
        }
    }
}