using AutoMapper;
using SchoolMS.Core.Models;

namespace SchoolMS.Web.ViewModels
{
    public class DomainMaper:Profile
    {
        public DomainMaper()
        {
            CreateMap<DesignationView, Designation>();
            CreateMap<Designation,DesignationView>();
            
        }
    }
}
