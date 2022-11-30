using Microsoft.AspNetCore.Mvc;
using jprofile.Models;

namespace jprofile.Controllers;

[ApiController]
[Route("api/jobprofile")]
public class profileController : ControllerBase
{
    private readonly WorkContext DB;
    
    public profileController(WorkContext db)
    {
        this.DB=db;
    }
 

[HttpGet("getAlljob")]
    public JobProfile getAlljob(int number)
    {
        try
        {
            return DB.JobProfiles.Where(e =>e.CandidateId.Equals(number)).FirstOrDefault();

        }
        catch(System.Exception)
        {
            throw;
        }
        
        
}
}
 
