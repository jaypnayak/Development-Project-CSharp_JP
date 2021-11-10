using Interview.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Interview.Web.Repositories;
using AutoMapper;
using Interview.Domain;

namespace Interview.Web.Controllers
{
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IPCatRepository _pcatRepository;
        private readonly IMapper _mapper;

        public ProductController(ILogger<ProductController> logger, IPCatRepository pcatRepository, IMapper mapper)
        {
            this._logger = logger;
            this._pcatRepository = pcatRepository;
            this._mapper = mapper;
        }
        // NOTE: Sample Action
        [HttpGet]
        [Route("search")]
        public async Task<IEnumerable<SearchResponseProductViewModel>> SearchProducts(SearchRequestProductViewModel request)
        {
            _logger.LogInformation($"Searching products");
            try
            {
                var domainRequest = _mapper.Map<Product>(request);
                var domainResponse = await _pcatRepository.GetProducts(domainRequest);
                return _mapper.Map<IEnumerable<SearchResponseProductViewModel>>(domainResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                throw;
            }
        }
    }
}
