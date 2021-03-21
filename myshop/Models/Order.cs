using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        [Required (ErrorMessage ="Please enter your first name")]
        [Display(Name="First Name")]

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Last name")]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Street Address")]

        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter your Postcode")]
        [StringLength(5, MinimumLength =5)]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "Please enter your Phone")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }

    }
}
