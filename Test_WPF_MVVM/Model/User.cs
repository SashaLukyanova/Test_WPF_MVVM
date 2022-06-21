using DevExpress.Mvvm;

namespace Test_WPF_MVVM.Model
{
    public class User: ViewModelBase//INotifyPropertyChanged
    {

        public string FullName {get; set;}
        public string Status{ get; set; }
        public int Range { get; set; }
        public int Steps { get; set; }


        //private string _fullName;
        //private string _status;

        //public string FullName
        //{
        //    get { return _fullName; }
        //    set
        //    {
        //        _fullName = value;
        //        OnPropertyChanged("FullName");
        //    }
        //}
        //public string Status
        //{
        //    get { return _status; }
        //    set
        //    {
        //        _status = value;
        //        OnPropertyChanged("Status");
        //    }
        //}        

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName] string prop = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        //}
    }
}
