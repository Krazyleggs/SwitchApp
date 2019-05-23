using SQLite;
using Switcheroo.DataAccess;
using Xamarin.Forms;


namespace Switcheroo.ViewModels
{
    class ViewModel_Main : ViewModel_Base

    {
        #region Private Members

        //the Contentpage we control
        private readonly ContentPage _window;

        private string _personowing;

        #endregion

        #region Public Properties

        //height of title bar
        public double TitleBarHeight { get; set; } = 20;

        //thickness of Button
        public Thickness TitleBarHeightGridThickness { get { return new Thickness(TitleBarHeight); } }

        //height of Button
        public double ButtonThickness { get; set; } = 20;

        //thickness of Button
        public Thickness DisplayButtonThickness { get { return new Thickness(ButtonThickness); } }

        public string PersonOwing
        {
            get { return _personowing; }
            set
            {
                _personowing =DataAccess.DataAccess.GetPersonOwing();
                OnPropertyChanged("PersonOwing");
            }
        }

        #endregion

        #region Commands

        //Switch owning command
        public RelayCommand SwitchOwingCommand { get; set; }


        #endregion

        #region Default ConStructor 

        public ViewModel_Main (ContentPage window)
        {
     
            _window = window;

            //initializing private member from database
            _personowing = DataAccess.DataAccess.GetPersonOwing();

            var db = new SQLiteConnection(ConnectionStringHelper.GetConnection());
            db.CreateTable<OwingDataModel>();

            //Initializing commands
            SwitchOwingCommand = new RelayCommand(() => {DataAccess.DataAccess.SwitchPersonOwing(PersonOwing);
                PersonOwing = DataAccess.DataAccess.GetPersonOwing();
            } );
        }

        #endregion  
    }
}
