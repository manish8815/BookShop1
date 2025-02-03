using AutoMapper;
using BookShop.DTOs;
using BookShop.Entities;

namespace BookShop.Mappers
{
    public class BookshopMapper:Profile
    {
        public BookshopMapper()
        {
            CreateMap<Category, CategoryDTO>();
        }
    }
}
