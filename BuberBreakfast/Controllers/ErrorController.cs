using Microsoft.AspNetCore.Mvc;
namespace BuberBreakfast.controllers;

public class ErrorController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}