using AutoMapper;
using LMS_ELibrary.Data;
using LMS_ELibrary.Model;
/*we*/
namespace LMS_ELibrary.Mapper
{
    public class MonhocMapper:Profile
    {
        public MonhocMapper()
        {
            CreateMap<Monhoc_Db, Monhoc_Model>();
        }
    }
}
