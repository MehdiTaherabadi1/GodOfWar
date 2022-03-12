using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProductManagement.Domain.Models.Products.ProductConstraint
{
    public class SelectiveConstraint : ProductConstraint
    {
        private List<Options> _optionses;
        public IReadOnlyList<Options> Options => _optionses.AsReadOnly();

        public SelectiveConstraint(Constraint.Constraint fuelType, List<Options> options)
        {
            GuardAgainstDuplicateValueIn(options);

            this._optionses = options;
        }

        private static void GuardAgainstDuplicateValueIn(List<Options> options)
        {
            var hasDuplicateValue = options.GroupBy(product => product.Value, (key, value) => new { key, count = value.Count() })
                .Any(group => group.count > 1);

            if (hasDuplicateValue)
                throw new Exception();
        }
    }
}