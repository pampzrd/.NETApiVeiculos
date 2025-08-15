var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Frodo!");

app.MapPost("/login", (LoginDTO loginDto)=>{
    if (loginDto.Email == "adm@teste.com" && loginDto.Senha == "123456")
    {
        return Results.Ok("Login efetuado com sucesso!");
    }
    else
    {
        return Results.Unauthorized();
    }

});

app.Run();

public class LoginDTO
{
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
}