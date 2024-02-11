using ConsoleAppSQL.Contexts;
using ConsoleAppSQL.Entities;

namespace ConsoleAppSQL.Repositories;

internal class ProductRepository : Repo<ProductEntity>
{
    public ProductRepository(DataContext context) : base(context)
    {

    }


}

