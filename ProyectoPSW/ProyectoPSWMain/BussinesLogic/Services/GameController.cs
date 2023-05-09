using ProyectoPSWMain.BussinesLogic.Services;
using ProyectoPSWMain.Entities;
using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ProyectoPSWMain.Services
{
    public class GameController : IGameController
    {
        private string[] enlaces = { "https://www.un.org/sustainabledevelopment/es/poverty/", "https://www.un.org/sustainabledevelopment/es/hunger/",
        "https://www.un.org/sustainabledevelopment/es/health/", "https://www.un.org/sustainabledevelopment/es/education/", "https://www.un.org/sustainabledevelopment/es/gender-equality/",
        "https://www.un.org/sustainabledevelopment/es/water-and-sanitation/", "https://www.un.org/sustainabledevelopment/es/energy/", "https://www.un.org/sustainabledevelopment/es/economic-growth/",
        "https://www.un.org/sustainabledevelopment/es/infrastructure/", "https://www.un.org/sustainabledevelopment/es/inequality/", "https://www.un.org/sustainabledevelopment/es/cities/",
        "https://www.un.org/sustainabledevelopment/es/sustainable-consumption-production/", "https://www.un.org/sustainabledevelopment/es/climate-change-2/",
        "https://www.un.org/sustainabledevelopment/es/oceans/", "https://www.un.org/sustainabledevelopment/es/biodiversity/", "https://www.un.org/sustainabledevelopment/es/peace-justice/",
        "https://www.un.org/sustainabledevelopment/es/globalpartnerships/"};
        public GameController() 
        {
            retos = new List<Reto>();
            retosAcertados= new List<Reto>();
            retosJugados = new List<Reto>();
        }

        private Partida partida;
        private int error;
        private bool consolidado;
        private int index;
        private int pistasDisponibles;
        private List<Reto> retos;
        private List<Reto> retosAcertados;
        private List<Reto> retosJugados;
        private IPuntosStrategy puntosStrategy;
        private int puntuacionReto;


        public void UpdateError()
        {
            this.error = index;
        }
        public int GetPuntuacionPartida() { return puntuacionReto; }
        public int GetError() { return error; }
        public bool IsConsolidado() { return consolidado; }
        public void Consolidar()
        {
            this.consolidado = true;
            this.partida.PuntuacionConsolidada = this.partida.PuntuacionPartida;
        }
        public void CrearPartida(int nivel)
        {
            if (nivel < 0 || nivel > 4) throw new ServiceException("The level is not within the possible ones");
            Reset();
            partida = new Partida(nivel);
        }

        public Partida GetPartidaActual()
        {
            return partida;
        }
        public void SetPartidaActual(Partida partida)
        {
            this.partida = partida;
        }
        public int[] GetDifficultyArray()
        {
            int level = partida.Nivel;
            if (level > 4) throw new ServiceException("Difficulty level does not exist!");
            switch (level)
            {
                case 0: return new int[] { 1, 1, 1, 1, 1, 2, 2, 2, 3, 3 };
                case 1: return new int[] { 1, 1, 1, 1, 2, 2, 2, 3, 3, 3 };
                case 2: return new int[] { 1, 1, 1, 2, 2, 2, 2, 3, 3, 3 };
                case 3: return new int[] { 1, 1, 2, 2, 2, 2, 3, 3, 3, 3 };
                case 4: return new int[] { 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 };
            }

            return null;
        }

        public bool GetConsolidado()
        {
            return this.consolidado;
        }

        public int GetIndex()
        {
            return this.index;
        }

        public string EnlaceInteres(int ods)
        {
            return enlaces.ElementAt(ods - 1);
        }

        private void Reset()
        {
            this.index = 0;
            this.consolidado = false;
            this.error = -1;
            this.partida = null;
            this.pistasDisponibles = 3;
        }

        public void SetRetos(List<Reto> retos)
        {
            this.retos = retos;
        }



        protected void NextReto()
        {
            this.index++;
        }

        public Reto GetReto()
        {
            return retos[this.index];
        }
        

        public void AddRetoRetosJugados()
        {
            retosJugados.Add(retos[this.index]);
        }

        public void RetoAcertado()//aqui se usa el plantilla 
        {
            Reto reto = this.retos[this.index];
            NextReto();
            partida.PuntuacionPartida += this.puntuacionReto; //Strategy
            retosAcertados.Add(reto);
        }

        /**
        public void SetPuntosStrategy()
        {
            Reto reto = this.retos[this.index];
            int i = reto.Dificultad;
            if (i == 1) { context.SetStrategy(new EasyStrategy()); }
            else if (i == 2) { context.SetStrategy(new MiddleStrategy()); }
            else if (i == 3) { context.SetStrategy(new HardStrategy()); }
        }
        **/

        public void RetoFallado()
        {
            UltimoRetoFallado();
            RetoExtra();
        }

        public void UltimoRetoFallado()
        {
            Reto reto = this.retos[this.index];
            int nuevaPuntuacionConsolidada = partida.PuntuacionConsolidada - puntuacionReto * 2;
            partida.PuntuacionConsolidada = nuevaPuntuacionConsolidada < 0 ? 0 : nuevaPuntuacionConsolidada;

            int nuevaPuntuacionActual = partida.PuntuacionPartida - puntuacionReto * 2;
            partida.PuntuacionPartida = nuevaPuntuacionActual < 0 ? 0 : nuevaPuntuacionActual;
        }

        protected void RetoExtra()
        {
            this.error = this.index;
            int dificultad = GetDifficultyArray()[this.index];
            Random random = new Random();

            if (this.retos[this.index] is Pregunta)
            {
                List<Pregunta> preguntas = QQSS.service.LoadUndoneQuestionsByDifficulty(dificultad);
                int idx = random.Next(preguntas.Count);
                retos[index] = preguntas[idx];
            }

            if (this.retos[this.index] is Frase)
            {
                List<Frase> frases = QQSS.service.LoadUndoneFrasesByDifficulty(dificultad);
                int idx = random.Next(frases.Count);
                retos[index] = frases[idx];
            }

        }

        #region strategy

        public void SetPuntosStrategy(IPuntosStrategy puntosStrategy) 
        {
            this.puntosStrategy = puntosStrategy;
        }

        public void SetPuntosStrategy()
        {
            Reto reto = GetReto();
            int i = reto.Dificultad;
            if (i == 1) { SetPuntosStrategy(new EasyStrategy()); }
            else if (i == 2) { SetPuntosStrategy(new MiddleStrategy()); }
            else if (i == 3) { SetPuntosStrategy(new HardStrategy()); }
        }

        public void EstablecerPuntosRetoAcertado() 
        { 
            puntuacionReto = puntosStrategy.EstablecerPuntosRetoAcertado(puntuacionReto); 
        }

        public void UsarPista()
        {
            this.SetPuntosStrategy(new PistaStrategy());
        }

        public int GetPuntuacionReto() { return puntuacionReto; }

        #endregion

        public List<Respuesta> AnswerShuffle()
        {
            Pregunta Question = (Pregunta)retos[this.index];
            List<Respuesta> Answers = new List<Respuesta>();
            var random = new Random();
            List<Respuesta> NoMix = Question.getAllAnswers();

            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(NoMix.Count);
                Answers.Add(NoMix.ElementAt(index));
                NoMix.RemoveAt(index);
            }
            return Answers;
        }

        public bool TestAnswer(string txt)
        {
            return ((Pregunta)this.retos[this.index]).RespuestaCorrecta.Equals(txt);
        }

        public List<Reto> GetRetosAcertados()
        {
            return retosAcertados;
        }

        public List<Reto> GetRetosJugados()
        {
            return retosJugados;
        }

        #region Reto frase

        /**public string QuitarLetras(out List<char> letrasHueco)
        {
            letrasHueco = new List<char>();
            Frase fraseOriginal = (Frase) this.retos[this.index];
            int dificultad = fraseOriginal.Dificultad;
            double porcentaje = 0.0;
            if (dificultad == 1) porcentaje = 0.7;
            else if (dificultad == 2) porcentaje = 0.8;
            else if (dificultad == 3) porcentaje = 0.9;
            else throw new ServiceException("Dificultad de la frase incorrecta");

            string frase = fraseOriginal.Enunciado;
            char[] fraseCaracteres = frase.ToCharArray();
            Random random = new Random();
            int numCharsToReplace = (int)(fraseCaracteres.Length * porcentaje);

            for (int i = 0; i < numCharsToReplace; i++)
            {
                int randomIndex = random.Next(fraseCaracteres.Length);
                while (fraseCaracteres[randomIndex] == '_' || !char.IsLetter(fraseCaracteres[randomIndex]))
                {
                    randomIndex = random.Next(fraseCaracteres.Length);
                }
                letrasHueco.Add(fraseCaracteres[randomIndex]);
                fraseCaracteres[randomIndex] = '_';
            }

            return new string(fraseCaracteres);
        }
        **/

        public static string GetLetrasEliminadas(Frase fraseOriginal, string fraseConHuecos)
        {
            string letrasEliminadas = "";
            string frase = fraseOriginal.Enunciado;
            for (int i = 0; i < frase.Length; i++)
            {
                if (char.IsLetter(frase[i]) && fraseConHuecos[i] == '_')
                {
                    letrasEliminadas += frase[i];
                }
            }

            return letrasEliminadas;
        }

    
        #endregion

    }
}
