// Esta es la clase que se va a ejecutar por defecto.

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios.

builder.Services.AddControllers();
// M�s info. sobre Swagger/OpenAPI en https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Especificar que todas las urls ser�n LowerCase.
builder.Services.AddRouting(routing => routing.LowercaseUrls = true);

var app = builder.Build();

// Configurar los pipelines de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Una minimal API Permite mapear una ruta desde ac�.
// Es lo que que estoy haciendo en controllers. La clase Program.cs deber�a solo encargarse de construir la configuraci�n, no 
// las rutas, para eso est� la capa de controllers. 
//  app.MapGet("/ejemplo", () =>
//  {
//      return "net 6";
//  });

app.MapControllers();

app.Run();
