using LastPractosik;

public class Polzovatel
{
    public static string? login;
    public static string? password;
    public static int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public static Roli Role { get; set; }

    public Polzovatel(int id, string login, string password, Roli role)
    {
        Id = id;
        Login = login;
        Password = password;
        Role = role;
    }
}