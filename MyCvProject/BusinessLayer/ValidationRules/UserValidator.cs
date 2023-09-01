using FluentValidation;
using MyCvProjectBusinessLayer.Concrate;
using MyCvProjectEntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectBusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(usr => usr.Email).NotEmpty().WithMessage("Email can not be empty");
            RuleFor(usr => usr.FullName).NotEmpty().WithMessage("Full name can not be empty");
            RuleFor(usr => usr.Email).MinimumLength(3).WithMessage("Full name must be more than 3 characters");
            RuleFor(usr => usr.Password).NotEmpty().WithMessage("Password can not be empty");
        }
    }
}
