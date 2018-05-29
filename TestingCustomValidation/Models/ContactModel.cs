using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingCustomValidation.Models
{
    public class ContactModel
    {
        [CannotBeRedAttribute(ErrorMessage = "Only gmail accounts are allowed!")]
        public string Message { get; set; }
    }
}
