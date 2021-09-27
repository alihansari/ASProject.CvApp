using ASProject.CvApp.DTO.DTO.SkillDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class SkillAddDtoValidator : AbstractValidator<SkillAddDto>
    {
        public SkillAddDtoValidator()
        {
            RuleFor(I => I.Description).NotEmpty().WithMessage("Başlık boş Bırakılamaz");
        }

    }
}
