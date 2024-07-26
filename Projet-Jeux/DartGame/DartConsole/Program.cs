using DartGame;

DartBoard game = new DartBoard("501");

Console.WriteLine("Dart Game Console");
int i = 1;
while (true)
{
    DrawBoard();
    Console.WriteLine("Player " + i + "'s turn. Enter cell number of the first dart (0-25):");

    if (!int.TryParse(Console.ReadLine(), out int score))
    {
        Console.WriteLine("Invalid input. Please enter a number between 0 and 25.");
        continue;
    }
    Console.WriteLine("Enter the multiplier of the first dart (1, 2, or 3):");
    if (!int.TryParse(Console.ReadLine(), out int multiplier))
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        continue;
    }
    Console.WriteLine("Enter the cell number of the second dart (0-25):");
    if (!int.TryParse(Console.ReadLine(), out int score2))
    {
        Console.WriteLine("Invalid input. Please enter a number between 0 and 25.");
        continue;
    }
    Console.WriteLine("Enter the multiplier of the second dart (1, 2, or 3):");
    if (!int.TryParse(Console.ReadLine(), out int multiplier2))
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        continue;
    }
    Console.WriteLine("Enter the cell number of the third dart (0-25):");
    if (!int.TryParse(Console.ReadLine(), out int score3))
    {
        Console.WriteLine("Invalid input. Please enter a number between 0 and 25.");
        continue;
    }
    Console.WriteLine("Enter the multiplier of the third dart (1, 2, or 3):");
    if (!int.TryParse(Console.ReadLine(), out int multiplier3))
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        continue;
    }

    try
    {
        Round round = new Round();
        round.Areas.Add(score);
        round.Areas.Add(score2);
        round.Areas.Add(score3);
        round.Multipliers.Add(multiplier);
        round.Multipliers.Add(multiplier2);
        round.Multipliers.Add(multiplier3);

        game.Players[i - 1].PlayATurn(round);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        continue;
    }
    
    if (game.Players[i - 1].Score == 0)
    {
        DrawBoard();
        Console.WriteLine($"Player {i} wins!");
        break;
    }
    if(i==1)
    {
        i = 2;
    }
    else
    {
        i = 1;
    }
}

void DrawBoard()
{
    // Draw the scoreboard of the dart game
    Console.WriteLine("Scoreboard:");
    Console.WriteLine("Player 1: " + game.Players[0].Score);
    Console.WriteLine("Player 2: " + game.Players[1].Score);
    Console.WriteLine();
}