using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using CalendarApplication.ViewModel.Simplified;
using System.Windows;
using System.Threading;
using System.Collections;

namespace CalendarApplication.ViewModel
{
    internal class MainWindowViewModel : BaseInpc
    {

        private DateTime date =DateTime.Now;
        public DateTime Date
        {
            get => date;
            set => Set(ref date, value);
        }



    }
}
