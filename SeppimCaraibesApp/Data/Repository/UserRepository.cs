namespace SeppimCaraibesApp.Data.Repository
{
    using System.Threading.Tasks;

    internal class UserRepository
    {
        public async Task<ORM.User> GetUser(ORM.SeppimCaraibesLocalEntities context, int code)
        {
            return await context.Users.FindAsync(code);
        }

        public async Task<ORM.User> GetUser(ORM.SeppimCaraibesLocalEntities context, string nick, string pass)
        {
            return await context.Users.FindAsync(nick, pass);
        }

        public void AddUser(ORM.SeppimCaraibesLocalEntities context, ORM.User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            context.Entry(user).Reload();
        }

        public void EditUser(ORM.SeppimCaraibesLocalEntities context, ORM.User user)
        {
            context.Users.Add(user);
            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            context.Entry(user).Reload();
        }

        public async void DeleteUser(ORM.SeppimCaraibesLocalEntities context, int code)
        {
            var user = await context.Users.FindAsync(code);
            context.Users.Remove(user);
            context.SaveChanges();
        }
    }
}
