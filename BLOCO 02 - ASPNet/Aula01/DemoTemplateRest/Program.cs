var builder = WebApplication.CreateBuilder(args); //construtor para adicionar infos e a partir dele é executado todo o ambiente do ASPNet core

// Add services to the container. || é configurado serviços que serão consumidos no projeto

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline. || entra dados de um lado na requisição e sai do outro lado e no meio do caminho há várias etapas de processamento de dados
if (app.Environment.IsDevelopment())
{                                       // se o ambiente é de desenvolvimento então configure esses dois caras que ativam o gerador de doc que foi configurado antes.
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();                // se chegar uma requisição http, redirecione para uma requisição https automaticamente 

app.UseAuthorization();                  // habilitar uso de autenticação de autorização 
 
app.MapControllers();                   // configura o roteador de urls para métodos dos controladores

app.Run();                             // dispara a execução do programa
