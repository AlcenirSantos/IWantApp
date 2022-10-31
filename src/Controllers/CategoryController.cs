using IWantAPP.Domain.Products;
using IWantAPP.Dto;
using IWantAPP.Repositories;
using IWantAPP.Services;

namespace IWantAPP.Controllers
{
    public class CategoryController
    {
        public static string Template => "/categories";

        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };

        public static Delegate Handle => Action;
        

        public static IResult Action(CategoryDto categoryDto)
        {
            CategoryService categoryService = new CategoryService();

            return Results.Created(Template, categoryService.Created(categoryDto));
        }

    }
}
