using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.Surname).NotEmpty();
            RuleFor(p => p.UserName).NotEmpty();
           // RuleFor(p => p.UnitPrice).GreaterThan(0);
         //   RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.SupplierID == 1);
           // RuleFor(p => p.Password).Must(StartWithA).WithMessage("sifre A harfi ile başlamalı");



        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
