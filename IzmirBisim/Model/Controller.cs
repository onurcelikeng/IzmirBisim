using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace LoCar.Model
{
    public class Controller
    {

        public async void Message(string body, string head)
        {
            MessageDialog dialog = new MessageDialog(body, head);
            dialog.Commands.Add(new UICommand("Kapat"));
            await dialog.ShowAsync();
        }

    }
}
