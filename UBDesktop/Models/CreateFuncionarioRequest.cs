namespace UBDesktop.Models
{
    public class CreateFuncionarioRequest
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
