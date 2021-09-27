using ASProject.CvApp.DTO.DTO.CertificationDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class CertificationAddDtoValidator:AbstractValidator<CertificationAddDto>
    {
        public CertificationAddDtoValidator()
        {

            RuleFor(I => I.Description).NotEmpty().WithMessage("Sertifika alanı boş geçilemez");
        }
    }
}
