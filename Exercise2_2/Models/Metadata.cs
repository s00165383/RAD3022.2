using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise2_2.Models
{
    public class CustomerMetadata
    {
        public int Id;

        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(25, MinimumLength = 2)]
        public string FirstName;

        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(25, MinimumLength = 2)]
        public string LastName;

        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress]
        public string Email;
    }

    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer{}
}