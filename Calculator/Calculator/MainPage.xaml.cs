using System;
using System.Linq;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {

        string ekran = "";
        string rakamlar = "0123456789";
        string islemler = "+-x/";

        public MainPage()
        {
            InitializeComponent();
        }

        private void entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //sonucu hesapla
            if (e.NewTextValue.Length != 0)
                return;

            char sonKarakter = e.NewTextValue[e.NewTextValue.Length - 1];

            if (!rakamlar.Contains(sonKarakter) && !islemler.Contains(sonKarakter))
                entry.Text = e.OldTextValue;

            ekran = entry.Text;
        }

        private void Topla_Clicked(object sender, EventArgs e)
        {
            if (ekran.Length != 0)
                if (!islemler.Contains(ekran[ekran.Length - 1]))
                    entry.Text += "+";
        }

        private void Çıkar_Clicked(object sender, EventArgs e)
        {
            if (ekran.Length != 0)
                if (!islemler.Contains(ekran[ekran.Length - 1]))
                    entry.Text += "-";
        }

        private void Çarp_Clicked(object sender, EventArgs e)
        {
            if (ekran.Length != 0)
                if (!islemler.Contains(ekran[ekran.Length - 1]))
                    entry.Text += "x";
        }

        private void Böl_Clicked(object sender, EventArgs e)
        {
            if (ekran.Length != 0)
                if (!islemler.Contains(ekran[ekran.Length - 1]))
                    entry.Text += "/";
        }
    }
}
