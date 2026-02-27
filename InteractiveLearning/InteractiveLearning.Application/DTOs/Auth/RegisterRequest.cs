
namespace Application.DTOs.Auth 
//DTOs são usados para transferir dados entre camadas, garantindo que apenas as informações necessárias sejam expostas e facilitando a manutenção do código
{
    public class RegisterRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } //A senha em texto puro é recebida aqui, mas será hashada antes de ser armazenada no banco de dados
    }
}
