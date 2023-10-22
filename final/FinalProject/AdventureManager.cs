using System.Diagnostics;

public class AdventureManager
{
    private Character _character;
    public void Run()
    {
        Console.WriteLine("-------======= Welcome to Adventure Quest! =======-------");
        ChooseCharacter();
        ChooseCharacterStats();

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
        }
    }
    public void ChooseCharacterStats()
    {
        Console.WriteLine("Roll the dice for your character stats:");
        Console.Write("Roll for Health: ");
        string response = Console.ReadLine();
        while(response == "roll")
        {
            int numberRolled = RollDice();
            _character.SetHealth(numberRolled);
            Console.WriteLine($"You rolled a {numberRolled}. Your Health is {_character.GetHealth()}");
            break;
        }
    }
    public int RollDice()
    {
        Random random = new Random();
        int numberRolled = random.Next(1, 7);  
        return numberRolled;
    }
    public void SetCharacter(Character character)
    {
        _character = character;
    }


     
}