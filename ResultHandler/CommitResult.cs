namespace ResultHandler
{
    public class CommitResult
    {
        public CommitResult(ResultType resultType = ResultType.Ok, string? errorMessage = default, string? errorCode = default)
        {
            ResultType = resultType;
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
        }
        public string? ErrorMessage { get; init; }
        public string? ErrorCode { get; init; }
        public ResultType ResultType { get; init; }
        public bool IsSuccess { get => string.IsNullOrEmpty(ErrorCode); }
    }
    public class CommitResult<T> : CommitResult
    {
        public CommitResult(T value, ResultType resultType = ResultType.Ok, string? errorMessage = default, string? errorCode = default) : base(resultType, errorMessage, errorCode)
        {
            Value = value;
        }

        public T? Value { get; init; }
    }
    public class CommitResults<T> : CommitResult
    {
        public CommitResults(IEnumerable<T> value, ResultType resultType = ResultType.Ok, string? errorMessage = default, string? errorCode = default) : base(resultType, errorMessage, errorCode)
        {
            Value = value;
        }
        public IEnumerable<T>? Value { get; set; }
    }
    public enum ResultType
    {
        Ok,
        Empty,
        Invalid,
        Unauthorized,
        NotFound,
        InvalidValidation,
        Exception,
        Duplicated,
        InternalServerError,
        MethodNotAllowed,
        Others
    }
}