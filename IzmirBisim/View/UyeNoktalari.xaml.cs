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
    public sealed partial class UyeNoktalari : Page
    {
        public UyeNoktalari()
        {
            this.InitializeComponent();
            body.Text = "Kiralık bisiklet sistemine üye olabilmeniz için 18 yaşını doldurmuş olmanız gerekmektedir." + "\n\nÜye kartı başvurusu sırasında yanınızda kimliğinizin bulunması gerekmektedir." + "\n\nÜye kart bedeli 5 TL'dir." + "\n\nÜye noktasından kartınıza yükleme yapabilirsiniz. (Sistemimiz min. 2,4 TL ile çalışmaktadır.)" + "\n\nÜye işlemleri menüsünden kartınıza yükleme işlemi yapabilirsiniz.";
            header1.Text = "Konak İskele çalışma saatleri";
            body2.Text = "Pazartesi             11:00 - 15:00 / 15:30 - 19:00" + "\nSalı                       11:00 - 15:00 / 15:30 - 19:00" + "\nÇarşamba           11:00 - 15:00 / 15:30 - 19:00" + "\nPerşembe           11:00 - 15:00 / 15:30 - 19:00" + "\nCuma                   11:00 - 15:00 / 15:30 - 19:00" + "\nCumartesi           11:00 - 15:00 / 15:30 - 19:00" + "\nPazar                    11:00 - 15:00 / 15:30 - 19:00";
        }

    }
}
