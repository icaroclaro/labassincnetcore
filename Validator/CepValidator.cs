using FluentValidation;
using labassincnetcore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labassincnetcore.Validator
{
    public class CepValidator: AbstractValidator<Cep>
    {
        public CepValidator()
        {
            RuleFor(x => x.IdCep).NotNull();
            RuleFor(x => x.IdCep).Length(8);
        }
    }
}
