using System;
using System.Collections.Generic;
using System.Text;

namespace Ultra.AdminApi.UseCases.Products.Dtos
{
    public class AddProductDto
    {
        public string Name  { get; set; }
        public decimal Price { get; set; }
    }
}
