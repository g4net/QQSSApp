using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QQSSApp
{
    public partial class PartidaAhorcado : Form
    {
        Ahorcado ahorcado;
        private List<Image> images;
        private List<Image> ahorcadoImages;
        private List<Image> ods;
        private int currentImageIndex = 0;
        int retoindex;
        int tiempoContador;
        int tiempodeMostrarRta;
        int error;
        int numHuecos;
        Dictionary<char, Button> indToButton;
        Label[] huecos;
        private int ahorcadoImgIndex;
        private string enunciadoAhorcado;

        public PartidaAhorcado()
        {
            InitializeComponent();
            InitializeImages();
            InitializePuntosStrategy();
            this.CenterToScreen();
            this.retoindex = QQSS.service.GetProgressIndex();
            this.error = QQSS.service.GetError();
            this.labelPuntuacionAcumulada.Text = QQSS.service.GetPuntuacionPartida().ToString();
            this.puntuacionConsolidadaLabel.Text = QQSS.service.GetPuntuacionConsolidada().ToString();
            InitializeRetoAhorcado();
            MarcarProgreso();
            InitializeTimers();
            InitializeODS();
            HabilitarBotones();
            QQSS.service.PlaySonido("musicaFondo" + GetRandomNumber(7));
            PistaLabel.Text = QQSS.service.GetNumPistas() + "/3";
            
        }

        public string GetRandomNumber(int maxNumber)
        {
            Random random = new Random();
            return random.Next(maxNumber).ToString();
        }

        private void HabilitarBotones()
        {
            botonAbandonar.Enabled = QQSS.service.GetConsolidado();
            PistaBoton.Enabled = QQSS.service.GetNumPistas() > 0;
        }
        private void MarcarProgreso() 
        {
            for(int i = 0; i <= (retoindex); i++)
            {
                string nombreBoton = "pos" + i;
                Control[] controles = this.Controls.Find(nombreBoton, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Button b = (Button)controles[0];
                if (i == retoindex)
                {
                    b.BackColor = Color.YellowGreen;
                }
                else b.BackColor = Color.DarkSeaGreen;
                if (i == error) { b.BackColor = Color.LightCoral; }
            }
        }

        public void InitializePuntosStrategy()
        {
            QQSS.service.SetPuntosStrategy();
        }

        public void InitializeRetoAhorcado()
        {
            ahorcado = (Ahorcado)QQSS.service.GetReto();
            enunciadoAhorcado = QuitarTildes(ahorcado.Enunciado.ToUpper());
            numHuecos = ahorcado.Enunciado.Replace(" ", "").Length;
            ahorcadoImgIndex = 0;
            huecos = new Label[22];
            ahorcado = (Ahorcado)QQSS.service.GetReto();
            enunciado.Text = ahorcado.Descripcion; // cambiar por ahorcado.Descripcion
            puntuacionPos.Text = ahorcado.Puntuacion_acierto.ToString();
            puntuaciónNegativa.Text = (ahorcado.Puntuacion_acierto * 2).ToString();
            indToButton = new Dictionary<char, Button>();
            ControlsInit();
            ImageInit();

        }

        public void ControlsInit()
        {
            for (int i = 0; i <= 26; i++)
            {
                string nombreButton = "teclado" + i;
                Control[] controles = this.Controls.Find(nombreButton, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Button b = (Button)controles[0];
                indToButton[b.Text[0]] = b;
                b.Click += (sender, _) =>
                {
                    if (CheckForLetter(b.Text)) b.BackColor = Color.DarkSeaGreen;
                    else b.BackColor = Color.FromArgb(231, 105, 105); 
                    b.Enabled = false;
                };
            }

            for(int i = 0; i <= 21; i++)
            {
                string nombreLabel = "letra" + i;
                Control[] controles = this.Controls.Find(nombreLabel, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Label b = (Label)controles[0];
                huecos[i] = b;
                if (i >= enunciadoAhorcado.Length) b.Hide();
                else b.Text = enunciadoAhorcado[i] == ' ' ? " " : "_";
            }
        }

        public bool CheckForLetter(string letter)
        {
            char l = letter[0];
            bool contains = enunciadoAhorcado.Contains(l);
            if (!contains)
            {
                NuevaFase();
                return false;
            }
            for(int i = 0; i < enunciadoAhorcado.Length; i++)
            {
                if (l == enunciadoAhorcado[i])
                {
                    numHuecos--;
                    if (numHuecos == 0) GanarReto();
                    huecos[i].Text = letter;
                }
            }
            return true;
        }

        public void NuevaFase()
        {
            ahorcadoPictureBox.Image = ahorcadoImages[ahorcadoImgIndex++];
            if (ahorcadoImgIndex == 10) FallarReto();
        }

        public void FallarReto()
        {
            for(int i = 0; i < enunciadoAhorcado.Length; i++)
            {
                huecos[i].Text = enunciadoAhorcado[i] + "";
            }
            foreach (Button b in indToButton.Values) { b.Enabled = false; }
            timer3.Start();
        }

        public void GanarReto()
        {
            Form respuestaAcertada;
            if (retoindex != 9) respuestaAcertada = new PuntuacionPositiva();
            else respuestaAcertada = new PartidaGanada();
            respuestaAcertada.Show();
            this.Close();
        }

        public void InitializeImages()
        {
            images = new List<Image>();
            ods = new List<Image>();
            ahorcadoImages = new List<Image>();

            for (int i = 0; i <= 9; i++)
            {
                string image = "ahorcado" + i;
                Image imagen = (System.Drawing.Bitmap)QQSSApp.Properties.Resources.ResourceManager.GetObject(image);
                ahorcadoImages.Add(imagen);
            }

            for (int i = 1; i <= 18; i++)
            {
                string image = "circulo" + i;
                Image imagen = (System.Drawing.Bitmap) QQSSApp.Properties.Resources.ResourceManager.GetObject(image);
                images.Add(imagen);
            }

            for(int i= 0; i <= 17; i++)
            {
                string image = "ODS_" + i;
                Image imagen = (System.Drawing.Bitmap) QQSSApp.Properties.Resources.ResourceManager.GetObject(image);
                ods.Add(imagen);
            }

        }

        public void InitializeODS()
        {
            ods_picture.Image = ods[0];
            if (ahorcado.MuestraImagen) ods_picture.Image = ods[ahorcado.Ods];
        }

        public void ImageInit()
        {
            ahorcadoImgIndex = ahorcado.Dificultad == 1 ? 2 : ahorcado.Dificultad == 2 ? 4 : -1;
            if (ahorcadoImgIndex == -1) return;
            ahorcadoPictureBox.Image = ahorcadoImages[ahorcadoImgIndex];
        }



        private void TimerTick(object sender, EventArgs e)
        {
            currentImageIndex++;

            if (currentImageIndex >= images.Count) currentImageIndex = 0;

            reloj_circular.Image = images[currentImageIndex];
        }

        private void Atras(object sender, EventArgs e) 
        {
            Confirmar confirmarForm = new Confirmar(this);
            confirmarForm.ShowDialog();
        }

        private void TimerTiempoTick(object sender, EventArgs e)
        {
            tiempoContador--;
            tiempo.Text = tiempoContador.ToString();
            if (tiempoContador == 0)
            {
             
                FallarReto();
            }
        }

        private void InitializeTimers()
        {
            timer1.Interval = 1764;
            timer1.Start();
            timer2.Interval = 1000;
            tiempoContador = 120;
            timer2.Start();
            timer3.Interval = 1000;
            tiempodeMostrarRta = 3;
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tiempodeMostrarRta--;

            if (tiempodeMostrarRta != 0) return;

            Form respuestaFallada;
            if (QQSS.service.GetError() != -1) respuestaFallada = new PartidaPerdida();
            else respuestaFallada = new PuntuacionNegativa();
            respuestaFallada.Show();
            this.Close();
        }

        private void PistaBoton_Click(object sender, EventArgs e)
        {
            ConfirmarPista Pista = new ConfirmarPista();
            Pista.ShowDialog();
            if (QQSS.service.GetQuierePista())
            {
                PistaBoton.Enabled = false;
                QQSS.service.UsarPista();
                PistaLabel.Text = QQSS.service.GetNumPistas() + "/3";
                Random random = new Random();
                int r = random.Next(22);
                while (huecos[r].Text != "_") r = random.Next(22);
                char c = enunciadoAhorcado[0];
                Button b = indToButton[c];
                b.BackColor = Color.Yellow;
                for (int i = 0; i < enunciadoAhorcado.Length; i++)
                {
                    if (c == enunciadoAhorcado[i]) huecos[i].Text = c + "";
                }
            }
        }

        public string QuitarTildes(string texto)
        {
            // Array con las letras acentuadas y sus equivalencias sin acento
            string[,] letrasConTilde = new string[,] {
                { "Á", "A" },
                { "É", "E" },
                { "Í", "I" },
                { "Ó", "O" },
                { "Ú", "U" },
                { "ü", "u" },
                { "Ü", "U" },
        };

            // Recorrer cada letra del texto y reemplazar las letras acentuadas por su equivalente sin acento
            for (int i = 0; i < letrasConTilde.GetLength(0); i++)
            {
                texto = texto.Replace(letrasConTilde[i, 0], letrasConTilde[i, 1]);
            }

            return texto;
        }


    }
}
