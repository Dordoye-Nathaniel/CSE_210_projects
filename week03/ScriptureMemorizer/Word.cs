using System;

class Word
{
    private string _text;
    private bool _IsHidden;

    public Word(string text)
    {
        _text = text;
        _IsHidden = false;

    }
    public void Hide()
    {
        _IsHidden = true;
    }
    public void Show()
    {
        _IsHidden = false;
    }

    public bool IsHidden()
    {
        return _IsHidden;
    }

    public string GetDisplayText()
    {
        return _IsHidden ? "___" : _text;
    }
}