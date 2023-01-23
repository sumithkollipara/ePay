using CustomerManagement.Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Common.Models
{
    [Serializable]
    public class CustomerModel : BaseModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [MinValue(19)]
        public int Age { get; set; }
    }
}
