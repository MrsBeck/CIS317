/*Asia Beck
* 10-19-2024
* Class representing a show recommendation
*/

public class Recommendation
{
    // Properties for the Recommendation object: ID, Title, Genre, Description, and MoodMatch
    public int RecommendationID { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public string MoodMatch { get; set; }

    // Constructor to initialize the Recommendation object
    public Recommendation(int id, string title, string genre, string description, string moodMatch)
    {
        RecommendationID = id;
        Title = title;
        Genre = genre;
        Description = description;
        MoodMatch = moodMatch;
    }
}