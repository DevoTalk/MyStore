﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Display(Name = "دسته بندی")]
    public class Category : Base
    {
        [Required(ErrorMessage = "نام دسته بندی الزامی است")]
        [Display(Name = "نام دسته بندی")]
        [MaxLength(100, ErrorMessage = "نام دسته بندی نمی تواند بیشتر از 100 کاراکتر باشد")]
        public string Name { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "محصولات")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
