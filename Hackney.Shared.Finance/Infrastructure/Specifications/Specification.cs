using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Hackney.Shared.Finance.Infrastructure.Specifications
{
    public abstract class Specification<T> : ISpecification<T> where T : class
    {
        protected Specification([NotNull] Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; }
    }
}
