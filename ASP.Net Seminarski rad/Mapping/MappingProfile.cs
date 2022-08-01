using ASP.Net_Seminarski_rad.Models.Binding;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Models.ViewModel;
using AutoMapper;

namespace ASP.Net_Seminarski_rad.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AddressBinding, Address>();
            CreateMap<Address, AddressViewModel>();

            CreateMap<ProductBinding, Product>();
            CreateMap<Product, ProductViewModel>();

            CreateMap<ProductCategoryBinding, ProductCategory>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<ProductCategoryUpdateBinding, ProductCategory>();

            CreateMap<ApplicationUserBinding, ApplicationUser>()
                .ForMember(dst => dst.UserName, opts => opts.MapFrom(src => src.Email));

        }
    }
}
