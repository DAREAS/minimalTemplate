using System;
using System.Collections.Generic;
using System.Text;

namespace minimalTemplate.Core.Resources
{
    public enum ErrorCodeState
    {
        /// <summary>
        /// Do nothing to modify process of message generation.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Message will be built automatically from error code defined in <see cref="ErrorCodeEnum"/>.
        /// </summary>
        MessageFromErrorCode = 1
    }
}
