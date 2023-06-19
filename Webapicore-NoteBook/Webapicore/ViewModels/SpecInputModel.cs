using System.ComponentModel.DataAnnotations;

namespace Webapicore.ViewModels
{
    public class SpecInputModel
        {
            [Required, StringLength(30)]
            public string SpecName { get; set; } = default!;
            [Required, StringLength(50)]
            public string Value { get; set; } = default!;
        }
    }
