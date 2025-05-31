namespace GitHubActions.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public void CheckAge()
    {
        if (Age < 18) throw new Exception();
    }
}