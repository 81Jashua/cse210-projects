public class Monster
{
    private string _name;
    private string _description;
    private int _health;
    private int _attack;

    public Monster(string name, string description, int health, int attack)
    {
        _name = name;
        _description = description;
        _health = health;
        _attack = attack;
    }

    public int GetHealth()
    {
        return _health;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetAttack()
    {
        return _attack;
    }
    public void SetHealth(int attacked)
    {
        _health -= attacked;
    }
    public void GetMonsterDetails()
    {
        Console.WriteLine($"                                --xxxXXXXX Monster: {GetName()} XXXXXxxx-- ");
        Console.WriteLine($"                                  Description: ---- {GetDescription()}");
        Console.WriteLine($"                                  Health: --------- {DisplayHealth(GetHealth())}");
        Console.WriteLine($"                                  Attack: --------- {GetAttack()}\n");
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
    public bool CheckHealth()
    {
        if(GetHealth() > 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}