public abstract class Character
{
    private string _type;
    private string _name;
    private string _description;
    private int _health;
    private int _strength;
    private int _intellegence;

    public Character(string type, string name, string description)
    {
        _type = type;
        _name = name;
        _description = description;
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
        _health = health;
    }
    public void SetStrength(int strength)
    {
        _strength = strength;
    }
    public void SetIntelligence(int intelligence)
    {
        _intellegence = intelligence;
    }
}