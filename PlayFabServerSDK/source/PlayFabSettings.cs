
namespace PlayFab
{
    public class PlayFabSettings
    {
        public const string SdkVersion = "1.22.171127";
        public const string BuildIdentifier = "jbuild_csharpsdk_0";
        public const string SdkVersionString = "CSharpSDK-1.22.171127";

        /// <summary> This is for PlayFab internal debugging.  Generally you shouldn't touch this </summary>
        public static bool UseDevelopmentEnvironment = false;
        /// <summary> This is for PlayFab internal debugging.  Generally you shouldn't touch this </summary>
        public static string DevelopmentEnvironmentUrl = ".playfabsandbox.com";
        /// <summary> This is only for customers running a private cluster.  Generally you shouldn't touch this </summary>
        public static string ProductionEnvironmentUrl = ".playfabapi.com";
        /// <summary> You must set this value for PlayFabSdk to work properly (Found in the Game Manager for your title, at the PlayFab Website) </summary>
        public static string DeveloperSecretKey = null;


        /// <summary> You must set this value for PlayFabSdk to work properly (Found in the Game Manager for your title, at the PlayFab Website) </summary>
        public static string TitleId;
        public static ErrorCallback GlobalErrorHandler;

        public static string GetFullUrl(string apiCall)
        {
            var baseUrl = UseDevelopmentEnvironment ? DevelopmentEnvironmentUrl : ProductionEnvironmentUrl;
            if (baseUrl.StartsWith("http"))
                return baseUrl;
            return "https://" + TitleId + baseUrl + apiCall;
        }
    }
}
