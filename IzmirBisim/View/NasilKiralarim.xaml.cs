using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace IzmirBisim.View
{
    public sealed partial class NasilKiralarim : Page
    {

        public NasilKiralarim()
        {
            this.InitializeComponent();

            header1.Text = "1. ÜYE KARTI İLE (Hızlı ve kolay)";
            body1.Text = "Sürekli yeşil ışık yanan bisikletin bulunduğu park ünitesine kartınızı okutup şifrenizi giriniz ve giriş tuşuna basınız., yeşil ışık yanıp sönmeye başlayınca  bisikletinizi önce ileri itip sonra geri çekerek teslim alınız. Kullanıma ait bilgiler cep telefonunuza kısa mesaj ile gönderilir. Üye kartı ile kiralamada blokaj yoktur.";
            header2.Text = "Üye kartımı nasıl alırım?";
            body2.Text = "1. Ana menüde ilan edilen üye noktalarından para yatırarak," + "\n2. Sitemize üye olarak kredi kartı ile internetten alabilirsiniz. Kartınız  2- 4 gün içinde adresinize gönderilecektir.";
            header3.Text = "Üye kartıma nasıl kredi yüklerim?";
            body3.Text = "1. Üye noktalarından" + "\n2. Sitemizde üye girişi yaparak kredi kartı ile internetten yükleyebilirsiniz.";
            header4.Text = "2. KREDİ KARTI İLE";
            body4.Text = "Herhangi bir üyelik gerektirmeden kiosk ekranındaki talimatları uygulayarak aldığınız şifre ile park ünitesine gidiniz. Sürekli yeşil ışık yanan bisikletin bulunduğu park ünitesinde önce giriş tuşuna basınız,  şifrenizi girdikten sonra tekrar giriş tuşuna basınız., yeşil ışık yanıp sönmeye başlayınca  bisikletinizi önce ileri itip sonra geri çekerek teslim alınız.";
            header5.Text = "25 tl blokaj nedir?";
            body5.Text = "Bu bizim aldığımız bir depozite değildir. Bankalar işleyiş sistemi gereği kredi kartınızdan bisiklet başına 25 TL bloke edilir. Bisikleti  kiraladığınızın ertesi gün saat 23.00 de blokaj kalkar.Bu süre içinde başka bir blokaja gerek kalmadan tekrar tekrar kiralama yapabilirsiniz. Belirtilen sürede blokajın kalkmadığı hallerde kredi kartınızın ait olduğu banka ile görüşünüz.";
        }

    }
}
