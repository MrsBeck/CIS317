/*Asia Beck
* 10-19-2024
* Class representing a user's preferences based on their quiz answers
*/

public class UserPreferences
{
    // Properties for the user's ID, name, current mood, favorite genres, time availability, and preferred tone
    public int UserID { get; set; }
    public string Username { get; set; }
    public string CurrentMood { get; set; }
    public List<string> FavoriteGenres { get; set; }
    public string WatchingTime { get; set; } // User's preferred time for watching a show
    public string PreferredTone { get; set; } // Whether the user prefers lighthearted or thought-provoking content
    public DateTime LastUpdated { get; set; }

    // Constructor to initialize a new user with their ID and username, and set default values
    public UserPreferences(int userId, string username)
    {
        UserID = userId;
        Username = username;
        FavoriteGenres = new List<string>();
        LastUpdated = DateTime.Now;
    }

    // This method allows updating the user's preferences after taking the quiz again
    public void UpdatePreferences(List<string> newGenres, string newMood)
    {
        FavoriteGenres = newGenres;
        CurrentMood = newMood;
        LastUpdated = DateTime.Now;
    }

    // This method clears the user's preferences (in case they want to start fresh)
    public void DeletePreferences()
    {
        FavoriteGenres.Clear();
        CurrentMood = null;
    }
}
