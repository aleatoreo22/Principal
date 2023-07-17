using System;

namespace Principal.Model;

public class Student
{
    public Student()
    {
        Id = Guid.NewGuid();
    }

    public string Mom { get; set; } = "";
    public string Dad { get; set; } = "";
    public string Name { get; set; } = "";
    public Guid Id { get; set; }
}