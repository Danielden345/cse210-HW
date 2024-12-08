using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class Scriptures{
    private readonly Reference _reference;
    private readonly List<Words> _words;
    private static readonly Random _random = new Random();
    public Scriptures(Reference reference, string text)
    {
        if (reference == null) throw new ArgumentNullException(nameof(reference));
        if (string.IsNullOrWhiteSpace(text)) throw new ArgumentNullException("Scripture text cannot be null or empty.", nameof(text));
        _reference = reference;
        _words = new List<Words>();

        foreach(var word in text.Split(' ', StringSplitOptions.RemoveEmptyEntries)){
            _words.Add(new Words(word));
        }

    }
    public void HideRandomWords(int count = 2)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        if (!visibleWords.Any()) return;

        foreach (var word in visibleWords.OrderBy(_ => _random.Next()).Take(count))
        {
            word.Hide();
        }
    }

    public string GetDisplayText(){
        var wordsDisplay = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference} {wordsDisplay}";
    }
    public bool IsCompletelyHidden(){
        return _words.All(word => word.IsHidden());
    }
    
}