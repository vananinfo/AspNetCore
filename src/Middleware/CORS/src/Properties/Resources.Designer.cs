// <auto-generated />
namespace Microsoft.AspNetCore.Cors
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Cors.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The CORS protocol does not allow specifying a wildcard (any) origin and credentials at the same time. Configure the CORS policy by listing individual origins if credentials needs to be supported.
        /// </summary>
        internal static string InsecureConfiguration
        {
            get => GetString("InsecureConfiguration");
        }

        /// <summary>
        /// The CORS protocol does not allow specifying a wildcard (any) origin and credentials at the same time. Configure the CORS policy by listing individual origins if credentials needs to be supported.
        /// </summary>
        internal static string FormatInsecureConfiguration()
            => GetString("InsecureConfiguration");

        /// <summary>
        /// PreflightMaxAge must be greater than or equal to 0.
        /// </summary>
        internal static string PreflightMaxAgeOutOfRange
        {
            get => GetString("PreflightMaxAgeOutOfRange");
        }

        /// <summary>
        /// PreflightMaxAge must be greater than or equal to 0.
        /// </summary>
        internal static string FormatPreflightMaxAgeOutOfRange()
            => GetString("PreflightMaxAgeOutOfRange");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}