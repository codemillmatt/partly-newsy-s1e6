using System;
using System.Threading.Tasks;
using Microsoft.AppCenter.Auth;

namespace PartlyNewsy.Core
{
    public class AuthenticationService
    {
        public string AccessToken { get; set; }

        public async Task<bool> Login()
        {
            try
            {
                var user = await Auth.SignInAsync();

                AccessToken = user.AccessToken;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool Logout()
        {
            try
            {
                Auth.SignOut();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
