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
    public sealed partial class Fiyatlar : Page
    {

        public Fiyatlar()
        {
            this.InitializeComponent();

            text.Text = "01.01.2016 tarihinden itibaren bisiklet kiralama ücreti her saat için 2,40 TL'dir. \n\nBisim üye kartı ile kiralamada herhangi bir depozito işlemi bulunmamaktadır. \n\nKredi kartı ile bisiklet kiralamadaki 25 TL'lik depozitoya ait provizyon saat 24:00'da çözümlenmektedir. Aksi bir durumda banka şubeniz ile görüşünüz. \n\nAkıllı bisiklet sistemimiz  23:00 - 06:00 arası hizmete kapalıdır.";
        }

    }
}
