// See https://aka.ms/new-console-template for more information

using ConsoleGame;

bool run = false;
string playerInput;

Console.WriteLine("Welcome, prepare to get rekt.");

Player player1 = new Player("Hessel", 100, 10);
Enemy enemy1 = new Enemy("enemy1", 50, 5);



while (!run)
{
    playerInput = Console.ReadLine();
    Console.Clear();



    if (playerInput == "attack")
    {
        enemy1.SetHealth(player1.GetDamage());
        player1.SetHealth(enemy1.GetDamage());

        Console.WriteLine("Health: " + player1.GetHealth() + "                                      enemy: " + enemy1.GetName());
        Console.WriteLine("Flasks: 5" +                     "                                       health: " + enemy1.GetHealth());
        Console.WriteLine("Level: 1" +                     "                                        damage: " + enemy1.GetDamage());
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("you attacked, dealing " + player1.GetDamage() + " damage to " + enemy1.GetName());

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(enemy1.GetName() + " attacked, dealing " + enemy1.GetDamage() + " damage to you");

        Console.ResetColor();
    }

    if (enemy1.GetHealth() <= 0)
    {
        string deadEnemy = enemy1.GetName();

        enemy1 = new Enemy("enemy2", 50, 5);

        Console.Clear();

        Console.WriteLine("Health: " + player1.GetHealth() + "                                      enemy: " + enemy1.GetName());
        Console.WriteLine("Flasks: 5" + "                                       health: " + enemy1.GetHealth());
        Console.WriteLine("Level: 1" + "                                        damage: " + enemy1.GetDamage());
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("you attacked, dealing " + player1.GetDamage() + " damage to " + enemy1.GetName());

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(enemy1.GetName() + " attacked, dealing " + enemy1.GetDamage() + " damage to you");

        Console.ResetColor();

        Console.WriteLine(deadEnemy + " died");
    }

    if (player1.GetHealth() <= 0)
    {
        Console.WriteLine("you died");
    }



}


