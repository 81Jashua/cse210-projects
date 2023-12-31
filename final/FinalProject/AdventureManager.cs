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
        Console.WriteLine("Roll for Health type, 'roll':");
        string response = Console.ReadLine();
        while(response == "roll")
        {
            int numberRolled = RollDice();
            _character.SetHealth(numberRolled);
            Console.WriteLine($"You rolled a {numberRolled}. Your Health is {_character.GetHealth()}");
            break;
        }
        Console.WriteLine("Roll for Strength, type 'roll':");
        response = Console.ReadLine();
        while(response == "roll")
        {
            int numberRolled = RollDice();
            _character.SetStrength(numberRolled);
            Console.WriteLine($"You rolled a {numberRolled}. Your Strength is {_character.GetStrength()}");
            break;
        }
        Console.WriteLine("Roll for Intelligence, type 'roll':");
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
                            if ((numberRolled + _character.GetIntelligence()) >= 15)
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
                                Console.WriteLine($"Your intelligence: {_character.GetIntelligence()} + your roll: {numberRolled} is less than 5!");
                                Console.WriteLine("While searching you knock over a tin can making too much noise. You are surprised attacked!");
                                ShowSpinner(3);
                                MonsterEncounter("Goblin", false);
                                difficulty ++;
                            }
                        }           

                    }
                    else
                    {
                        Console.WriteLine($"You've decided to {descision}:");
                        Console.WriteLine("Roll the dice do see what happens: Type 'roll'");
                        string response = Console.ReadLine();
                        if(response == "roll")
                        {
                            int numberRolled = RollDice();
                            if ((numberRolled + _character.GetIntelligence()) >= 15)
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
                                Console.WriteLine($"Your intelligence: {_character.GetIntelligence()} + your roll: {numberRolled} is less than 5!");
                                Console.WriteLine("While searching you knock over a tin can making too much noise. You are surprised attacked!");
                                ShowSpinner(3);
                                MonsterEncounter("Goblin", false);
                                difficulty ++;
                            }
                        }          
                    }
                    break;
                }
                case 2:
                {
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("Scenario 2:\n");
                    Console.WriteLine(@"You check your weapon and brush off some dirt and continue down the road.
Next to a small outpost you notice an Ork sleeping. Do you charge the Ork or try to avoid him? 
Type 'attack' to attack or 'avoid' to avoid");
                    string descision = Console.ReadLine();
                    if (descision == "attack")
                    {
                        Console.WriteLine($"You've decided to {descision}:");
                        Console.WriteLine("\nRoll the dice do see what happens: Type 'roll'");
                        string response = Console.ReadLine();
                        if(response == "roll")
                        {
                            int numberRolled = RollDice();
                            if ((numberRolled + _character.GetStrength()) >= 10)
                            {
                                Console.WriteLine($"Your Strength: {_character.GetStrength()} + your roll: {numberRolled} is greater than 9!");
                                Console.WriteLine(@"You charge head on and stab the Ork before he can even react.");
                                ShowSpinner(8);
                                difficulty ++;
                                break;
                            }
                            else 
                            {
                                Console.WriteLine($"Your Strength: {_character.GetStrength()} + your roll: {numberRolled} is less than 11!");
                                Console.WriteLine("While charging you trip on a rock. Although unharmed you wake the Ork. Prepare for battle!");
                                ShowSpinner(8);
                                MonsterEncounter("Ork", true);
                                difficulty ++;
                            }
                        }
                        break;           

                    }
                    else
                    {
                        Console.WriteLine($"You've decided to {descision}:");
                        Console.WriteLine("Roll the dice do see what happens: Type 'roll'");
                        string response = Console.ReadLine();
                        if(response == "roll")
                        {
                            int numberRolled = RollDice();
                            if ((numberRolled + _character.GetIntelligence()) >= 12)
                            {
                                Console.WriteLine($"Your intelligence: {_character.GetIntelligence()} + your roll: {numberRolled} is greater than 11!");
                                Console.WriteLine(@"While sneak through the side you see a rope holding heavy box just above the Orc.
You cut the rope and the box falls ontop of the Ork, putting him out of commission");
                                ShowSpinner(8);
                                difficulty ++;
                                break;
                            }
                            else 
                            {
                                Console.WriteLine($"Your intelligence: {_character.GetIntelligence()} + your roll: {numberRolled} is less than 12!");
                                Console.WriteLine("While sneaking carefully you get to close and the Ork smells you. He gets up ready to battle!");
                                ShowSpinner(3);
                                MonsterEncounter("Ork", true);
                                difficulty ++;
                            }
                        }          
                    }
                    break;
                }
                case 3:
                {
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("Scenario 3:\n");
                    Console.WriteLine(@"In the distance you spot the castle. As you approach the castle you notice break in the wall
You squeeze through only to find a large mountain troll in the foyer. This must have been what caused all the trouble.
The Troll bellows a large roar. You prepare for the fight of your life.
What do you do? Type 'search' to search, 'attack' to attack, ");
                    string descision = Console.ReadLine();
                    if (descision == "attack")
                    {
                        Console.WriteLine($"You've decided to {descision}:");
                        Console.WriteLine("Roll the dice do see what happens: Type 'roll'");
                        string response = Console.ReadLine();
                        if(response == "roll")
                        {
                            int numberRolled = RollDice();
                            if ((numberRolled + _character.GetStrength()) >= 15)
                            {
                                Console.WriteLine($"Your Strength: {_character.GetStrength()} + your roll: {numberRolled} is greater than 14!");
                                Console.WriteLine(@"Your courage catches the toll off guard. You get first attack");
                                ShowSpinner(8);
                                MonsterEncounter("Troll", true);
                                difficulty ++;
                                break;
                            }
                            else 
                            {
                                Console.WriteLine($"Your Strength: {_character.GetStrength()} + your roll: {numberRolled} is less than 15!");
                                Console.WriteLine("Your bravery does not phase the troll. He takes a large swing with his club.");
                                ShowSpinner(8);
                                MonsterEncounter("Troll", false);
                                difficulty ++;
                            }
                        }
                        break;           

                    }
                    else
                    {
                        Console.WriteLine($"You've decided to {descision}:");
                        Console.WriteLine("Roll the dice do see what happens: Type 'roll'");
                        string response = Console.ReadLine();
                        if(response == "roll")
                        {
                            int numberRolled = RollDice();
                            if ((numberRolled + _character.GetIntelligence()) >= 15)
                            {
                                Console.WriteLine($"Your intelligence: {_character.GetIntelligence()} + your roll: {numberRolled} is greater than 14!");
                                Console.WriteLine(@"You notice a weakened arch. You encourage the troll to go under the arch. The troll Swings his club
                                towards. You dodge the club and it smashes into the wall. The vibration is enough for the arch to fall on the Troll crushing it");
                                ShowSpinner(8);
                                difficulty ++;
                                break;
                            }
                            else 
                            {
                                Console.WriteLine($"Your intelligence: {_character.GetIntelligence()} + your roll: {numberRolled} is less than 12!");
                                Console.WriteLine("You try to find a weakness but the troll gets too close to quickly. Prepare to battle!");
                                ShowSpinner(3);
                                MonsterEncounter("Troll", true);
                                difficulty ++;
                            }
                        }          
                    }
                    break;
                }
            }
        }
        EndMessage();
        return "";        
    }
    public void MonsterEncounter(string monsterType, bool testResult)
    {
        foreach(Monster monster in _monsters)
        {
            if(monster.GetName() == monsterType)
            {
                Console.Clear();
                _character.GetCharacterDetails();
                monster.GetMonsterDetails();
                Console.WriteLine($"You failed your test. The {monster.GetName()} goes first.");
                Battle(testResult, monster);
                ShowSpinner(5);
            }
        }
    }    
    public void AddMonstersToList(string adventure)
    {
        switch(adventure)
        {
            case "The Abandoned Castle":
            {
                Monster monsterOne = new Monster("Goblin", "Small but dangerous", 5, 2);
                Monster monsterTwo = new Monster("Ork", "Large and very strong", 10, 5);
                Boss monsterThree = new Boss("Troll", "Small but dangerous", 20, 5);
                _monsters.Add(monsterOne);
                _monsters.Add(monsterTwo);
                _monsters.Add(monsterThree);
                break;
            } 
        }
    }
    public void Battle(bool priority, Monster monster)
    {
        while((_character.GetHealth() > 0) && monster.GetHealth() > 0)
        {
            if(priority == true)
            {
                Console.WriteLine("Your hero attacks: type 'roll' to roll the dice");
                if (Console.ReadLine() == "roll")
                {
                    int diceResult = RollDice();
                    Console.WriteLine($"You rolled a: {diceResult} + Your strength and weapon {_character.Attack(diceResult)}!!!");
                    monster.SetHealth(_character.Attack(diceResult));
                    ShowSpinner(8);
                    Console.Clear();
                    _character.GetCharacterDetails();
                    monster.GetMonsterDetails();
                    
                    if(monster.CheckHealth() == false)
                    {
                        Console.WriteLine($"You defeated the {monster.GetName()} Congradulations");
                        ShowSpinner(8);
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Although hurt the {monster.GetName()} attacks back");
                        Console.WriteLine($"The {monster}'s attack is {monster.GetAttack()}");
                        _character.RemoveHealth(monster.GetAttack());
                        ShowSpinner(12);
                    }
                }
            }
            else
            {
                Console.WriteLine($"The {monster.GetName()} attacks");
                Console.WriteLine($"The {monster}'s attack is {monster.GetAttack()}");
                _character.RemoveHealth(monster.GetAttack());
                ShowSpinner(12);
                Console.Clear();
                _character.GetCharacterDetails();
                monster.GetMonsterDetails();
                if(_character.CheckHealth() == false)
                {
                    Console.WriteLine("You have been defeated. You must start over");
                    ShowSpinner(6);
                    return;
                }    
                else
                {
                    Console.WriteLine("Your hero attacks: type 'roll' to roll the dice");
                    if(Console.ReadLine() == "roll")
                    {
                        int diceResult = RollDice();
                        Console.WriteLine($"You rolled a: {diceResult} + Your strength and weapon {_character.Attack(diceResult)}!!!");
                        monster.SetHealth(_character.Attack(diceResult));
                        ShowSpinner(12);
                        Console.Clear();
                        _character.GetCharacterDetails();
                        monster.GetMonsterDetails();
                    }
                }
            }
            if(_character.CheckHealth() == false)
            {
                Console.WriteLine("Your Character lost all their lives. You must restart the quest");
                return;            
            }
            if(monster.CheckHealth() == false)
            {
                Console.WriteLine($"You defeated the {monster.GetName()} Congradulations");
                return;
            }
        }
    }
    public void EndMessage()
    {
        if(_character.CheckHealth())
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("=========================================================");
            Console.WriteLine("================You Saved the Castle=====================");
            Console.WriteLine("==     The Towns people sing songs in your praise      ==");
            Console.WriteLine("==     and petition your professor to give you an A    ==");
            Console.WriteLine("==     Because this took way to long to get to this    ==");
            Console.WriteLine("==     point in this project                           ==");
            Console.WriteLine("=========================================================");
            Console.WriteLine("=========================================================");
        }
        else
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("==  You lost all of your lives Better luck next time   ==");
            Console.WriteLine("=========================================================");
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