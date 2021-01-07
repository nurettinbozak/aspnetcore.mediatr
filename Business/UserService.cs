using System.Threading.Tasks;
using AspNetCore.Mediatr.Request;
using AspNetCore.Mediatr.Response;

namespace AspNetCore.Mediatr.Business
{
    public class UserService
    {
        public UserService()
        {
        }

        public async Task<UserResponseModel> Add(UserRegisterRequestModel request)
        {
            //Burada DB'ye kayıt işlemini yapıyoruz aslında :)

            //Kayıt başarılı olduktan sonra dönen kullanıcı Id değerini reponse modelimize atıp modeli döndürüyoruz.

            var result = new UserResponseModel() { Id = 1, Message = "Başarısız" };

            return result;
        }
    }
}

