using NUnit.Framework.Internal.Commands;
using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;

namespace GameControllerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestRetoFrase1()
        {
            Frase fraseOriginal = new Frase("Frase de ejemplo", "Esta es una frase de ejemplo", 3, 10, 5, true);
            string frase = fraseOriginal.Enunciado;
            string dificultad = "facil";
            double porcentaje = 0.7;

            string result = GameController.QuitarLetras(fraseOriginal, dificultad);

            Assert.That(result.Length, Is.EqualTo(frase.Length));

            int numLetrasOcultasObtenidas = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '_'){ numLetrasOcultasObtenidas++;}
            }

            Assert.That(numLetrasOcultasObtenidas, Is.EqualTo((int)(frase.Length * porcentaje))); // Verifica que el número de letras ocultas es el esperado
        }
        /**
                [Test]
                public void TestRetoFrase2()
                {
                    Frase fraseOriginal = new("Frase de ejemplo", "Esta es una frase de ejemplo", 3, 10, 5, true);
                    string frase = fraseOriginal.Enunciado;
                    string dificultad = "medio";
                    double porcentaje = 0.8;

                    string result = GameController.QuitarLetras(fraseOriginal, dificultad);

                    Assert.That(result.Length, Is.EqualTo(frase.Length));

                    int numLetrasOcultasObtenidas = 0;

                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] == '_') { numLetrasOcultasObtenidas++; }
                    }

                    Assert.That(numLetrasOcultasObtenidas, Is.EqualTo((int)(frase.Length * porcentaje))); // Verifica que el número de letras ocultas es el esperado
                }

                [Test]
                //public void TestRetoFrase3()
                {
                    Frase fraseOriginal = new Frase("Frase de ejemplo", "Esta es una frase de ejemplo", 3, 10, 5, true);
                    string frase = fraseOriginal.Enunciado;
                    string dificultad = "dificil";
                    double porcentaje = 0.9;

                    Console.WriteLine(frase + " - " + dificultad + " - " + porcentaje);

                    string result = "Esta es una frase de ejemplo"; //GameController.QuitarLetras(fraseOriginal, dificultad);

                    Assert.That(result.Length, Is.EqualTo(frase.Length));

                    int numLetrasOcultasObtenidas = 0;

                    Console.WriteLine(numLetrasOcultasObtenidas);

                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] == '_') { numLetrasOcultasObtenidas++; }
                    }

                    Assert.That(numLetrasOcultasObtenidas, Is.EqualTo((int)(frase.Length * porcentaje))); // Verifica que el número de letras ocultas es el esperado
        }**/

    }

}