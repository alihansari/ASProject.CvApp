using ASProject.CvApp.DTO.DTO.EducationDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class EducationAddDtoValidator:AbstractValidator<EducationAddDto>
    {
        public EducationAddDtoValidator()
        {
            RuleFor(I => I.Title).NotEmpty().WithMessage("Başlık boş Bırakılamaz");
            RuleFor(I => I.SubTitle).NotEmpty().WithMessage("Alt Başlık boş Bırakılamaz");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama boş Bırakılamaz");
            RuleFor(I => I.StartDate).NotEmpty().WithMessage("Başlıngıç Tarihi boş Bırakılamaz");
        }
    }
}
