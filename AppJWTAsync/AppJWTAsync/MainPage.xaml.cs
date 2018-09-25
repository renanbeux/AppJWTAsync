﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppJWTAsync.Service;

namespace AppJWTAsync
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public async void GetTokenAction(object sender, EventArgs args)
        {
            string resultado = await JWTService.GetToken(nome.Text, password.Text);
            LblToken.Text = resultado;
        }

        public async void VerificarAction(object sender, EventArgs args)
        {
            string resultado = await JWTService.Verificar();
            LblResultado.Text = resultado;
        }

    }
}
