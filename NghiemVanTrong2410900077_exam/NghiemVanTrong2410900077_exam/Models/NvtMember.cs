using System;
using System.Collections.Generic;

namespace NghiemVanTrong2410900077_exam.Models;

public partial class NvtMember
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? Gender { get; set; }

    public DateOnly? BirthDay { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public bool? Active { get; set; }
}
