public class Wizard : Character
{
    private int _mana;
    public Wizard(string type, string name) : base(type, name)
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