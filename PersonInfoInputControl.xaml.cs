using System.Windows.Controls;


namespace lab2
{
    /// <summary>
    /// Interaction logic for PersonInfoInput.xaml
    /// </summary>
    public partial class PersonInfoInputControl : UserControl
    {
        public PersonInfoInputControl()
        {
            InitializeComponent();
            DataContext = new PersonInfoViewModel();
        }
    }
}
