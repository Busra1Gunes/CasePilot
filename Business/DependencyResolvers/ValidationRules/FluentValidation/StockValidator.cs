using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.ValidationRules.FluentValidation
{
    public class StockValidator : AbstractValidator<Stock>
    {
        public StockValidator()
        {
            RuleFor(p => p.StockName).MinimumLength(2);
            RuleFor(p => p.StockName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.SupplierID == 1);
            RuleFor(p => p.StockName).Must(StartWithA).WithMessage("Stock A harfi ile başlamalı");



        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
