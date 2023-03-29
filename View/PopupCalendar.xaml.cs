using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace CalendarApplication.View
{
    public partial class PopupCalendar : UserControl
    {
        public DateTime Date
        {
            get { return (DateTime)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }
        public static DependencyProperty DateProperty = DependencyProperty.Register("Date", typeof(DateTime), typeof(PopupCalendar), 
            new FrameworkPropertyMetadata(new PropertyChangedCallback(OnDatePropertyChanged)/*, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault*/));

        private static void OnDatePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            PopupCalendar CurrentPopupCalendar = (PopupCalendar)sender;
        }

        public PopupCalendar()
        {
            InitializeComponent();
            Date = DateTime.Now;
        }

        private void TEXT_DATE_MouseUP(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                POPUP_PATH.IsOpen = true;
            }
        }

        private void calenrdar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            POPUP_PATH.IsOpen = false;
            Date = ((Calendar)sender).SelectedDate!.Value;
        }
    }
}
