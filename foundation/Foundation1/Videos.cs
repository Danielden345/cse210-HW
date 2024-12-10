using System;
using System.Collections.Generic;

public class Video
{
    public string Author { get; private set; }
    public string Title { get; private set; }
    public int Length { get; private set; }  // Use Length instead of _seconds for clarity
    private List<Comment> _comments;

    public Video(string author, string title, int seconds)
    {
        // Validate title
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("Title cannot be null or empty.", nameof(title));
        }

        // Validate author
        if (string.IsNullOrWhiteSpace(author))
        {
            throw new ArgumentException("Author cannot be null or empty.", nameof(author));
        }

        // Validate seconds
        if (seconds <= 0)
        {
            throw new ArgumentException("Length must be a positive number.", nameof(seconds));
        }

        // Assign properties
        Author = author;
        Title = title;
        Length = seconds;

        // Initialize comments
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        if (comment == null)
        {
            throw new ArgumentNullException(nameof(comment), "Comment cannot be null.");
        }
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        // Return a copy of the list to maintain encapsulation
        return new List<Comment>(_comments);
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Length: {Length} seconds";
    }
}
