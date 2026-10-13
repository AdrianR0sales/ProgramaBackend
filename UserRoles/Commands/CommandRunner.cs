using System;
using System.Threading.Tasks;

namespace UserRoles.Commands
{
    public static class CommandRunner
    {
        public static async Task<bool> TryRunAsync(string[] args, IServiceProvider provider)
        {
            // Aquí iría la lógica si quisieras ejecutar comandos desde la consola.
            // Al retornar 'false', le indicamos al Program.cs que continúe 
            // levantando la página web normalmente.
            return await Task.FromResult(false);
        }
    }
}