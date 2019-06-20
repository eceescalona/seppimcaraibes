namespace SeppimCaraibesApp.Domain.Model
{
    using System.Linq;
    using System.Threading.Tasks;

    internal class Permission
    {
        public async Task<Data.ORM.Permission> GetPermission(Data.ORM.SeppimCaraibesLocalEntities context, int code)
        {
            var rPermission = new Data.Repository.PermissionRepository();
            return await rPermission.GetPermission(context, code);
        }

        public void AddPermission(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Permission permission)
        {
            var rPermission = new Data.Repository.PermissionRepository();
            if (!context.Permissions.Any(p => p.Name == permission.Name))
            {
                rPermission.AddPermission(context, permission);
            }
        }

        public void EditPermission(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Permission permission)
        {
            var rPermission = new Data.Repository.PermissionRepository();
            rPermission.EditPermission(context, permission);
        }

        public void DeletePermission(Data.ORM.SeppimCaraibesLocalEntities context, int code)
        {
            var rPermission = new Data.Repository.PermissionRepository();
            rPermission.DeletePermission(context, code);
        }
    }
}
