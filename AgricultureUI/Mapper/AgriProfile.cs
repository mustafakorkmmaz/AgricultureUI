using AutoMapper;
using Agri.Entity.Entities;
using AgricultureUI.Models;

namespace AgricultureUI.Mapper
{
    public class AgriProfile:Profile
    {
        public AgriProfile()
        {
            CreateMap<ServiceEklemeViewModel, Service>();
            CreateMap<Service, ServiceEklemeViewModel>();
            CreateMap<AnnouncementViewModel, News>();
            CreateMap<News, AnnouncementViewModel>();
            CreateMap<Address,AddressUpdateViewModel>();
            CreateMap<AddressUpdateViewModel, Address>();
            CreateMap<ContactAddViewModel,Contact>().ReverseMap();



        }
    }
}
