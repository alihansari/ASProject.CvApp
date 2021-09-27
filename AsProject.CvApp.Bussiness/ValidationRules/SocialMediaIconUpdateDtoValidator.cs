﻿using ASProject.CvApp.DTO.DTO.SocialMediaIconDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class SocialMediaIconUpdateDtoValidator:AbstractValidator<SocialMediaIconUpdateDto>
    {
        public SocialMediaIconUpdateDtoValidator()
        {
            
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Alanı Boş bırakılamaz");
            RuleFor(I => I.Icon).NotEmpty().WithMessage("Icon Alanı Boş bırakılamaz");
            RuleFor(I => I.Link).NotEmpty().WithMessage("Link Alanı Boş bırakılamaz");

        }
    }
}
