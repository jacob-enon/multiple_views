using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleViews_4.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel viewModel;
        public BaseViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand<object> DisplayCustomerView => new RelayCommand<object>(x => ViewModel = new CustomerViewModel());

        public RelayCommand<object> DisplayEmployeeView => new RelayCommand<object>(x => ViewModel = new EmployeeViewModel());
    }
}