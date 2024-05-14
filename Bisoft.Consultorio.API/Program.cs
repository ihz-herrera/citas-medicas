using Bisoft.Consultorio.Aplicacion.Servicio;
using BISoft.Consultorio.Dominio.Contratos;
using BISoft.Consultorio.Infraestructura.Repositorios;
using BISoft.Consultorio.Infraestructura.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System.Collections.ObjectModel;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddScoped<ClienteService>(

//        opt =>
//        {
//            var context = opt.GetRequiredService<Context>();

//            return new ClienteService(new ClientesRepository(context), new DoctoresRepository(context));

//        }

//    );

// Configurar los sink de Serilog
var columnOptions = new ColumnOptions
{
    AdditionalColumns = new Collection<SqlColumn>
    {
        new SqlColumn { ColumnName = "UserName", DataType = SqlDbType.NVarChar, DataLength = 50 }
    }
};

var connectionString = "server = .\\MSSQLServer01; Initial Catalog=ConsultorioDB; Trusted_Connection=true; Encrypt=false";

Log.Logger = new LoggerConfiguration()
   .MinimumLevel.Debug()
      .WriteTo.Console()
      .WriteTo.MSSqlServer(
        connectionString: connectionString,
        sinkOptions: new MSSqlServerSinkOptions { TableName = "Logs", AutoCreateSqlTable = true }
        //,columnOptions: columnOptions
    )
   .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Warning)
   .CreateLogger();

//Configurar Serilog



builder.Services.AddScoped<ClienteService>();

builder.Services.AddScoped<DoctorService>();
builder.Services.AddScoped<IDoctoresRepository,DoctoresRepository>();

builder.Services.AddScoped<IClientesRepository, ClientesRepository>();

builder.Services.AddDbContext<Context>(
    options=>
    options.UseSqlServer(connectionString)
    //.UseLazyLoadingProxies()
    //options.UseSqlite("data source = C:\\BaseDatos\\consultorio.db")
    );

builder.Services.AddControllersWithViews()
               .AddNewtonsoftJson(options =>
               options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
           );


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//! Add Serilog
builder.Services.AddSerilog();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
