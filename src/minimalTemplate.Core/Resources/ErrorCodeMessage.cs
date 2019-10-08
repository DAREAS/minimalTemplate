using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace minimalTemplate.Core.Resources
{
    public static class ErrorCodeMessage
    {
        public static string GetMessage(ErrorCodeEnum code) => Resource.ResourceManager.GetString(code.ToString()) ?? code.ToString();

        public static string GetMessage(ErrorCodeEnum code, params object[] parameters)
        {
            return FormattableStringFactory.Create(GetMessage(code), parameters).ToString();
        }
    }
}
