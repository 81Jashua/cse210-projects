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
}