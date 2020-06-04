using System;
using System.Windows.Input;

namespace Xamarinpreparcial2.ViewModels
{
    internal class RelayCommand : ICommand
    {
        private Action loadProducts;

        public RelayCommand(Action loadProducts)
        {
            this.loadProducts = loadProducts;
        }
    }
}