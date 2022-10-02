using bacit_dotnet.MVC.Entities;
using bacit_dotnet.MVC.Models.Users;

namespace bacit_dotnet.MVC.Repositories
{
    public interface IUserRepository
    {
        void Save(UserEntity user);
        List<UserEntity> GetUsers();
        void Delete(string email);

        void Edit(UserEntity user);
        
    }


}