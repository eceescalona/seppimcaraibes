namespace SeppimCaraibesApp.Data.Repository
{
    using System.Threading.Tasks;

    internal class  PermissionRepository
    {
        public async Task<ORM.Permission> GetPermission(ORM.SeppimCaraibesLocalEntities context, int code)
        {
            return await context.Permissions.FindAsync(code);
        }

        public void AddPermission(ORM.SeppimCaraibesLocalEntities context, ORM.Permission permission)
        {
            context.Permissions.Add(permission);
            context.SaveChanges();
            context.Entry(permission).Reload();
        }

        public void EditPermission(ORM.SeppimCaraibesLocalEntities context, ORM.Permission permission)
        {
            context.Permissions.Add(permission);
            context.Entry(permission).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            context.Entry(permission).Reload();
        }

        public async void DeletePermission(ORM.SeppimCaraibesLocalEntities context, int code)
        {
            var permission = await context.Permissions.FindAsync(code);
            context.Permissions.Remove(permission);
            context.SaveChanges();
        }
    }
}
