namespace Aula13Uber
{
    public class Usuario
    {
        public string Nome { get; set; }        
        private string login = "paulo@gmail.com";
        private string senha = "123456789";
        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        public bool Login(string login, string senha){
            
            if(this.login == login && this.senha == senha){
                TokenLogin = "showshowshowshowmaravilhosooo125217472362365895";
                return true;
            }

            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }
    }
}