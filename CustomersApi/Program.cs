// Esta es la clase que se va a ejecutar por defecto.

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

// Una minimal API Permite mapear una ruta desde acá.
// Es lo que que estoy haciendo en controllers. La clase Program.cs debería solo encargarse de construir la configuración, no 
// las rutas, para eso está la capa de controllers. 
//  app.MapGet("/ejemplo", () =>
//  {
//      return "net 6";
//  });

app.MapControllers();

app.Run();
