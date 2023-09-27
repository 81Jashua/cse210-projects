using System.Text;

public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<string> words = new List<string>(text.Split(' '));
        foreach (var word in words)
        {
            Word foo = new(word);
            _words.Add(foo);
        }        
    }
    public int getWords()
    {
        return _words.Count();
    }

    public void HideRandomWords(int numberToHide)
    {
        _words[numberToHide].Hide();
    }

    public string GetDisplayText()
    {
        var builder = new StringBuilder();
        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                string foo = word.GetDisplayText();
                string tug = "";
                int bar = foo.Length;
                for (int i = 1; i < bar; i++) 
                { 
                    tug += "-";
                }

                word.SetWord(tug);                
                builder.Append(word.GetDisplayText());
            }
            else 
            {
                builder.Append(word.GetDisplayText());
            }
        }
        string scripture = builder.ToString();
        return scripture;
    }
}