namespace Aula13Uber
{
    public class Corrida
    {
        private string LocalInicio { get; set; }
        private string LocalChegada { get; set; }
        private string StatusCorrida { get; set; }
        private string Motorista { get; set; }
        private string Pasageiro { get; set; }

        private string Cancelar(){
            return "Corrida cancelada";
        }
    }
}