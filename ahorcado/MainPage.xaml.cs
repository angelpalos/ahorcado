namespace ahorcado
{
    public partial class MainPage : ContentPage
    {
        int n1, n2, res, result, fallo=0, pto=0;

        Random rdm = new Random();

        private void Restart()
        {
            n1 = rdm.Next(1, 10);
            n2 = rdm.Next(1, 10);

            N1.Text = Convert.ToString(n1);
            N2.Text = Convert.ToString(n2);

            Revisa.IsEnabled = true;

            Result.Text = "";
            fallo = 0;

            Ahorcado.Source = "zero.png";
        }

        

        private async void Revisar(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(N1.Text);
            n2 = Convert.ToInt32(N2.Text);
            res = n1 * n2;

            result = Convert.ToInt32(Result.Text);

            if (res == result)
            {
                await DisplayAlert($"Correcto","El Resultado es Correcto","Ok");
                
                pto++;
                Ptos.Text = $"Puntaje: {pto}";
                if (pto <= 5)
                {
                    n1 = rdm.Next(1, 10);
                    n2 = rdm.Next(1, 10);
                }else if (pto <= 10)
                {
                    n1 = rdm.Next(1, 10);
                    n2 = rdm.Next(1, 100);
                    Lvl.Text = "Nivel 2";
                }
                else if (pto <= 15)
                {
                    n1 = rdm.Next(1, 100);
                    n2 = rdm.Next(1, 100);
                    Lvl.Text = "Nivel 3";
                }


                N1.Text = Convert.ToString(n1);
                N2.Text = Convert.ToString(n2);
                Result.Text = "";
                
            } else
            {
                await DisplayAlert($"Incorrecto", "El Resultado NO es Correcto", "Ok");
                fallo++;

                if(fallo == 1)
                {
                    Ahorcado.Source = "test_uno.png";
                }else if (fallo == 2)
                {
                    Ahorcado.Source = "test_dos.png";
                }
                else if (fallo == 3)
                {
                    Ahorcado.Source = "test_tres.png";
                }
                else if (fallo == 4)
                {
                    Ahorcado.Source = "test_cuatro.png";
                }
                else if (fallo == 5)
                {
                    Ahorcado.Source = "test_cinco.png";
                }
                else if (fallo == 6)
                {
                    Ahorcado.Source = "test_seis.png";
                }
                else if (fallo == 7)
                {
                    Ahorcado.Source = "test_siete.png";
                }
                else if (fallo == 8)
                {
                    Ahorcado.Source = "test_ocho.png";
                }
                else if (fallo == 9)
                {
                    Ahorcado.Source = "test_nueve.png";
                    pto = 0;
                    Revisa.IsEnabled= false;
                    await DisplayAlert("PERDISTE","Se perderan todos tus puntos","Ok");
                    Restart();
                }
            }
        }

        public MainPage()
        {
            InitializeComponent();
            
            n1 = rdm.Next(1,10);
            n2 = rdm.Next(1,10);

            N1.Text = Convert.ToString(n1);
            N2.Text = Convert.ToString(n2);
        }  
    }
}
