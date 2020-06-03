namespace Aula9Calculadora
{
    public class Calculadoramedia : Calculadora
    {

        // Foi puxado as variaveis da superclasse para saber a media
            public int Media(int numero1, int numero2){
                return (numero1 + numero2)/ 2;
            }
    }
}