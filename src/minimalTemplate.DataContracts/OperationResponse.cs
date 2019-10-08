using System.Collections.Generic;

namespace minimalTemplate.DataContracts
{
    public class OperationResponse
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public OperationResponse()
        {
            Success = false;
            Errors = new List<OperationInfo>();
        }

        /// <summary>
        /// Indicates if operation completed without errors.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Detailed results of a method execution.
        /// </summary>
        public List<OperationInfo> Errors { get; set; }

        public void AddError(int code, string message, string field)
        {
            Errors.Add(new OperationInfo(code, message, field));
            Success = false;
        }

        public void AddError(int errorCode, string message)
        {
            Errors.Add(new OperationInfo(errorCode, message));
            Success = false;
        }

        public void AddError(OperationInfo operationInfo)
        {
            Errors.Add(operationInfo);
            Success = false;
        }

        public void AddErrors(List<OperationInfo> operationInfos)
        {
            Errors.AddRange(operationInfos);
            Success = false;
        }
    }

    /// <summary>
    /// Represents the return of an internal operation.
    /// </summary>
    /// <typeparam name="T">Type of data to be returned.</typeparam>
    public class OperationResponse<T> : OperationResponse
    {
        public T Data { get; set; }

        public OperationResponse() { }

        public OperationResponse(T data)
        {
            Data = data;
        }
    }
}
