using System;
using System.Collections.Generic;

namespace NvtLesson10EFDb.Models;

public partial class NvtMember
{
    public long Id { get; set; }

    public string? NvtUseName { get; set; }

    public string? NvtPassword { get; set; }

    public string? NvtFullName { get; set; }

    public string? NvtEmail { get; set; }

    public string? NvtPhone { get; set; }

    public bool? NvtStatus { get; set; }
}
