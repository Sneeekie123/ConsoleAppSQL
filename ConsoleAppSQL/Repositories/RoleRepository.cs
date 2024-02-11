using ConsoleAppSQL.Contexts;
using ConsoleAppSQL.Entities;

namespace ConsoleAppSQL.Repositories;

internal class RoleRepository : Repo<RoleEntity>
{
    public RoleRepository(DataContext context) : base(context)
    {

    }


}

