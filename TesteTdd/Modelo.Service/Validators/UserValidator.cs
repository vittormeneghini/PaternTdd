using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c).NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object");
                });


            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("É necessário informar um CPF.")
                .NotNull().WithMessage("É necessário informar um CPF.");

            RuleFor(c => c.BirthDate)
                .NotEmpty().WithMessage("É necessário informar uma data de nascimento.")
                .NotNull().WithMessage("É necessário informar uma data de nascimento.");

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("É necessário informar um nome.")
                .NotNull().WithMessage("É necessário informar um nome.");

        }


    }
}
