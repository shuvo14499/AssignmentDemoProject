
using Assignment.IRepository;
using Microsoft.AspNetCore.Mvc;


namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignment _IRepository;
        public AssignmentController(IAssignment IRepository)
        {
            _IRepository = IRepository;
        }

    }
}
