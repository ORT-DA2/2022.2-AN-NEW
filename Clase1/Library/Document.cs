namespace Library;

public class Document
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Author { get; set; }	
    public List<PersonDocument>? Personsdocuments { get; set;}
}