using AutoMapper;
using Moot.Business.Entities;
using Moot.Service.ViewModels;

namespace Moot.Service
{
    public class AutoMapperBootStrapper
    {
        public static void ConfigureAutoMapper()
        {

            //Contact
            Mapper.CreateMap<Contact, ContactViewModel>();
            Mapper.CreateMap<ContactViewModel, Contact>();

        }
    }
}
