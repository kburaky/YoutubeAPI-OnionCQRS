﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using HepsiAPI.Application.Features.Brands.Commands.CreateBrand;
//using HepsiAPI.Application.Features.Brands.Queries.GetAllBrands;
using HepsiAPI.Application.Features.Products.Command.CreateProduct;
//using HepsiAPI.Application.Features.Products.Command.DeleteProduct;
//using HepsiAPI.Application.Features.Products.Command.UpdateProduct;
using HepsiAPI.Application.Features.Products.Queries.GetAllProducts;

namespace HepsiAPI.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await mediator.Send(new GetAllProductsQueryRequest());

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        //[HttpPost]
        ////public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest request)
        ////{
        ////    await mediator.Send(request);
        ////    return Ok();
        ////}
        //[HttpPost]
        //public async Task<IActionResult> DeleteProduct(DeleteProductCommandRequest request)
        //{
        //    await mediator.Send(request);
        //    return Ok();
        //}
        //[HttpPost]
        //public async Task<IActionResult> CreateBrand(CreateBrandCommandRequest request)
        //{
        //    await mediator.Send(request);
        //    return Ok();
        //}
        //public async Task<IActionResult> GetAllBrands()
        //{
        //    var response = await mediator.Send(new GetAllBrandsQueryRequest());
        //    return Ok(response);
        //}
    }
}
