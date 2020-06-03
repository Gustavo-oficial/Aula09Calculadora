namespace Aula9Calculadora
{
    public class Calculadora
    {
        public int numero1 { get; set; }

        public int numero2 { get; set; }

        // Pode haver casos de somas de mais de dois numeros
        private int numero3 { get; set; }

        public int Somar(int numero1, int numero2){
            return numero1 + numero2;
        }
        public int Subtrair(int numero1, int numero2){
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2){
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2){
            return numero1/numero2;
        }

    }
}