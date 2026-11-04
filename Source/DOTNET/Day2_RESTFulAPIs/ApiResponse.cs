namespace TryToLearnNetCore.LearnOn30Days.Day2_RESTFulAPIs
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; } // ex: true or false for help frontend read data is faster.
        public T? Data { get; set; } // Data : {Name: "Luong"}
        public int? StatusCode { get; set; } // ex: 200, 201, 204,..
        public string? ErrorCode { get; set; } // ex: CAR_NOT_FOUND
        public string? MessageDetail { get; set; } // ex: data get thanh cong. 
        public List<string>? ListError { get; set; } // ex: 1. data get khong thanh cong, 2. Loi get data thieu field.

        // When success:
        public static ApiResponse<T> ReponseSuccess(int? statusCode, T data, string message = "Access Successful")
        {
            return new ApiResponse<T>
            {
                Success = true,
                Data = data,
                StatusCode = statusCode,
                MessageDetail = message

            };
        }

        public static ApiResponse<T> ReponseFailed(int? statusCode, string? errorCode, string message = "Access Failed")
        {
            return new ApiResponse<T>
            {
                Success = false,
                StatusCode = statusCode,
                ErrorCode = errorCode,
                ListError = null,
                MessageDetail = message,
            };
        }
    }
}
