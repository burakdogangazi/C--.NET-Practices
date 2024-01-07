using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.DataAccess;
using WebApiDemo.Entities;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        IProductDal _productDal;

        public ProductsController(IProductDal productDal)
        {
            _productDal = productDal;
        }



        [HttpGet("")]
        public IActionResult Get()
        {
            var products = _productDal.GetList();

            return Ok(products);

        }
        //api/products/1 sadece 1 numaralı ürün gelir
        [HttpGet("{productId}")]
        public IActionResult Get(int productId)
        {


            try
            {
                var products = _productDal.Get(p => p.ProductId == productId);

                if (products == null)
                {
                    return NotFound("Cannot be found");
                }


                return Ok(products);
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
        //Postmanden bilgi gönderilebilir
        //public IActionResult Post([FromBody]Product product)
        //{
        //    return Ok();
        //    //From body ile data json formatında gelir gönderilen data submit ile json formatında olur
        //}

        public IActionResult Post( Product product)
        {

            try
            {
                _productDal.Add(product);
                return new StatusCodeResult(201);
            }
            catch 
            {

                throw;
            }

            

        }

        [HttpPut]
        public IActionResult Put(Product product)
        {

            try
            {
                _productDal.Update(product);
                return Ok(product);
            }
            catch
            {

                throw;
            }

            

        }

        [HttpDelete("{productId}")]
        public IActionResult Delete(int productId)
        {

            try
            {
                _productDal.Delete(new Product {ProductId = productId});
                return Ok();
            }
            catch
            {

                
            }

            return BadRequest();

        }

        [HttpGet("GetProductsDetails")]
        public IActionResult GetProductsWithDetails()
        {
            try
            {
               var result =  _productDal.GetProductWithDetails();
                return Ok(result);

            }
            catch 
            {

               

            }
            return BadRequest();



        }




    }
}
