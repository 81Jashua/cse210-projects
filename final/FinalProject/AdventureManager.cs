using System.Diagnostics;

public class AdventureManager
{
    private Character _character;
    private Adventure _adventure = new Adventure();
    private List<Monster> _monsters = new List<Monster>();
    public void Run()
    {
        Console.WriteLine("-------======= Welcome to Adventure Quest! =======-------\n");
        ChooseCharacter();
        ChooseCharacterStats();
        ShowSpinner(3);
        _character.GetCharacterDetails();

        ChooseAdventure();
        RunScenarios(_adventure.GetName());

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
    public void RunScenarios(string adventure)
    {
        AddMonstersToList(_adventure.GetName());
        Scenario(adventure);
        
    }
    public void Scenario(string adventure)
    {
        switch(adventure)
        {
            case "The Abandoned Castle":
            {
                GetCastleEncounter();
                break;
            }
        }
    }


    public string GetCastleEncounter()
    {
        int difficulty = 1;
        while(difficulty < 4)
        {         
            switch(difficulty)
            {
                case 1:
                {
                    Console.WriteLine("Scenario 1:");
                    Console.WriteLine(@"You decide to take the road. While traveling on the road you see an abandonded wagon.
                    What do you do? type 'search' to search or 'ignore' to ignore");
                    string descision = Console.ReadLine();
                    if (descision == "search")
                    {
                        Console.WriteLine("You've decided to search:");
                        Console.WriteLine("Roll the dice do see what happens: Type 'roll'");
                        string response = Console.ReadLine();
                        if(response == "roll")
                        {
                            int numberRolled = RollDice();
                            if ((numberRolled + _character.GetIntelligence()) >= 12)
                            {
                                ShowSpinner(3);
                                Console.WriteLine($"Your intelligence: {_character.GetIntelligence()} + your roll: {numberRolled} is greater than 5!");
                                Console.WriteLine(@"You spot a small pack of goblins. You wrap some torn sheets over yourself and howl like a Ghost.
                                                    Spooked the goblins run off");
                                difficulty ++;
                                break;
                            }
                            else 
                            {
                                ShowSpinner(3);
                                Console.WriteLine($"Your intelligence: {_character.GetIntelligence()} + your roll: {numberRolled} is less than 5!");
                                Console.WriteLine("While searching you knock over a tin can making too much noise. You are surprised attacked!");
                                //Monster monster = MonsterEncounter("Goblin");
                                MonsterEncounter("Goblin");
                                //monster.GetMonsterDetails();
                                //Battle(false, monster);

                                difficulty ++;
                            }
                        }           

                    }
                    else
                    {

                    }
                    break;
                }
                case 2:
                {
                    break;
                }
            }
        }
        return "";        
    }
    public void MonsterEncounter(string monsterType)
    {
        foreach(Monster monster in _monsters)
        {
            if(monster.GetName() == monsterType)
            {
                Console.Clear();
                _character.GetCharacterDetails();
                monster.GetMonsterDetails();
                Console.WriteLine("The Goblin surprised attacked he goes first.");
                Battle(false, monster);
                ShowSpinner(3);
            }
        }
    }
    // public Monster MonsterEncounter(string monsterType)
    // {
    //     Monster myMonster = new Monster("bla", "bla", 3, 3);
    //     foreach(Monster monster in _monsters)
    //     {
    //         if(monster.GetName() == monsterType)
    //         {
    //             myMonster = monster;
    //         }
    //     }
    //     return myMonster;
    // }
    public void AddMonstersToList(string adventure)
    {
        switch(adventure)
        {
            case "The Abandoned Castle":
            {
                Monster monsterOne = new Monster("Goblin", "Small but dangerous", 12, 2);
                Monster monsterTwo = new Monster("Orc", "Large and very strong", 7, 5);
                //Monster monsterBoss = new Monster("Goblin", "Small but dangerous", 3, 2);
                _monsters.Add(monsterOne);
                _monsters.Add(monsterTwo);
                break;
            } 
        }
    }
    public void Battle(bool priority, Monster monster)
    {
        if(_character.CheckHealth() == false)
        {
            Console.WriteLine("Your Character lost all their lives. You must restart the quest");
            return;            
        }
        if(monster.CheckHealth() == false)
        {
            Console.WriteLine($"You defeated the {monster.GetName} Congradulations");
            return;
        }
        while((_character.GetHealth() > 0) && monster.GetHealth() > 0)
        {
            if(priority == true)
            {
                Console.WriteLine("Your hero attacks: type 'roll' to roll the dice");
                int diceResult = int.Parse(Console.ReadLine());
                Console.WriteLine($"You rolled a: {diceResult} + Your strength and weapon {_character.Attack(diceResult)}!!!");
                monster.SetHealth(_character.Attack(diceResult));
                ShowSpinner(3);
                Console.Clear();
                _character.GetCharacterDetails();
                monster.GetMonsterDetails();
                
                if(monster.CheckHealth() == false)
                {
                    Console.WriteLine($"You defeated the {monster.GetName} Congradulations");
                    ShowSpinner(3);
                    return;
                }
                else
                {
                    Console.WriteLine($"Although hurt the {monster.GetName()} attacks back");
                    Console.WriteLine($"The {monster}'s attack is {monster.GetAttack()}");
                    _character.RemoveHealth(monster.GetAttack());
                }
            }
            else
            {
                Console.WriteLine($"The {monster.GetName()} attacks");
                Console.WriteLine($"The {monster}'s attack is {monster.GetAttack()}");
                _character.RemoveHealth(monster.GetAttack());
                Console.Clear();
                _character.GetCharacterDetails();
                monster.GetMonsterDetails();
                if(_character.CheckHealth() == false)
                {
                    Console.WriteLine("You have been defeated. You must start over");
                    ShowSpinner(3);
                    return;
                }
            }
        }
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