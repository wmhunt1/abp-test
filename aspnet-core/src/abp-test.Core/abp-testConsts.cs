using abp-test.Debugging;

namespace abp-test
{
    public class abp-testConsts
    {
        public const string LocalizationSourceName = "abp-test";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "91c08f1bf1ab4672bb44c7b43fe08680";
    }
}
