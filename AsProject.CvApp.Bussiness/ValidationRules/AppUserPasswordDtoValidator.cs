using ASProject.CvApp.DTO.DTO.AppUserListDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class AppUserPasswordDtoValidator:AbstractValidator<AppUserPasswordDto>
    {
        public AppUserPasswordDtoValidator()
        {
            RuleFor(I => I.Password).NotEmpty().WithMessage("Parola Boş Geçilemez");
            RuleFor(I => I.ConfirmPassword).NotEmpty().WithMessage("Parola Tekrar Boş Geçilemez");
            RuleFor(I => I.ConfirmPassword).Equal(I=>I.Password).WithMessage("Parolar Uyuşmuyor");
        }
    }
}
