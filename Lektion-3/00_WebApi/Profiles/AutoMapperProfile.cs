using _00_WebApi.Models.Entities;
using _00_WebApi.Models.Product;
using AutoMapper;

namespace _00_WebApi.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductEntity, Product>()
                .ForMember(d => d.ArticleNumber, option => option.MapFrom(s => s.ArticleNr));

            CreateMap<Product, ProductEntity>()
                .ForMember(d => d.ArticleNr, option => option.MapFrom(s => s.ArticleNumber));
        }
    }
}
