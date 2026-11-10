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

    private static char[,] grid = new char[width, height];

    static void Main()
    {
        RenderGrid();
        Console.ReadLine();
    }

    static void RenderGrid()
    {
        // Clear the grid
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

        // Print the grid
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
}