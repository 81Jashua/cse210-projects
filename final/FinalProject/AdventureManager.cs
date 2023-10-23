using System.Diagnostics;

public class AdventureManager
{
    private Character _character;
    private Adventure _adventure = new Adventure();
    public void Run()
    {
        Console.WriteLine("-------======= Welcome to Adventure Quest! =======-------\n");
        ChooseCharacter();
        ChooseCharacterStats();
        ShowSpinner(3);
        _character.GetCharacterDetails();

        ChooseAdventure();
        RunScenarios();

    }

    public void ChooseCharacter()
    {
        Console.WriteLine("Please choose from one of the brave adventurers:");
        Console.WriteLine("  1. Warrior, brave and well rounded: Special 'Defend : Strike'");
        Console.WriteLine("  2. Wizard, master of magic: Special 'Heal : Enferno'");
        Console.WriteLine("  3. Rogue, master of disguise: Special 'Sneak : Critical'");
        int selection = int.Parse(Console.ReadLine());

        CharacterSelection(selection);
    }
    public void CharacterSelection(int selection)
    {
        switch(selection)
        {
            case 1:
            {
                Console.WriteLine("Ready to protect and save:");
                Console.Write("What is your Warrior's name? ");
                string type = "warrior";
                string name = Console.ReadLine();
                Warrior warrior = new Warrior(type, name);
                SetCharacter(warrior);
                break;
            }
            case 2:
            {
                Console.WriteLine("foo:");
                Console.Write("What is your Wizards's name? ");
                string type = "wizard";
                string name = Console.ReadLine();
                Wizard wizard = new Wizard(type, name);
                SetCharacter(wizard);
                break;
            }
            case 3:
            {
                Console.WriteLine("foo:");
                Console.Write("What is your Rogue's name? ");
                string type = "rogue";
                string name = Console.ReadLine();
                Rogue rogue = new Rogue(type, name);
                SetCharacter(rogue);
                break;
            }
        }
    }
    public void ChooseCharacterStats()
    {
        Console.WriteLine("Roll the dice for your character stats:");
        Console.WriteLine("Roll for Health:");
        string response = Console.ReadLine();
        while(response == "roll")
        {
            int numberRolled = RollDice();
            _character.SetHealth(numberRolled);
            Console.WriteLine($"You rolled a {numberRolled}. Your Health is {_character.GetHealth()}");
            break;
        }
        Console.WriteLine("Roll for Strength:");
        response = Console.ReadLine();
        while(response == "roll")
        {
            int numberRolled = RollDice();
            _character.SetStrength(numberRolled);
            Console.WriteLine($"You rolled a {numberRolled}. Your Strength is {_character.GetStrength()}");
            break;
        }
        Console.WriteLine("Roll for Intelligence:");
        response = Console.ReadLine();
        while(response == "roll")
        {
            int numberRolled = RollDice();
            _character.SetIntelligence(numberRolled);
            Console.WriteLine($"You rolled a {numberRolled}. Your Intelligence is {_character.GetIntelligence()}");
            break;
        }
    }
    public void ChooseAdventure()
    {
        Console.WriteLine("Choose an Adventure");
        Console.WriteLine("  1. The Abandoned Castle");
        Console.WriteLine("  2. The Dark Forest");
        Console.WriteLine("  3. The Old Mill");
        int selection = int.Parse(Console.ReadLine());
        _adventure.CreateAdventure(selection);
    }
    public void RunScenarios()
    {
        _adventure.GetScenario();
    }
    public int RollDice()
    {
        Random random = new Random();
        int numberRolled = random.Next(1, 7);  
        return numberRolled;
    }
    public static void ShowSpinner(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character            
            
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b");            
            
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b");
            
            Console.Write("|"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b");
            
        
            seconds -= 1;
        }
        Console.Write("\n");        
    }
    public void SetCharacter(Character character)
    {
        _character = character;
    }


     
}