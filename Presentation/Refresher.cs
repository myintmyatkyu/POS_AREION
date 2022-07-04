using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;
using POSBusinessLogic;
using System.Windows.Forms;

namespace Presentation
{
    public class Refresher
    {
        public static void RaiseRefreshEvents<T>(object key)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is IRefreshable<T>)
                {
                    IRefreshable<T> form = (IRefreshable<T>)f;
                    form.OnListChanged(key);
                }
            }
        }
    }
}
