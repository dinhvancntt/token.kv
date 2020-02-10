using Google.Authenticator;
using ServiceStack;
using WebAPI.ServiceModel;

namespace WebAPI.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Tocken request)
        {
            var tfa = new TwoFactorAuthenticator();
            return tfa.GetCurrentPIN("ba6896eb43f547be8b476649a5ff43f3");
        }
    }
}