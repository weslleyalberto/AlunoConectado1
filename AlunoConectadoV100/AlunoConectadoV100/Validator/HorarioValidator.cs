using AlunoConectadoV100.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlunoConectadoV100.Validator
{
    public class HorarioValidator : AbstractValidator<Horario>
    {
        public HorarioValidator()
        {
            RuleFor(c => c.Semana).Must(n => ValidateStringEmpty(n)).WithMessage("A Semana não pode ser Vazia");
            RuleFor(c => c.Primeira_Aula).Must(n => ValidateStringEmpty(n)).WithMessage("Primeira Aula não pode ser Vazia");
            RuleFor(c => c.Segunda_Aula).Must(n => ValidateStringEmpty(n)).WithMessage("Segunda Aula não pode ser Vazia");
            RuleFor(c => c.Terceira_Aula).Must(n => ValidateStringEmpty(n)).WithMessage("Terceira Aula não pode ser Vazia");
            RuleFor(c => c.Quarta_Aula).Must(n => ValidateStringEmpty(n)).WithMessage("Quarta Aula não pode ser Vazia");
            RuleFor(c => c.Quinta_Aula).Must(n => ValidateStringEmpty(n)).WithMessage("Quinta Aula não pode ser Vazia");
        }
        bool ValidateStringEmpty(string stringValue)
        {
            if (!string.IsNullOrEmpty(stringValue))
            {
                return true;
            }
            return false;
        }
    }
}
