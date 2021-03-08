using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Id).NotNull();
            RuleFor(u => u.FirstName).MinimumLength(3);
            RuleFor(u => u.LastName).MinimumLength(2);
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).Must(EndsWithCom).WithMessage("mail adresiniz .com ile bitmelidir");
        }

        private bool EndsWithCom(string arg) 
        {
            return arg.EndsWith(".com");
        }
    }
}
