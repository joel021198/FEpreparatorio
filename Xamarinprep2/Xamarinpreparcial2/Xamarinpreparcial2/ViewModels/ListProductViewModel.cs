using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarinpreparcial2.Models;
using Xamarinpreparcial2.Services;

namespace Xamarinpreparcial2.ViewModels
{
    class ListProductViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        #region Atributtes
        private ObservableCollection<Product> listProducts;
        private bool isRefreshing;
        #endregion



        #region Properties
        public ObservableCollection<Product> ListProducts 
        {   get { return this.listProducts; }
            set { SetValue(ref this.listProducts, value ); }         
        }

        public bool IsRefreshing 
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructor
        public ListProductViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }
        #endregion


        #region Methods
        private async void LoadProducts()
        {
            this.isRefreshing = true;
            var main = MainViewModel.GetInstance();
            var lista = await this.apiService.Get<Product>(
                "https://webapiproductjoel.azurewebsites.net",
                "api/",
                "Products",
                main.TokenType,
                main.Token);
            ReloadProducts(lista);
            this.isRefreshing = false;
        }

        private void ReloadProducts(List<Product> products)
        {
            ListProducts.Clear();
            foreach(var product in products)
            {
                ListProducts.Add(new ProductViewItemModel
                {
                    Name = product.Name,
                    ProductId = product.ProductId,
                    Value = product.Value,
                })
            }
        }
        #endregion

        #region Commands.
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadProducts);
            }
        }
        #endregion



    }
}
