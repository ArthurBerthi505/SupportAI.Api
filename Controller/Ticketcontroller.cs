using Microsoft.AspNetCore.Mvc;
using SupportAI.Api;

namespace SupportAI.Api.Controllers;

[ApiController]
[Route("api/tickets")]
public class TicketsController : ControllerBase
{
    [HttpPost]
    public IActionResult ReceberAnalise([FromBody] TicketDto ticket)
    {
        // 1. Isso aqui sai no seu terminal do VS Code
        Console.WriteLine("\n========================================");
        Console.WriteLine("NOVO TICKET PROCESSADO PELA IA");
        Console.WriteLine($"CLIENTE: {ticket.ClienteEmail}");
        Console.WriteLine($"ANÁLISE: {ticket.AnaliseIa}");
        Console.WriteLine("========================================\n");

        return Ok(new
        {
            status = "Sucesso",
            mensagem = "Dados da IA recebidos pelo Backend!",
            cliente = ticket.ClienteEmail
        });
    }
}