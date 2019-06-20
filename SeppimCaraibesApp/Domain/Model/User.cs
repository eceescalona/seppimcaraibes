namespace SeppimCaraibesApp.Domain.Model
{
    using System.Linq;
    using System.Threading.Tasks;

    internal class User
    {
        public async Task<Data.ORM.User> GetUser(Data.ORM.SeppimCaraibesLocalEntities context, int code)
        {
            var rUser = new Data.Repository.UserRepository();
            return await rUser.GetUser(context, code);
        }

        public void AddUser(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.User user)
        {
            var rUser = new Data.Repository.UserRepository();
            if (!context.Users.Any(u => u.Nick == user.Nick))
            {
                rUser.AddUser(context, user);
            }
        }

        public void EditUser(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.User user)
        {
            var rUser = new Data.Repository.UserRepository();
            rUser.EditUser(context, user);
        }

        public void DeleteUser(Data.ORM.SeppimCaraibesLocalEntities context, int code)
        {
            var rUser = new Data.Repository.UserRepository();
            rUser.DeleteUser(context, code);
        }
    }
}
