using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Win8ServiceDiscovery
{/// <summary>
    ///
    /// </summary>
    /// 
    public  class Config 
    {
        // App registration credentials for Microsoft account (Live Id)
        public string MicrosoftAccountClientId = "<ENTER YOUR CLIENT ID FOR MICROSOFT ACCOUNT>";
        public string MicrosoftAccountClientSecret = "<ENTER YOUR CLIENT SECRET FOR MICROSOFT ACCOUNT>"; 
        public string MicrosoftAccountRedirectUri = "<ENTER YOUR REDIRECT URI FOR MICROSOFT ACCOUNT>";


        // App registration for Organizational account (Office 365 account)
        public string OrganizationalAccountClientId = "a84dae00-d673-4fa2-82ca-d8abd0d17518";
        public string OrganizationalAccountRedirectUri = "https://usdxcamps.onmicrosoft.com/DiscoveryWin8";
               
    }
}
