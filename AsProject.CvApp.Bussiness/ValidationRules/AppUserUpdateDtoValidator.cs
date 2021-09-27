using ASProject.CvApp.DTO.DTO.AppUserListDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Business.ValidationRules
{
    public class AppUserUpdateDtoValidator:AbstractValidator<AppUserUpdateDto>
    {
        public AppUserUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Alanı Boş geçilemez");
            
        }
    }
}
