using System.Collections.Generic;
using System.Linq;

namespace Hackney.Shared.Finance.Boundary.Response
{
    public class ResponseWrapper<T> where T : class
    {
        public T Value { get; set; }

        public bool IsEmpty
        {
            get
            {
                if (this.Value is IEnumerable<object>)
                {
                    return !(this.Value as IEnumerable<object>).Any();
                }
                return this.Value is null;
            }
        }

        public ResponseWrapper(T nullableValue) => Value = nullableValue;
    }
}
