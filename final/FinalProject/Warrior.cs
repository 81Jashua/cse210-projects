public class Warrior : Character
{
    public Warrior(string type, string name, int health = 5) : base(type, name, health)
    {
    }
    public override string SpecialAbility()
    {
        throw new NotImplementedException();
    }
}