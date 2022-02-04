using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace CalculadoraIVA
{
    [Activity(MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText entradaCantidad;
        Button botonCalcular;
        TextView resultadoIVA;

       TextView resultadoTotal;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            entradaCantidad = FindViewById<EditText>(Resource.Id.entradaCantidad);
            botonCalcular = FindViewById<Button>(Resource.Id.botonCalcular);
            resultadoIVA = FindViewById<TextView>(Resource.Id.resultadoIVA);

           resultadoTotal = FindViewById<TextView>(Resource.Id.resultadoTotal);

            botonCalcular.Click += OnCalcularClick;
        }

        private void OnCalcularClick(object sender, EventArgs e)
        {
            string texto = entradaCantidad.Text;
            double cantidad;
            if(double.TryParse(texto, out cantidad))
            {
                double IVA = cantidad * 0.16;
                resultadoIVA.Text = IVA.ToString("C");

                double resultado = cantidad + IVA;
                resultadoTotal.Text = resultado.ToString("C");
            }

 
            
        }

    }
}