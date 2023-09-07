using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoWebApp.Core.Utilities
{
    public class Constants
    {
        public struct AppSettings
        {
            public const string BaseApiUrl = "AppSettings:BaseApiUrl";
            public const string DockerBaseApiUrl = "AppSettings:DockerBaseApiUrl";
        }
        public struct SessionKey
        {
            public const string sessionLogin = "sessionLogin";
            public const string accessToken = "JwtToken";
        }

        public struct Response
        {
            public struct IsSuccess
            {
                public const bool True = true;
                public const bool False = false;
            }
            public struct StatusMessage
            {
                public const string Success = "OK";
                public const string No_Data = "No Data";
                public const string Could_Not_Create = "Could not create";
                public const string No_Delete = "No Deleted";
                public const string Duplicate_User = "User is Duplicate";
                public const string Cannot_Update_Data = "Cannot Update Data";
                public const string Cannot_Map_Data = "Cannot Map Data";
                public const string InActive = "This username is inactive";
                public const string InsertSuccess = "Insert successfully";
                public const string UpdateSuccess = "Update successfully";
                public const string DeleteSuccess = "Delete successfully";
            }
        }
    }
}
