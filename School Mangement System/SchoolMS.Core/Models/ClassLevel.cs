using Azure.Identity;
using SchoolMS.Core.Models.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMS.Core.Models
{
    public class ClassLevel:BaseEntity
    {
        public String  Name { get; set; }
        public int RoomNumber { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Subject>Subjects { get; set; }
        public List<Student> Students { get; set; }
       
        public ResultSheet ResultSheet { get; set; }
    }
}