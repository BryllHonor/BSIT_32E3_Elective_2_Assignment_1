namespace BSIT_32E3_Elective_2_Assignment_1.Models;

public class QuizQuestion
{
    public int Number { get; set; }
    public string Question { get; set; } = "";
    public List<string> Choices { get; set; } = new();
    public string CorrectAnswer { get; set; } = "";
    public string Explanation { get; set; } = "";
}
