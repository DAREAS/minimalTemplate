namespace minimalTemplate.DataContracts
{
    /// <summary>
    /// Class that can be used to hold results from a method execution, like statuses, validation errors and related stuff.
    /// </summary>
    public class OperationInfo
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public OperationInfo()
        {
        }

        /// <summary>
        /// Alternative constructor.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        public OperationInfo(int errorCode, string message)
        {
            Code = errorCode;
            Message = message;
        }

        /// <summary>
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="field"></param>
        public OperationInfo(int code, string message, string field)
        {
            Code = code;
            Message = message;
            Field = field;
        }

        /// <summary>
        /// Operation info output message code. This field can be used by other applications for error handling or translation.
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Operation info output message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Field source
        /// </summary>
        public string Field { get; set; }
    }
}
