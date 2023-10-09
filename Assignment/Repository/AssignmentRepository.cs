using Assignment.DbContexts;

using Assignment.IRepository;

#pragma warning disable
namespace Assignment.Repository
{
    public class AssignmentRepository : IAssignment
    {
        private readonly WriteDbContext _contextW;
        private readonly ReadDbContext _contextR;
        public AssignmentRepository(WriteDbContext contextW, ReadDbContext contextR)
        {
            _contextW = contextW;
            _contextR = contextR;
        }
       



    }
}
