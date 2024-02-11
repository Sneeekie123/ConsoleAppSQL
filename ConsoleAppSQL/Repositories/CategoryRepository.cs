using ConsoleAppSQL.Contexts;
using ConsoleAppSQL.Entities;

namespace ConsoleAppSQL.Repositories;

internal class CategoryRepository : Repo<CategoryEntity>
{
    public CategoryRepository(DataContext context) : base(context)
    {

    }


}

