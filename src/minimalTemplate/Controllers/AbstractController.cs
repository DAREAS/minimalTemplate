using Microsoft.AspNetCore.Mvc;
using minimalTemplate.Core.Resources;
using minimalTemplate.DataContracts;

namespace minimalTemplate.Controllers
{
    public class AbstractController : Controller
    {
        /// <summary>
        /// Builds an OK (200) result with a body object containing the success flag set to true.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        protected OkObjectResult OkWithSuccess()
        {
            return Ok(new OperationResponse { Success = true });
        }

        /// <summary>
        /// Builds a Bad Request (400) result with a default error message indicating the request is invalid.
        /// </summary>
        /// <returns></returns>
        protected new BadRequestObjectResult BadRequest()
        {
            ErrorCodeEnum errorCode = ErrorCodeEnum.RequestIsNull;
            var response = new OperationResponse { Success = false };

            response.AddError((int)errorCode, ErrorCodeMessage.GetMessage(errorCode));

            return base.BadRequest(response);
        }

        /// <summary>
        /// Builds a Not Found (404) result with a message indicating the key not found.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        protected NotFoundObjectResult NotFound(string resource, object key)
        {
            ErrorCodeEnum errorCode = ErrorCodeEnum.ResourceNotFound;
            var response = new OperationResponse { Success = false };

            // TODO: Validate if modify the property name of "Key" to "Identifier".
            response.AddError((int)errorCode, ErrorCodeMessage.GetMessage(errorCode, resource, key), "Key");

            return base.NotFound(response);
        }
    }
}
