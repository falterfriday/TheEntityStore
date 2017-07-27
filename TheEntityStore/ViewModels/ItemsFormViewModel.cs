using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace TheEntityStore.ViewModels
{
    public class ItemsFormViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public byte Category { get; set; }

        public IEnumerable Categories { get; set; }
    }
}