using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Ejemplo_Calculadora
{
	[Activity (Label = "Ejemplo_Calculadora", MainLauncher = true)]
	public class Activity1 : Activity
	{
		TextView txtNum1;
		TextView txtNum2;
		TextView lblResultado;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
			Button btnSumar = FindViewById <Button> (Resource.Id.btnSumar);
			Button btnRestar = FindViewById <Button> (Resource.Id.btnRestar);
			Button btnMulti = FindViewById <Button> (Resource.Id.btnMulti);
			Button btnDividir = FindViewById <Button> (Resource.Id.btnDividir);
			Button btnSeno = FindViewById <Button> (Resource.Id.btnSeno);
			Button btnCoseno = FindViewById <Button> (Resource.Id.btnCoseno);
			Button btnTangente = FindViewById <Button> (Resource.Id.btnTangente);


			txtNum1 = FindViewById <TextView> (Resource.Id.txtNum1);
			txtNum2 = FindViewById <TextView> (Resource.Id.txtNum2);
			lblResultado = FindViewById <TextView> (Resource.Id.lblResultado);

			btnSumar.Click += btnSumar_Click;
			btnRestar.Click += btnRestar_Click;
			btnMulti.Click += btnMulti_Click;
			btnDividir.Click += btnDividir_Click;
			btnSeno.Click += btnSeno_Click;
			btnCoseno.Click += btnCoseno_Click;
			btnTangente.Click += btnTangente_Click;
		}

		void btnDividir_Click (object sender, EventArgs e)
		{
			double resultado = double.Parse (txtNum1.Text) / double.Parse (txtNum2.Text);
			lblResultado.Text = "Resultado: " + resultado;
		}

		void btnMulti_Click (object sender, EventArgs e)
		{
			int resultado = int.Parse (txtNum1.Text) * int.Parse (txtNum2.Text);
			lblResultado.Text = "Resultado: " + resultado.ToString ();
		}

		void btnRestar_Click (object sender, EventArgs e)
		{
			int resultado = int.Parse (txtNum1.Text) - int.Parse (txtNum2.Text);
			lblResultado.Text = "Resultado: " + resultado.ToString ();
		}

		void btnSumar_Click (object sender, EventArgs e)
		{
			int resultado = int.Parse (txtNum1.Text) + int.Parse (txtNum2.Text);
			lblResultado.Text = "Resultado: " + resultado.ToString ();
		}
		void btnSeno_Click (object sender, EventArgs e)
		{
			double seno = Convert.ToDouble (txtNum1.Text);
			double x = seno * Math.PI / 180.0;
			double resultado = Math.Sin(x);
			lblResultado.Text = "Resultado: " + resultado.ToString ();
		}
		void btnCoseno_Click (object sender, EventArgs e)
		{
			double coseno = Convert.ToDouble (txtNum1.Text);
			double c = coseno * Math.PI / 180.0;
			double resultado = Math.Cos(c);
			lblResultado.Text = "Resultado: " + resultado.ToString ();
		}
		void btnTangente_Click (object sender, EventArgs e)
		{
			double tangente = Convert.ToDouble (txtNum1.Text);
			double t = tangente * Math.PI / 180.0;
			double resultado = Math.Tan(t);
			lblResultado.Text = "Resultado: " + resultado.ToString ();
		}

	}
}


