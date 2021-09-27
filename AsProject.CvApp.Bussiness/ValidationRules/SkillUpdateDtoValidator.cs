using ASProject.CvApp.DTO.DTO.SkillDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class SkillUpdateDtoValidator:AbstractValidator<SkillUpdateDto>
    {
        public SkillUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Alanı Boş Geçilemez");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama Alanı Boş Geçilemez");
        }
    }
}
