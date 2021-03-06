/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace AspNet.Security.OAuth.Transferwise {
    /// <summary>
    /// Default values used by the Transferwise authentication middleware.
    /// </summary>
    public static class TransferwiseAuthenticationDefaults {
        /// <summary>
        /// Default value for <see cref="AuthenticationOptions.AuthenticationScheme"/>.
        /// </summary>
        public const string AuthenticationScheme = "Transferwise";

        /// <summary>
        /// Default value for <see cref="RemoteAuthenticationOptions.DisplayName"/>.
        /// </summary>
        public const string DisplayName = "Transferwise";

        /// <summary>
        /// Default value for <see cref="AuthenticationOptions.ClaimsIssuer"/>.
        /// </summary>
        public const string Issuer = "Transferwise";

        /// <summary>
        /// Default value for <see cref="RemoteAuthenticationOptions.CallbackPath"/>.
        /// </summary>
        public const string CallbackPath = "/signin-transferwise";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.AuthorizationEndpoint"/>.
        /// </summary>
        public const string AuthorizationEndpoint = "https://test-restgw.transferwise.com/oauth/authorize";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.TokenEndpoint"/>.
        /// </summary>
        public const string TokenEndpoint = "https://test-restgw.transferwise.com/oauth/token";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.UserInformationEndpoint"/>.
        /// </summary>
        public const string UserInformationEndpoint = "https://test-restgw.transferwise.com/v1/profiles";
    }
}
