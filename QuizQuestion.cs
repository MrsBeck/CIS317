/*Asia Beck
* 10-19-2024
* Class representing a quiz question
*/
public class QuizQuestion
{
    // Properties for the question text and possible answer options
    public string QuestionText { get; set; }
    public List<string> PossibleAnswers { get; set; }

    // Constructor to initialize the question text and the possible answers
    public QuizQuestion(string questionText, List<string> possibleAnswers)
    {
        QuestionText = questionText;
        PossibleAnswers = possibleAnswers;
    }

    // This method displays the question and the possible answers
    public void DisplayQuestion()
    {
        Console.WriteLine(QuestionText);
        for (int i = 0; i < PossibleAnswers.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {PossibleAnswers[i]}");
        }
    }

    // This method records the user's response and returns the index of the selected answer
    public int RecordResponse()
    {
        Console.Write("Select your answer (1-3): ");
        int response = Convert.ToInt32(Console.ReadLine());
        return response - 1; // Zero-based index for storing the answer
    }
}