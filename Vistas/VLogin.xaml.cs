
namespace jlicuyT2.Vistas
{
    public partial class VLogin : ContentPage
    {
        string[] usuarios = { "Carlos", "Ana", "Jose" };
        string[] passwords = { "carlos123", "ana123", "jose123" };

        string usuario1;
        string contrasena1;

        public VLogin()
        {
            InitializeComponent();
            usuario1 = string.Empty;
            contrasena1 = string.Empty;
        }

        public void AccesoCredenciales(string usuario, string contrasena)
        {
            usuario1 = usuario;
            contrasena1 = contrasena;
        }
        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtContrasena.Text;

            bool usuarioValido = false;

            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarioIngresado == usuarios[i] && contrasenaIngresada == passwords[i])
                {
                    usuarioValido = true;
                    break;
                }
            }

            if (usuarioValido)
            {
                Navigation.PushAsync(new VPrincipal(usuarioIngresado));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "Cerrar");
            }
        }
        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VRegistro());
        }
    }
}

