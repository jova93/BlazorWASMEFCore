namespace BlazorWASMEFCore.Server.DAL;

public class StudentRepository
{
    private readonly SchoolContext _schoolContext;

    public StudentRepository()
    {
        _schoolContext = new SchoolContext();
    }

    //Create a new student.
    //Get all students.
    //Get a student by id.
    //Get a student by email.
    //Update a student by id.
    //Delete a student by id.
}
