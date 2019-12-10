namespace SeppimCaraibesApp.Domain.Model
{
    using System.Linq;
    using System.Threading.Tasks;

    internal class Role
    {
        public async Task<Data.ORM.Role> GetRole(Data.ORM.SeppimCaraibesLocalEntities context, int code)
        {
            var rRole = new Data.Repository.RoleRepository();
            return await rRole.GetRole(context, code);
        }

        public void AddRole(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Role role)
        {
            var rRole = new Data.Repository.RoleRepository();
            if (!context.Roles.Any(r => r.Name == role.Name))
            {
                rRole.AddRole(context, role);
            }
        }

        public void EditRole(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Role role)
        {
            var rRole = new Data.Repository.RoleRepository();
            rRole.EditRole(context, role);
        }

        public void DeleteRole(Data.ORM.SeppimCaraibesLocalEntities context, int code)
        {
            var rRole = new Data.Repository.RoleRepository();
            rRole.DeleteRole(context, code);
        }
    }
}
