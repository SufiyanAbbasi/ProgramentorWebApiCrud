using System;
using System.Collections.Generic;

namespace ProgramentorWebApi.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Address { get; set; }

    public DateTime Dob { get; set; }
}
