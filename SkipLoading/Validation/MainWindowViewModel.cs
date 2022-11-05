using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class MainWindowViewModel : ErrorsViewModel
    {
        private int _price;

        public int Price
        {
            get { return _price; }
            set 
            {
                _price = value;

                ClearErrors(nameof(Price));
                if(_price > 50)
                {
                    AddError(nameof(Price), "Invalid price!");
                }

                OnPropertyChanged();
            }
        }

        private string _randomString;

        public string RandomString
        {
            get { return _randomString; }
            set 
            { 
                _randomString = value;

                ClearErrors(nameof(RandomString));
                if(string.IsNullOrEmpty(_randomString))
                {
                    AddError(nameof(RandomString), "String can't be empty!");
                }
                OnPropertyChanged();
            }
        }
    }
}
