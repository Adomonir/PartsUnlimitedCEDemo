using System.Threading;

namespace PartsUnlimited.Models
{
//123
    public class Request
    {
        public CancellationToken CancellationToken { get; set; }
        public int Id { get; set; }
    }
}
