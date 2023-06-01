using System.ComponentModel.DataAnnotations;

namespace abp-test.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}