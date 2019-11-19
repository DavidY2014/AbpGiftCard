using System.ComponentModel.DataAnnotations;

namespace AbpGiftCard.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}