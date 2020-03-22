﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Application.Validators
{
    public static class ValidatorExtension
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                .NotEmpty()
                .MinimumLength(6)
                .WithMessage("Password must be at least 6 characters")
                .Matches("[A-Z]")
                .WithMessage("Password must contain 1 uppercase character")
                .Matches("[a-z]")
                .WithMessage("Password must have at least 1 lowercase character")
                .Matches("[0-9]")
                .WithMessage("Password must contain a number")
                .Matches("[^a-zA-Z0-9]")
                .WithMessage("Password must contain at least 1 non alphanumeric character");
            return options;
        }
    }
}
