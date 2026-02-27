
namespace Application.DTOs.Auth
{
    public class AuthResponse
    {
        public string AccessToken { get; set; } 
        //O token de acesso é gerado após a autenticação bem-sucedida e é usado para autorizar o acesso a recursos protegidos na aplicação. Ele geralmente tem um tempo de vida curto para aumentar a segurança.
        public string RefreshToken { get; set; }
        //O token de atualização é usado para obter um novo token de acesso sem exigir que o usuário faça login novamente. Ele tem um tempo de vida mais longo do que o token de acesso e é armazenado com segurança no cliente.
        public DateTime ExpiresAt { get; set; }
        //A data e hora de expiração do token de acesso, usada para determinar quando o token precisa ser renovado.
    }
}

//Obs: Os DTOs possuem os métodos get e set públicos pois não possuem lógica de negócios e são usados apenas para transferência de dados entre camadas. Isso facilita a serialização e deserialização dos objetos, além de permitir que as bibliotecas de mapeamento (como AutoMapper) funcionem corretamente.