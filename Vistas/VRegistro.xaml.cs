namespace jlicuyT2.Vistas;

public partial class VRegistro : ContentPage
{
	public VRegistro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        /*string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;
        Navigation.PushAsync(new VLogin(usuario, contrasena));*/

        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;

        VLogin loginPage = new VLogin();
        loginPage.AccesoCredenciales(usuario, contrasena);

        Navigation.PushAsync(loginPage);

    }
}