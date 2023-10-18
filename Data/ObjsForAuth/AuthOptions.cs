using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Museum.Data.ObjsForAuth
{
    public class AuthOptions
    {
        public const string ISSUER = "phah";
        public const string AUDIENCE = "Museum";
        const string KEY = "phahmuseumkey1232134231";
        public const int LIFETIME = 10;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
