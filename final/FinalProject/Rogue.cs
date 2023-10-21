public class Rogue : Character
{
    public Rogue(string type, string name, string description) : base(type, name, description)
    {
    }

    public override string SpecialAbility()
    {
        throw new NotImplementedException();
    }
}