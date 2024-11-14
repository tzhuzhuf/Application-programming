using System;
using System.Collections.Generic;

public class Game
{
    private Player player;
    private Level level;

    public Game()
    {
        player = new Player(1, 1); // Начальная позиция игрока
        char[,] levelLayout = new char[10, 10] // Пример уровня
        {
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', 'X', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' '},
            {' ', ' ', ' ', 'P', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'E'},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '}
        };

        level = new Level(player, levelLayout);  // Создаем уровень и передаем игрока
    }

    public void Start()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Render();           // Рендерим уровень и игрока
            ProcessInput();     // Обрабатываем ввод игрока
            Update();           // Обновляем состояние игры

            // Проверяем, достиг ли игрок выхода
            if (player.X == level.ExitX && player.Y == level.ExitY)
            {
                Console.Clear();
                Console.WriteLine("You won!");
                isRunning = false;
            }

            // Проверяем, столкнулся ли игрок с врагом
            foreach (var enemy in level.Enemies)
            {
                if (player.X == enemy.X && player.Y == enemy.Y)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over! You were caught by the enemy.");
                    isRunning = false;
                }
            }

            System.Threading.Thread.Sleep(200); // Небольшая задержка для предотвращения излишней загрузки процессора
        }
    }

    private void Render()
    {
        Console.Clear();
        level.Render();  // Рендерим уровень и врагов
        Console.SetCursorPosition(player.X, player.Y);
        Console.Write("P"); // Рендерим игрока
    }

    private void ProcessInput()
    {
        if (Console.KeyAvailable) // Проверяем, был ли нажать ключ
        {
            var key = Console.ReadKey(true).Key;
            player.HandleInput(key);  // Обрабатываем ввод от игрока
        }
    }

    private void Update()
    {
        level.Update();  // Обновляем уровень (в том числе врагов)
    }
}