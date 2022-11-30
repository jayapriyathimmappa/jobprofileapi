using System;
using System.Collections.Generic;

namespace jprofile.Models;

public partial class JobProfile
{
    public int CandidateId { get; set; }

    public string? CandidateName { get; set; }

    public string? Designation { get; set; }

    public string? Experience { get; set; }

    public string? ProfileAbout { get; set; }
}
