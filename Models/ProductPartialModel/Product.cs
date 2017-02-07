﻿using HtmlHelperLab.Models.CustomerValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperLab.Models.NorthWindModel
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product { }

    public class ProductMetaData {

        [HiddenInput(DisplayValue = false)]
        public object ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [Display(Name = "Product Name")]
        [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        [ExcludeChar("/.,!@#$%", ErrorMessage = "Name should not contain these chars: '/.,!@#$%'.")]
        [WordNum(3, ErrorMessage = "only three words maximum")]
        public object ProductName { get; set; }

        [UIHint("_SupplierDropDownList")]
        [Display(Name = "Supplier")]
        public object SupplierID { get; set; }

        [UIHint("_CategoryDropDownList")]
        [Display(Name = "Category")]
        public object CategoryID { get; set; }

        [Required(ErrorMessage = "Unit price is required.")]
        [DataType(DataType.Currency)]
        public object UnitPrice { get; set; }

       
    }
}