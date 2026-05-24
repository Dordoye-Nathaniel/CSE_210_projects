using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    Random rand = new Random();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach(string wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numbertoHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numbertoHide && _words.Any(w => !w.IsHidden()))
        {
            int index = rand.Next(_words.Count());
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {wordsText}"; 
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}