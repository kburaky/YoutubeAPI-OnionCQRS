using MediatR;
using HepsiAPI.Application.Interfaces.RedisCache;

namespace HepsiAPI.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>
    {
        public string CacheKey => "GetAllProducts";

        public double CacheTime => 60;
    }
}
