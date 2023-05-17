using System.ComponentModel.DataAnnotations;

namespace BlzrorWebBookApp.Data
{
    public class UserInputData
    {
        [Required]
        public string BookTitle { get; set; }

    }

}
