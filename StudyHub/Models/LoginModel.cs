using System.ComponentModel.DataAnnotations;

namespace StudyHub.Models;

public class LoginModel
{

    [Required(ErrorMessage ="Type the username")]
    public String Username { get; set; } = "";

    [Required(ErrorMessage = "Type the password")]
    public String Password { get; set; } = "";

}
