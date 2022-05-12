using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASMEFCore.Shared.Models;

public class Course
{
    //Id
    public int CourseId { get; set; }

    //Number
    public string Number { get; set; }

    //Title
    public string Title { get; set; }

    //Description
    public string Description { get; set; }

    //Duration in minutes
    public int DurationInMin { get; set; }

    //Difficulty
    public Difficulty Difficulty { get; set; }

    //Status
    public bool IsActive { get; set; }

    //Participants
    public List<Student> Participants { get; set; }
}
