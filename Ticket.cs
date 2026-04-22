using System.ComponentModel.DataAnnotations;

namespace SupportAI.Api;

public class Ticket
{
    [Key] // Isso diz ao banco que o Id é a Chave Primária (Auto-incremento)
    public int Id { get; set; }

    public string ClienteEmail { get; set; } = string.Empty;

    public string AnaliseIa { get; set; } = string.Empty;

    public DateTime DataCriacao { get; set; } = DateTime.Now; // Salva a hora exata que o ticket chegou
}