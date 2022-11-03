using System;
namespace Domain;

public class Homework
{
    public string Id { get; set; }
    public string Description { get; set; }
    public DateTime DueDate  { get; set; }
    public int Score { get; set; }
    public int Rating { get; set; }
    public List<Exercise> exercises { get; set; }
}