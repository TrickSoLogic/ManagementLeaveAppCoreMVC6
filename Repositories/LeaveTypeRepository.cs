using ManagementLeaveAppCoreMVC6.Contracts;
using ManagementLeaveAppCoreMVC6.Data;

namespace ManagementLeaveAppCoreMVC6.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
