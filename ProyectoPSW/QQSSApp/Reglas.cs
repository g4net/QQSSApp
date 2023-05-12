using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQSSApp
{
    public partial class Reglas : Form
    {
        public Reglas(int visible)
        {
            InitializeComponent();
            this.CenterToScreen();

            if (visible == 1)
            {
                this.label1.Text = "REGLAS";
                this.label3.Text = "-Cada vez que se acierta un reto se acumula la puntuación \r\ndel reto a la de la partida.\r\n\t\r\n-Si se falla un reto, se descuenta la puntuación del reto X 2, \r\ny se formula otro reto sin pasar de ronda.\r\n\t\r\n-Únicamente se puede cometer un fallo en la partida, \r\nsi se comente un segundo fallo se pierde el juego y la partida \r\nacaba con 0 puntos.\r\n\t\r\n-Después de superar un reto, antes de lanzar el siguiente, \r\nse ofrecerá la opción de consolidar la puntuación obtenida \r\nhasta el momento. Si se falla un reto, no se puede consolidar \r\nen esa ronda.\r\n\t\r\n-Solamente se puede consolidar 1 vez durante una partida.\r\n\r\n-Si después de consolidar, se comete un fallo y se decide \r\nabandonar el juego, se restarán los puntos del fallo a la \r\ncantidad consolidada. \r\n";
            }
            else
            {
                this.label1.Text = "FORMATO";
                this.label3.Text = "-Nombre de usuario: letras y números (no símbolos)\r\n-Correo: se comprobará el formato correcto de este\r\n-Contraseña: mín 8 máx 32,contendrá:\r\n        *una letra minúscula\r\n        *una letra mayúscula\r\n        *un número\r\n        *un símbolo: ? - + = _ @ # ! & $";
                this.Height = 250;
            }

        }
    }    
}
