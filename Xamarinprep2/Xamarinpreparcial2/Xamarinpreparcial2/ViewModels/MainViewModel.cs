using System;
using System.Collections.ObjectModel;
using Xamarinpreparcial2.Services;

namespace Xamarinpreparcial2.ViewModels
{
   public class MainViewModel
    {
        #region Attributes
        private ApiService apiService;
        #endregion

        #region Properties
        public ObservableCollection<ListProductViewModel> Products { get; set; }
        #endregion

        public MainViewModel()
        {
            apiService = new ApiService();
            Products = new ObservableCollection<ListProductViewModel>();
            LoadProducts();
        }


        #region Method       
        private void LoadProducts()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
