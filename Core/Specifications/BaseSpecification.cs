using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {

         public BaseSpecification()
        {          
        }
        
        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria  {get; }
            
        // Initial neue leere Liste, damit includes angehangen werden können...
        public List<Expression<Func<T, object>>> Includes {get; } = new List<Expression<Func<T, object>>>();

        // hier können/werden includes an Liste angehangen
        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}