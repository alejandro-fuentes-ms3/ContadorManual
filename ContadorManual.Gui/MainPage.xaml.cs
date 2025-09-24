namespace ContadorManual.Gui
{
    public partial class MainPage : ContentPage
   
    {
        //m
        private int conteo;
        public MainPage()
        {

            InitializeComponent();
            conteo = 0;
            conteolabel.Text = conteo.ToString();
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            conteo++;
            conteolabel.Text = conteo.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            conteo = 0;
            conteolabel.Text = conteo.ToString();
        }

    }
}
