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
            Word wordFromTxt = new(word);
            _words.Add(wordFromTxt);
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
                string newWord = word.GetDisplayText();
                string hiddenWord = "";
                int wordLength = newWord.Length;
                for (int i = 1; i < wordLength; i++) 
                { 
                    hiddenWord += "-";
                }
                builder.Append($"{hiddenWord} ");
            }
            else 
            {
                builder.Append(word.GetDisplayText());
            }
        }
        string scripture = builder.ToString();
        return scripture;
    }

    ///Temp code
    public void PopulateList(List<int> list)
    {
        int wordCount = getWords();
        for (int i = 0; i < wordCount; i++)
        {
            list.Add(i);                
        }        
    }

    public int ReturnRandomNumber(List<int> list)
    {
        Random random = new Random();
        int tempCount = list.Count();
        int randomNum = random.Next(tempCount);
        int randomListIndexNum = list[randomNum];
        list.RemoveAt(randomNum);
        return randomListIndexNum;        
    }

    public void RevealAllScriptures()
    {
        foreach(Word word in _words)
        {
            word.Show();
        }
    }
}