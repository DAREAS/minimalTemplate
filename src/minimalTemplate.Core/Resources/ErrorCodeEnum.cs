using System;
using System.Collections.Generic;
using System.Text;

namespace minimalTemplate.Core.Resources
{
    public enum ErrorCodeEnum
    {
        Undefined = 0,

        #region Erros de servidor

        UnexpectedError = 500000,
        DatabaseError = 500001,
        DatabaseOffline = 500002,
        NoExistItem = 500003,

        IntegrationError = 500099,

        #endregion

        #region Erros de cliente

        UnauthorizedAccess = 401000,

        ResourceNotFound = 404000,

        RequestIsNull = 400000,
        PropertyNameNotFound = 400001,

        MissingField = 4220001,
        MissingValueExpected = 4220002,
        PropertyInvalidType = 4220003,

        InvalidField = 4220097,
        InvalidSize = 4220098,

        InvalidEmail = 4220099,
        InvalidDocument = 4220100,
        InvalidDateTime = 4220101,
        UrlCallbackIsNull = 4220102,

        #endregion
    }
}
