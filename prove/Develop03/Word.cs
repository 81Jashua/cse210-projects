public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }
    public void SetWord(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return $"{_text} ";
    }

    public bool testBool()
    {
        return _isHidden;
    }
}