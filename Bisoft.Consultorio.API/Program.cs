using Bisoft.Consultorio.Aplicacion.Servicio;
using BISoft.Consultorio.Dominio.Contratos;
using BISoft.Consultorio.Infraestructura.Repositorios;
using BISoft.Consultorio.Infraestructura.Contexto;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ClienteService>(
        
        opt=>
        {             
            var context = opt.GetRequiredService<Context>();
                   
            return new ClienteService(new ClientesRepository(context));
        
        }
    
    );

builder.Services.AddScoped<IClientesRepository, ClientesRepository>();

builder.Services.AddDbContext<Context>(
    options=>
    options.UseSqlServer("server = .\\MSSQLServer01; Initial Catalog=ConsultorioDB; Trusted_Connection=true; Encrypt=false")
    //options.UseSqlite("data source = C:\\BaseDatos\\consultorio.db")
    );




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
