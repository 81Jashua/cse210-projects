public class Wizard : Character
{
    private int _mana;
    public Wizard(string type, string name, string description) : base(type, name, description)
    {
    }

    public override string SpecialAbility()
    {
        throw new NotImplementedException();
    }

    public void SetMana(int mana)
    {
        _mana = mana;
    }
}