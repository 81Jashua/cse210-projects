public abstract class Character
{
    private string _type;
    private string _name;
    private int _health;
    private int _strength;
    private int _intelligence;

    public Character(string type, string name, int health, int strength, int intelligence)
    {
        _type = type;
        _name = name;
        _health = health;
        _strength = strength;
        _intelligence = intelligence;
    }    
    public void Attack()
    {

    }
    public void Search()
    {

    }
    public abstract string SpecialAbility();

    public virtual void GetCharacterDetails()
    {
        Console.Clear();
        Console.WriteLine($"-----===== Class: {GetType()}=====----- ");
        Console.WriteLine($"  Health: ------- {DisplayHealth(GetHealth())}");
        Console.WriteLine($"  Strength: ----- {GetStrength()}");
        Console.WriteLine($"  Intelligence: - {GetIntelligence()}\n");
        //Console.WriteLine('\u2764');
        
        //Console.Write('\u2764'); //℃ character code
        //Console.WriteLine('\U+2764');
        // string status = "[ ]";
        // if (IsComplete() == true)
        // {
        //     status = "[X]";
        // }
        // return $"{status} {GetName()} ({GetDescription()})";
        
    }

    
    public void SetHealth(int health)
    {
        _health += health;
    }
    public void SetStrength(int strength)
    {
        _strength += strength;
    }
    public void SetIntelligence(int intelligence)
    {
        _intelligence += intelligence;
    }
    public string DisplayHealth(int lives)
    {
        string life = "";
        while(lives > 0)
        {
            life +="O";
            lives -= 1;
        }
        return life;
    }
    public string GetType()
    {
        return _type;
    }
    public int GetHealth()
    {
        return _health;
    }
    public int GetStrength()
    {
        return _strength;
    }
    public int GetIntelligence()
    {
        return _intelligence;
    }
}