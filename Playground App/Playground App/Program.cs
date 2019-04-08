using System.Threading.Tasks;
using Refit;

namespace Playground_App
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var refitInterface = RestService.For<IRefitInterface>("http://www.google.com/");

            await refitInterface.PingAsync();
        }
    }
    public interface IRefitInterface
    {
        [Get("")]
        Task PingAsync();
    }
}
