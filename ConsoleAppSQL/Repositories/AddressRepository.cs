using ConsoleAppSQL.Contexts;
using ConsoleAppSQL.Entities;

namespace ConsoleAppSQL.Repositories;

internal class AddressRepository : Repo<AddressEntity>
{
    public AddressRepository(DataContext context) : base(context)
    {

    }
    

}

