namespace jlicuyT2.Vistas;

public partial class VPrincipal : ContentPage
{

    
    public VPrincipal( string usuario)
	{
		InitializeComponent();

        DisplayAlert("Alerta", "Bienvenido " + usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado: " + usuario;


    }

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {

        if (pkEstudiantes.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Debe seleccionar un estudiante.", "Cerrar");
            return;
        }

        try
        {
            double notaSeguimiento1 = Convert.ToDouble(txtSeguimiento1.Text) * 0.3;
            double notaExamen1 = Convert.ToDouble(txtExamen1.Text) * 0.2;
            double notaSeguimiento2 = Convert.ToDouble(txtSeguimiento2.Text) * 0.3;
            double notaExamen2 = Convert.ToDouble(txtExamen2.Text) * 0.2;

            //CALCULAMOS LAS NOTAS PARCIALES Y FINAL
            double notaParcial1 = notaSeguimiento1 + notaExamen1;
            double notaParcial2 = notaSeguimiento2 + notaExamen2;
            double notaFinal = notaParcial1 + notaParcial2;

            string mensaje = pkEstudiantes.Items[pkEstudiantes.SelectedIndex].ToString();

            if (notaFinal >= 7)
            {
                mensaje = "APROBADO";
            }
            else if (notaFinal >= 5 && notaFinal <= 6.9)
            {
                mensaje = "COMPLEMENTARIO";
            }
            else
            {
                mensaje = "REPROBADO";
            }


            DisplayAlert("Resultados",
                    "Nombre: " + pkEstudiantes.SelectedItem + "\n" +
                    "Fecha: " + dpFecha.Date.ToString("dd/MM/yyyy") + "\n" +
                    "Nota Parcial 1: " + notaParcial1.ToString("N2") + "\n" +
                    "Nota Parcial 2: " + notaParcial2.ToString("N2") + "\n" +
                    "Nota Final: " + notaFinal.ToString("N2") + "\n" +
                    "Estado: " + mensaje, "OK");
        }
        catch (FormatException)
        {
            DisplayAlert("Error", "Por favor, ingrese valores numéricos válidos en las notas.", "Cerrar");
        }


    }

  
}