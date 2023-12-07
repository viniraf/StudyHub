namespace StudyHub.Models;

public class UserModel
{
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public String Name { get; set; } = "";

    public String Profile { get; set; } = "";

    public String Username { get; set; } = "";

    public String Password { get; set; } = "";

}
