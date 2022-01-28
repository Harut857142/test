namespace Gas.Admin.Models.Auth
{
    public class GasAdminAuthenticationDefaults
    {
        public static readonly string CookiePrefix = ".GasAdmin.";
        public static readonly string ClaimsIssuer = "GasAdmin";
        public static readonly string ReturnUrlParameter = "";
        public const string AuthenticationScheme = "Cookies";
        public const string ExternalAuthenticationScheme = "ExternalAuthentication";
    }
}