using DemoHelloWorldRest.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DemoHelloWorldRest.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase 
{
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger)
    {
        _logger = logger;
    }

// GET .../helloworld
    [HttpGet]
    public string Get()
    {
        _logger.LogInformation("GET /helloworld");
        return "Hello World!";
    }

    //GET .../helloworld/vitoria
    [HttpGet("{nome}")]
    public string Get(string nome)
    {
        _logger.LogInformation("GET /helloworld/{nome}");
        return $"Hello, {nome}!";
    }

    //GET .../helloworld/query?nome=vitoria
    [HttpGet("query")]
    public string GetQuery(string nome)
    {
        _logger.LogInformation("GET /helloworld/query?nome=valor");
        return $"Hello, {nome}!";
    }

    //POST .../helloworld
    [HttpPost]
    public string Post([FromBody] string nome)
    {
        _logger.LogInformation("POST /helloworld");
        return $"Hello, {nome}!";
    }

    //POST .../helloworld/pessoa
    [HttpPost("pessoa")]
    public string Post(Pessoa umaPessoa)
    {
        _logger.LogInformation("POST /helloworld/pessoa");
        _logger.LogInformation($"umaPessoa.nome = {umaPessoa.Nome}");
        _logger.LogInformation($"umaPessoa.idade = {umaPessoa.Idade}");
        return $"Hello, {umaPessoa.Nome}!";
    }
}