using AutoMapper;
using InternetShopBLL.Models;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopBLL.Helpers
{
    class AutoMapperConfig
    {
        private static Mapper mapper;
        public static Mapper GetMapper()
        {
            if (mapper == null)
            {
                var config = new MapperConfiguration(cfg=>
                {
                    
                    cfg.CreateMap<List<ProductBLL>, List<Product>>(MemberList.None);
                    cfg.CreateMap<List<Product>, List<ProductBLL>>(MemberList.None);

                    cfg.CreateMap<PurchaseBLL, Purchase>(MemberList.None);
                    cfg.CreateMap<Purchase, PurchaseBLL>(MemberList.None);

                    cfg.CreateMap<ClientBLL, Client>(MemberList.None);
                    cfg.CreateMap<Client, ClientBLL>(MemberList.None);

                    cfg.CreateMap<CategoryBLL, Category>(MemberList.None);
                    cfg.CreateMap<Category, CategoryBLL>(MemberList.None);

                    cfg.CreateMap<Category, ProductBLL>(MemberList.None);
                    //.ForMember(d=>d.Category, o=> o.MapFrom(s=>s));
                    cfg.CreateMap<ProductBLL, Category>(MemberList.None);
                    //.ForMember(d => d, o => o.MapFrom(s => s.Category));

                    cfg.CreateMap<Producer, ProductBLL>(MemberList.None);
                    //.ForMember(d => d.Producer, o => o.MapFrom(s => s));
                    cfg.CreateMap<ProductBLL, Producer>(MemberList.None);
                    //.ForMember(d => d, o => o.MapFrom(s => s.Producer));

                    cfg.CreateMap<List<Image>, ProductBLL>(MemberList.None);
                    //.ForMember(d => d.Images, o => o.MapFrom(s => s));
                    cfg.CreateMap<ProductBLL, List<Image>>(MemberList.None);
                    //.ForMember(d => d, o => o.MapFrom(s => s.Images));

                    cfg.CreateMap<ProducerBLL, Producer>(MemberList.None);
                    cfg.CreateMap<Producer, ProducerBLL>(MemberList.None);

                    cfg.CreateMap<ImageBLL, Image>(MemberList.None);
                    cfg.CreateMap<Image, ImageBLL>(MemberList.None);

                    cfg.CreateMap<List<ImageBLL>, List<Image>>(MemberList.None);
                    cfg.CreateMap<List<Image>, List<ImageBLL>>(MemberList.None);

                    cfg.CreateMap<Product, ProductBLL>(MemberList.None);
                    //.IncludeMembers(s => s.Category, s => s.Producer, s => s.Images);
                    cfg.CreateMap<ProductBLL, Product>(MemberList.None);
                    //.IncludeMembers(s => s.Category, s => s.Producer, s => s.Images);

                });
                mapper = new Mapper(config);
            }
            return mapper;
        }
    }
}
