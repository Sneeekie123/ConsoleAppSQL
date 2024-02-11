using ConsoleAppSQL.Contexts;
using ConsoleAppSQL.Entities;

namespace ConsoleAppSQL.Repositories;

internal class CustomerRepository : Repo<CustomerEntity>
{
    public CustomerRepository(DataContext context) : base(context)
    {

    }


}

