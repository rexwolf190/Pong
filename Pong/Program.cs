namespace Pong;

class Program()
{
    private static int width = Console.WindowWidth;
    private static int height = Console.WindowHeight - 2;
    
    private static int ballX = width/ 2;
    private static int ballY = height/ 2;
    
    private static int paddleHeight = 5;
    
    private static int leftPaddleX = 1;
    private static int leftPaddleY = (height - paddleHeight) /2 ;
    private static int rightPaddleX = width - 1;
  
    private static int rightPaddleY = (height - paddleHeight) / 2;
    private static char[,] grid = new char[width, height];
    
    static void Main()
    {
      InitializeGrid();
        Console.ReadLine();
    }

    static void InitializeGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                grid[x, y] = 'o';
                Console.Write(grid[x, y]);
            }
        }
        
        DrawBall();
        DrawPaddle();
    }

    static void DrawBall()
    {
        grid[ballX, ballY] = 'O';
        Console.Write(grid[ballX, ballY]);
    }

    static void DrawPaddle()
    {
        for (int i = 0; i < paddleHeight; i++)
        {
            grid [leftPaddleX, leftPaddleY + i] = '|';
            grid [rightPaddleX, rightPaddleY + i] = '|';
            Console.Write(grid[leftPaddleX, leftPaddleY + i]);
            Console.Write(grid[rightPaddleX, rightPaddleY + i]);
        }
    } 
}