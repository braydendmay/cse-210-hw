using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Entry {
    
    public DateTime _date {get; set;}
    public string _promptText {get; set;}
    public string _entryText {get; set;}

    public Entry(string prompt, string reply)
    {
        _promptText = prompt;
        _entryText = reply;
        _date = DateTime.Now; 
    }

    public override string ToString()
    {
        return $"{_date} {_promptText} {_entryText}";
    }
}
