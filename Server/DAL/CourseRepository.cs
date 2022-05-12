namespace BlazorWASMEFCore.Server.DAL;

public class CourseRepository
{
    private readonly SchoolContext _schoolContext;
    public CourseRepository()
    {
        _schoolContext = new SchoolContext();
    }

    //Create a new course.
    //Get all courses.
    //Get a course by id.
    //Get a course by number.
    //Update a course by id.
    //Delete a course by id.
}
