public class Scripture
{
    Reference _reference;
    List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (char word in text.ToArray())
        {
            Word foo = new(word.ToString());
            _words.Add(foo);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        
    }
}