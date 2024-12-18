using HepsiAPI.Application.Bases;
using HepsiAPI.Application.Features.Products.Exceptions;
using HepsiAPI.Domain.Entities;

namespace HepsiAPI.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product> products, string requestTitle)
        {
            if (products.Any(x=>x.Title == requestTitle)) throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}
