public class Books
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }

    public void GetData(string title, string author, int year)
    {
        Title = title;
        Author = author;
        PublicationYear = year;
    }
}