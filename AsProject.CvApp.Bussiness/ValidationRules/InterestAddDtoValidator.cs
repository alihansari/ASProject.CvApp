using ASProject.CvApp.DTO.DTO.InterestDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class InterestAddDtoValidator:AbstractValidator<InterestAddDto>
    {
        public InterestAddDtoValidator()
        {
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama Alanı Boş Geçilemez");
        }
    }
}
