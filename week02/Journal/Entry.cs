using System;


public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    // Method to set values
    public void SetEntry(string p, string r, string d)
    {
        _prompt = p;
        _response = r;
        _date = d;
    }

    // Methods to get values
    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetResponse()
    {
        return _response;
    }

    public string GetDate()
    {
        return _date;
    }

    public string Display()
    {
        return $"{_date} | {_prompt} | {_response}";
    }

}
