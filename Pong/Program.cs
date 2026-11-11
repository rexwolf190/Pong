using System.Data;

namespace Pong;

class Program
{
    private static int width = Console.WindowWidth;
    private static int height = Console.WindowHeight - 2;

    private static int ballX = width / 2;
    private static int ballY = height / 2;

    private static int paddleHeight = 5;

    private static int leftPaddleX = 1;
    private static int leftPaddleY = (height - paddleHeight) / 2;

    private static int rightPaddleX = width - 2;
    private static int rightPaddleY = (height - paddleHeight) / 2;

    private static ConsoleKey input;
    
    private static int ballXV = 0;
    private static int ballYV = 1;
    
    private static char[,] grid = new char[width, height];

    static void Main() 
    {
        
        RenderGrid();
        while (true)
        {
            BallMove();
            RobotMove();
            RenderGrid();
        }
    }

    static void RenderGrid()
    {
        
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                grid[x, y] = ' ';
            }
        }

        DrawBall();
        DrawPaddle();

        Console.Clear();

        
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Console.Write(grid[x, y]);
            }

            Console.WriteLine();
        }
    }

    static void DrawBall()
    {
        grid[ballX, ballY] = 'O';
    }

    static void DrawPaddle()
    {
        for (int i = 0; i < paddleHeight; i++)
        {
            grid[leftPaddleX, leftPaddleY + i] = '|';
            grid[rightPaddleX, rightPaddleY + i] = '|';
        }
    }

    static void GetInput()
    {
        
        
        if (Console.KeyAvailable)
        {
            input = Console.ReadKey().Key;
        }
        
        

        switch (input)
        {
            case ConsoleKey.W:
                if (leftPaddleY > 0)
                    leftPaddleY--;
                break;

            case ConsoleKey.S:
                if (leftPaddleY < height - paddleHeight)
                    leftPaddleY++;
                break;
                    
        }
    }

    static void BallMove()
    {
       ballY += ballYV;

       if (ballY <= 1 || ballY >= height - 1)
       {
           ballYV = -ballYV;
       }
    }
    readonly record struct InputState(int leftPaddleDir, int rightPaddleDir);

    static void RobotMove()
    {
        
            int paddleCenter = rightPaddleY + paddleHeight / 2;

            if (paddleCenter < ballY && rightPaddleY < height - paddleHeight)
            {
                rightPaddleY++;
            }
            else if (paddleCenter > ballY && rightPaddleY > 0)
            {
                rightPaddleY--;
            }
        
    }

    InputState GetInputState()
    {
        
    }

    static void Update(InputState input, TimeSpan elapsed)
    {
        
    }
    
}