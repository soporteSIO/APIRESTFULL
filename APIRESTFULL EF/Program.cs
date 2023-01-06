using APIRESTFULL_EF.Context;
using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSqlServer<DefMtyContext>(builder.Configuration.GetConnectionString("SqlConnection"));

builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("*").AllowAnyHeader().AllowAnyHeader())
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsuario, UsuarioService>();
builder.Services.AddScoped<IUnidad, UnidadService>();
builder.Services.AddScoped<IOperador,OperadorService>();
builder.Services.AddScoped<IRecepcionUnidad, RecepcionUnidadService>();
builder.Services.AddScoped<IEstatusUnidad, EstatusUnidadService>();



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
