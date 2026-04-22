using SupportAI.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

// 1. ADICIONE ESTA LINHA: Registra os serviços de Controller na memória
builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Comente ou apague esta linha se estiver testando localmente sem SSL/HTTPS no n8n
// app.UseHttpsRedirection(); 

// 2. ADICIONE ESTA LINHA: Ativa o mapeamento das rotas dos Controllers
app.MapControllers();

// O código do WeatherForecast pode continuar aí embaixo, não tem problema, 
// mas o importante são as duas linhas acima.

app.Run();

// Mantenha o record WeatherForecast aqui embaixo...