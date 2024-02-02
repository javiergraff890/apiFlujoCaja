namespace ApiFlujoCajas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/NuevaCaja", (string name, Decimal saldo) =>
                $"Voy a insertar nombre = {name} y saldo {saldo}"
            );
            app.Run();
        }
    }
}
