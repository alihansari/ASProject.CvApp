﻿using ASProject.CvApp.DTO.DTO.ExperienceDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class ExperienceUpdateDtoValidator:AbstractValidator<ExperienceUpdateDto>
    {
        public ExperienceUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Boş Bırakılamaz");
            RuleFor(I => I.Title).NotEmpty().WithMessage("Başlık boş Bırakılamaz");
            RuleFor(I => I.SubTitle).NotEmpty().WithMessage("Alt Başlık boş Bırakılamaz");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama boş Bırakılamaz");
            RuleFor(I => I.StartDate).NotEmpty().WithMessage("Başlıngıç Tarihi boş Bırakılamaz");
        }
    }
}
