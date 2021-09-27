using ASProject.CvApp.DTO.DTO.InterestDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class InterestUpdateDtoValidator:AbstractValidator<InterestUpdateDto>
    {
        public InterestUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Alanı boş Geçilemez");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama Alanı Boş Geçilemez");
        }
    }
}
