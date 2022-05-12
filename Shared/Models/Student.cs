using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASMEFCore.Shared.Models;

public class Student
{
    public int StudentId { get; set; }

    //First name
    public string FirstName { get; set; }

    //Last name
    public string LastName { get; set; }

    //Email
    public string Email { get; set; }

    //Mobile phone number
    public string MobilePhoneNumber { get; set; }

    //Address
    public string Street { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }

    //Enrollments
    public List<Course> Enrollments { get; set; }
}
