using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace minimalTemplate.Core.Resources
{
    public sealed class ResourceUtil
    {
        public ResourceUtil() { }

        /// <summary>
        /// Try to set Resources culture from a given string. 
        /// It defaults to culture "en-US" if:
        /// - culture name is not informed
        /// - it can't get culture info for some reason
        /// - if resources for specific culture does not exist
        /// </summary>
        /// <param name="cultureName">String with culture name.</param>
        public static void SelectResourcesForRequestedCultureOrDefault(string cultureName)
        {
            try
            {
                Resource.Culture = new CultureInfo(cultureName);
            }
            catch
            {
                Resource.Culture = new CultureInfo("en-US");
            }
        }
    }
}
