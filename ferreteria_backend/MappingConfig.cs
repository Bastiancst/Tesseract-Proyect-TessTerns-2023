using AutoMapper;
using ferreteria_backend.Models;
using ferreteria_backend.Models.DTO;

namespace ferreteria_backend
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Item, ItemDTO>();
            CreateMap<ItemDTO, Item>();

			CreateMap<Item, ItemCreateDTO>().ReverseMap();
			CreateMap<Item, ItemUpdateDTO>().ReverseMap();
		}
    }
}
