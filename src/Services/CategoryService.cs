using AutoMapper;
using IWantAPP.Domain.Products;
using IWantAPP.Dto;
using IWantAPP.Repositories;

namespace IWantAPP.Services
{
    public class CategoryService
    {
        ApplicationDbContext context;

        public CategoryDto Created(CategoryDto categoryDto)
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDto>());
            var mapper = new Mapper(config);




            var category = new Category
            {
                Name = categoryDto.Name
            };
            context.Categories.Add(category);
            context.SaveChanges();
            var Dto = mapper.Map<CategoryDto>(category);
            return Dto;
        }
    }
}
