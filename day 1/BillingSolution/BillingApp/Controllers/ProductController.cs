﻿using BillingApp.Exceptions;
using BillingApp.Interfaces;
using BillingApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BillingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _productService.GetProducts();
                return Ok(result);
            }
            catch (NoProductsAvailableException e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }
        [Authorize(Roles = "StoreManager")]
        [HttpPost]
        public ActionResult Create(Product product)
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _productService.Add(product);
                return Ok(result);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }
    }
}
