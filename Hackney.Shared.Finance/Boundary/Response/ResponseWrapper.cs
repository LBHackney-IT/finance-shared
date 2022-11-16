namespace Hackney.Shared.Finance.Boundary.Response
{
    public class ResponseWrapper<T> where T : class
    {
        public T Value { get; set; }

        public bool IsEmpty
        {
            get
            {
                return this.Value is null;
            }
        }

        public ResponseWrapper(T nullableValue) => Value = nullableValue;
    }
}
