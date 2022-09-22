using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Maganmakcore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете го вашето име")]
        [Display(Name = "Име")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете го вашето презиме")]
        [Display(Name = "Презиме")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете ја вашата адреса")]
        [StringLength(100)]
        [Display(Name = "Адреса 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Адреса 2")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете го вашиот поштенски код ")]
        [Display(Name = "Поштенски код")]
        [StringLength(10, MinimumLength = 4)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете го вашиот град")]
        [Display(Name = "Град")]
        [StringLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете ја вашата држава")]
        [Display(Name = "Држава")]
        [StringLength(50)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете го вашиот телефонски број")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Телефонски број")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете ја вашата email адреса")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Внесета ја email адресата во правилна форма")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
