﻿using EComm.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomm.Web.ViewModels
{
    public class ProductEditViewModel
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Range(1, 500)]
        public decimal? UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }

        public int SupplierId { get; set; }
        public List<SelectListItem> Suppliers { get; set; }
    }
}
