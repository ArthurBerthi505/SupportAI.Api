using Microsoft.AspNetCore.Mvc;
using SupportAI.Api;

namespace SupportAI.Api.Controllers;

[ApiController]
[Route("api/tickets")]
public class TicketsController : ControllerBase
{
    private readonly AppDbContext _context;

    // Construtor: Aqui o .NET "injeta" o banco de dados automaticamente
    public TicketsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult ReceberAnalise([FromBody] TicketDto ticketRecebido)
    {
        // 1. Transformamos o DTO (que veio do n8n) na Entidade (que vai pro banco)
        var novoTicket = new Ticket
        {
            ClienteEmail = ticketRecebido.ClienteEmail,
            AnaliseIa = ticketRecebido.AnaliseIa
            // A DataCriacao e o Id são gerados automaticamente!
        };

        // 2. Adiciona na memória e salva no banco (O EF Core faz o INSERT INTO aqui)
        _context.Tickets.Add(novoTicket);
        _context.SaveChanges();

        // 3. Log no terminal para você acompanhar
        Console.WriteLine($"\n✅ [BANCO DE DADOS] Ticket ID {novoTicket.Id} salvo com sucesso para o cliente {novoTicket.ClienteEmail}!");

        // 4. Retorna para o n8n informando o ID real que foi gravado
        return Ok(new
        {
            status = "Sucesso",
            mensagem = "Ticket gravado permanentemente no SQLite!",
            id_banco = novoTicket.Id
        });
    }
    [HttpGet]
    public IActionResult ListarTickets()
    {
        // Vai à base de dados, pega em todos os tickets e transforma numa lista
        var todosOsTickets = _context.Tickets.ToList();

        return Ok(todosOsTickets);
    }
}