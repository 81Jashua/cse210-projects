public abstract class Character
{
    private string _type;
    private string _name;
    private int _health;
    private int _strength;
    private int _intellegence;
    private string type;
    private string name;

    public Character(string type, string name, int health)
    {
        _type = type;
        _name = name;
        _health = health;
    }

    protected Character(string type, string name)
    {
        this.type = type;
        this.name = name;
    }

    public void Attack()
    {

    }
    public void Search()
    {

    }
    public abstract string SpecialAbility();

    public virtual string GetCharacterDetails()
    {
        // string status = "[ ]";
        // if (IsComplete() == true)
        // {
        //     status = "[X]";
        // }
        
        // return $"{status} {GetName()} ({GetDescription()})";
        return "";
    }

    
    public void SetHealth(int health)
    {
        _health += health;
    }
    public void SetStrength(int strength)
    {
        _strength = strength;
    }
    public void SetIntelligence(int intelligence)
    {
        _intellegence = intelligence;
    }

    public int GetHealth()
    {
        return _health;
    }
}