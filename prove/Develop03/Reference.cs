using System;
using System.Collections.Generic;
using System.Dynamic;

public class Reference{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;
    public string book => _book;
    public int chapter => _chapter;
    public int startVerse => _startVerse;
    public int? endVerse => _endVerse;

    public Reference(string book, int chapter, int startVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        return _endVerse.HasValue
            ? $"{book} {chapter}:{startVerse} - {endVerse}"
            : $"{book} {chapter}:{startVerse}";
    }

}