public class Warrior : Character
{
    public Warrior(string type, string name, int health = 5, int strength = 5, int intelligence = 2) : base(type, name, health, strength, intelligence)
    {
    }
    public override string SpecialAbility()
    {
        throw new NotImplementedException();
    }
}