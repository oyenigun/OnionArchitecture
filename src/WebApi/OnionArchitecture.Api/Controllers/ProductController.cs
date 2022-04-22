using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Commands;
using OnionArchitecture.Application.Features.Queries;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }
     
    [HttpGet(Name = "GetProductList")]
    public async Task<IActionResult> GetProductList()
    {
        return Ok(await _mediator.Send(new GetProductListQuery()));
    }

    [HttpPost(Name = "AddProduct")]
    public async Task<IActionResult> AddProduct(CreateProductCommand product )
    {
        return Ok(await _mediator.Send(product));
    }
}

