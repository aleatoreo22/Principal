namespace Principal.Model;

public class Student
{
    public Student(string Id)
    {
        if (string.IsNullOrEmpty(Id))
            return;
    }

    public string Mom { get; set; } = "";
    public string Dad { get; set; } = "";
    public string Name { get; set; } = "";
    public string Id { get; set; } = "";
}