namespace ResultHandler
{
    public class CommitResult
    {
        public string? ErrorMessage { get; set; }
        public int? ErrorCode { get; set; }
        public ResultType ResultType { get; set; }
        public bool IsSuccess { get => !ErrorCode.HasValue; }
    }
    public class CommitResult<T> : CommitResult
    {
        public T? Value { get; set; }
    }
    public class CommitResults<T> : CommitResult
    {
        public IEnumerable<T>? Value { get; set; }
    }
    public enum ResultType
    {
        Ok,
        Invalid,
        Unauthorized,
        PartialOk,
        NotFound,
        PermissionDenied,
        Unexpected,
        Exception,
        Duplicated
    }
}
