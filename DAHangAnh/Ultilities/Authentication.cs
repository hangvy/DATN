using Google.Apis.Drive.v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHangAnh.Ultilities
{
    public class Authentication
    {
        /// <summary>
        /// Authenticate to Google Using Oauth2
        /// Documentation https://developers.google.com/accounts/docs/OAuth2
        /// </summary>
        /// <param name="clientId">From Google Developer console https://console.developers.google.com</param>
        /// <param name="clientSecret">From Google Developer console https://console.developers.google.com</param>
        /// <param name="userName">A string used to identify a user.</param>
        /// <returns></returns>

        public static DriveService AuthenticateOauth()
        {
            return null;
        }

    }
}
