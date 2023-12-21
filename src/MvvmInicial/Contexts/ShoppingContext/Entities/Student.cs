namespace MvvmInicial.Entities;

// Model 👇
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

// Model - View - ViewModel -> Desacoplar o front 

public class CreateStudentViewModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public int State { get; set; }

    public static implicit operator Student(
        CreateStudentViewModel model)
    {
        return new Student();
    }
}