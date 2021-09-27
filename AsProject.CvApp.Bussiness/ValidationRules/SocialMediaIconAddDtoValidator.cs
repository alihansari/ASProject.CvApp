using ASProject.CvApp.DTO.DTO.SocialMediaIconDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class SocialMediaIconAddDtoValidator:AbstractValidator<SocialMediaIconAddDto>
    {
        public SocialMediaIconAddDtoValidator()
        {
            
            RuleFor(I => I.Icon).NotEmpty().WithMessage("Icon Alanı Boş bırakılamaz");
            RuleFor(I => I.Link).NotEmpty().WithMessage("Link Alanı Boş bırakılamaz");
        }
    }
}
