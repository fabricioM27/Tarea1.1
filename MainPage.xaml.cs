namespace Tarea1._1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        decimal suma, resta, multi, divi, nu1, nu2;


        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            nu1 = Convert.ToDecimal(txtnu1.Text);
            nu2 = Convert.ToDecimal(txtnu2.Text);
            suma = nu1 + nu2;

            var operacion = new Models.Operacion
            {
                resultado = suma
            };

            var PageResult = new PageResult();
            PageResult.BindingContext = operacion;
            await Navigation.PushAsync(PageResult);
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            nu1 = Convert.ToDecimal(txtnu1.Text);
            nu2 = Convert.ToDecimal(txtnu2.Text);
            resta = nu1 - nu2;

            var operacion = new Models.Operacion
            {
                resultado = resta
            };

            var PageResult = new PageResult();
            PageResult.BindingContext = operacion;
            await Navigation.PushAsync(PageResult);
        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            nu1 = Convert.ToDecimal(txtnu1.Text);
            nu2 = Convert.ToDecimal(txtnu2.Text);
            divi = nu1 / nu2;

            var operacion = new Models.Operacion
            {
                resultado = divi
            };

            var PageResult = new PageResult();
            PageResult.BindingContext = operacion;
            await Navigation.PushAsync(PageResult);
        }

        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            nu1 = Convert.ToDecimal(txtnu1.Text);
            nu2 = Convert.ToDecimal(txtnu2.Text);
            multi = nu1 * nu2;

            var operacion = new Models.Operacion
            {
                resultado = multi
            };

            var PageResult = new PageResult();
            PageResult.BindingContext = operacion;
            await Navigation.PushAsync(PageResult);
        }
    }
}