namespace SeppimCaraibesApp.Data.Repository
{
    using System.Threading.Tasks;

    internal class RoleRepository
    {
        public async Task<ORM.Role> GetRole(ORM.SeppimCaraibesLocalEntities context, int code)
        {
            return await context.Roles.FindAsync(code);
        }

        public void AddRole(ORM.SeppimCaraibesLocalEntities context, ORM.Role role)
        {
            context.Roles.Add(role);
            context.SaveChanges();
            context.Entry(role).Reload();
        }

        public void EditRole(ORM.SeppimCaraibesLocalEntities context, ORM.Role role)
        {
            context.Roles.Add(role);
            context.Entry(role).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            context.Entry(role).Reload();
        }

        public async void DeleteRole(ORM.SeppimCaraibesLocalEntities context, int code)
        {
            var role = await context.Roles.FindAsync(code);
            context.Roles.Remove(role);
            context.SaveChanges();
        }
    }
}
