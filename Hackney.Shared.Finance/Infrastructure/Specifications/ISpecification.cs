using System;
using System.Linq.Expressions;

namespace Hackney.Shared.Finance.Infrastructure.Specifications
{
    public interface ISpecification<T> where T : class
    {
        Expression<Func<T, bool>> Criteria { get; }
    }
}
