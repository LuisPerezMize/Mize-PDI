using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDILibrary.Engine
{
    class ParseCookie
    {
        public string ParseData(string Cookie)
        {
   //         {System.Net.CookieException: The 'Value'='PLAY_SESSION="e1cd7b00b3557ca2304e08a5a6574d469046c556-typeCode=company&user.key=kcmaadmin%40m-ize.com&organizationName=Kawasaki+Loaders&company=Kawasaki+Loaders&organizationCode=KWSC001&user=KCMA+Admin"; Expires=Wed, 21 Jun 2017 15:32:04 GMT; Path=/; HTTPOnly' part of the cookie is invalid.
   //at System.Net.Cookie.VerifySetDefaults(CookieVariant variant, Uri uri, Boolean isLocalDomain, String localDomain, Boolean set_default, Boolean isThrow)
   //at System.Net.CookieContainer.Add(Uri uri, Cookie cookie)
   //at PDILibrary.Network.NetworkCalls.<GetJsonForm>d__c.MoveNext()}

            string result = string.Empty;

            int Index = Cookie.IndexOf(";") - 1;
            result = Cookie.Substring(0, Index);
            result = result.Replace("PLAY_SESSION=\"", string.Empty);
            return result;
        }
    }
}
