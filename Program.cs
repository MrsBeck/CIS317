/*Asia Beck
* 10-19-2024
* Main Program
*/
using System;
using System.Collections.Generic;

class Program
{
    // A list to hold the preferences of all users who take the quiz
    private static List<UserPreferences> userPreferencesList = new List<UserPreferences>();

    // A list of predefined show recommendations
    private static List<Recommendation> recommendations = new List<Recommendation>();
    
    static void Main(string[] args)
    {
        // Load recommendations for the users
        LoadRecommendations();
        
        // Simulate a user taking the quiz (user ID = 1)
        int userId = 1; 
        UserPreferences user = new UserPreferences(userId, "Asia Beck");
        
        // Add this user to the list of preferences
        userPreferencesList.Add(user);

        // Process of taking the quiz and storing preferences
        TakeQuiz(user);
        
        // Display show recommendations based on the user's preferences
        DisplayRecommendation(user);
    }

    // This method loads a predefined list of recommendations into the 'recommendations' list
    static void LoadRecommendations()
    {
        recommendations.Add(new Recommendation(1, "Stranger Things", "Sci-Fi", "A group of kids uncover a government conspiracy and a girl with supernatural powers.", "adventure"));
        recommendations.Add(new Recommendation(2, "The Office", "Comedy", "A mockumentary on a group of office employees and their daily lives.", "funny"));
        recommendations.Add(new Recommendation(3, "Breaking Bad", "Drama", "A high school chemistry teacher turned methamphetamine producer.", "intense"));
    }

    // This method shows the quiz to the user and stores their responses
    static void TakeQuiz(UserPreferences user)
    {
        // A list of questions with multiple-choice answers
        var questions = new List<QuizQuestion>
        {
            new QuizQuestion("\nWhat's your current mood?", new List<string> { "Happy", "Sad", "Adventurous", "Relaxed" }),
            new QuizQuestion("\nWhat's your favorite genre?", new List<string> { "Sci-Fi", "Comedy", "Drama", "Action" }),
            new QuizQuestion("\nHow much time do you have to watch a show today?", new List<string> { "20-30 minutes", "1 hour", "A few hours" }),
            new QuizQuestion("\nDo you prefer something lighthearted or thought-provoking?", new List<string> { "Lighthearted", "Thought-provoking" })
        };

        // Loop through each question, display it, and store the user's response
        foreach (var question in questions)
        {
            question.DisplayQuestion();
            int responseIndex = question.RecordResponse();

            // Based on the type of question, store the user's response in the appropriate property
            if (question.QuestionText.Contains("mood"))
            {
                user.CurrentMood = question.PossibleAnswers[responseIndex];
            }
            else if (question.QuestionText.Contains("genre"))
            {
                user.FavoriteGenres.Add(question.PossibleAnswers[responseIndex]);
            }
            else if (question.QuestionText.Contains("time"))
            {
                user.WatchingTime = question.PossibleAnswers[responseIndex];
            }
            else if (question.QuestionText.Contains("lighthearted"))
            {
                user.PreferredTone = question.PossibleAnswers[responseIndex];
            }
        }
    }

    // This method shows a list of recommended shows based on the user's quiz answers
    static void DisplayRecommendation(UserPreferences user)
    {
        foreach (var recommendation in recommendations)
        {
            // Match recommendations based on either the genre or the user's mood
            if (user.FavoriteGenres.Contains(recommendation.Genre) || recommendation.MoodMatch == user.CurrentMood.ToLower())
            {
                // Display the recommendation details if a match is found
                Console.WriteLine($"\n\nRecommendation: {recommendation.Title}");
                Console.WriteLine($"Genre: {recommendation.Genre}");
                Console.WriteLine($"Description: {recommendation.Description}");
                Console.WriteLine();
            }
        }
    }
}
