using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.Business.Concrete;
using ASProject.CvApp.Business.ValidationRules;
using ASProject.CvApp.DataAccess.Abstract;
using ASProject.CvApp.DataAccess.Concrete.Dapper;
using ASProject.CvApp.DTO.DTO.AppUserListDto;
using ASProject.CvApp.DTO.DTO.CertificationDto;
using ASProject.CvApp.DTO.DTO.EducationDto;
using ASProject.CvApp.DTO.DTO.ExperienceDto;
using ASProject.CvApp.DTO.DTO.InterestDto;
using ASProject.CvApp.DTO.DTO.SkillDto;
using ASProject.CvApp.DTO.DTO.SocialMediaIconDto;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ASProject.CvApp.Business.IOC.Microsoft
{
    public static class MicrosoftDependicies
    {
        public static void AddCustomDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(con => new SqlConnection(configuration.GetConnectionString("connectionMssql")));
            services.AddScoped(typeof(IGenericRepository<>), typeof(DpGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped<IAppUserRepository, DpAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IProductRepository, DpProductRepository>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ISocialMediaIconRepository, DpSocialMediaIcon>();
            services.AddScoped<ISocialMediaIconService, SocialMediaIconManager>();
            

            services.AddTransient<IValidator<AppUserPasswordDto>, AppUserPasswordDtoValidator>();
            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<CertificationAddDto>, CertificationAddDtoValidator>();
            services.AddTransient<IValidator<CertificationUpdateDto>, CertificationUpdateDtoValidator>();
            services.AddTransient<IValidator<EducationAddDto>, EducationAddDtoValidator>();
            services.AddTransient<IValidator<EducationUpdateDto>, EducationUpdateDtoValidator>();
            services.AddTransient<IValidator<ExperienceAddDto>, ExperienceAddDtoValidator>();
            services.AddTransient<IValidator<ExperienceUpdateDto>, ExperienceUpdateDtoValidator>();
            services.AddTransient<IValidator<InterestAddDto>, InterestAddDtoValidator>();
            services.AddTransient<IValidator<InterestUpdateDto>, InterestUpdateDtoValidator>();
            services.AddTransient<IValidator<SkillAddDto>, SkillAddDtoValidator>();
            services.AddTransient<IValidator<SkillUpdateDto>, SkillUpdateDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconAddDto>, SocialMediaIconAddDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconUpdateDto>, SocialMediaIconUpdateDtoValidator>();
        }
    }
}
