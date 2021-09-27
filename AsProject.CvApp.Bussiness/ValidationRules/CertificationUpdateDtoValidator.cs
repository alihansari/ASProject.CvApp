using ASProject.CvApp.DTO.DTO.CertificationDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class CertificationUpdateDtoValidator:AbstractValidator<CertificationUpdateDto>
    {
        public CertificationUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Alanı Boş geçilemez");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Sertifika alanı boş geçilemez");
        }
    }
}
