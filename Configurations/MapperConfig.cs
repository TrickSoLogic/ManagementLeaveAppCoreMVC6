using AutoMapper;
using ManagementLeaveAppCoreMVC6.Data;
using ManagementLeaveAppCoreMVC6.Models;

namespace ManagementLeaveAppCoreMVC6.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // Syntax: CreateMap<Source_Type, LeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}








