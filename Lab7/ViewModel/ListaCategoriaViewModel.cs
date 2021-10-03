using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows;
using Entity;

namespace Lab7.ViewModel
{
    public class ListaCategoriaViewModel : ViewModelBase
    {
        public ObservableCollection<Categoria> Categorias { get; set; }
        public ICommand NuevoCommand { set; get; }
        public ICommand ConsultarCommand { set; get; }
        public ListaCategoriaViewModel()
        {
            Categorias = new Model.CategoriaModel().Categorias;
            NuevoCommand = new RelayCommand<Window>(
                param=>Abrir()
                );
            ConsultarCommand = new RelayCommand<object>(
                o => { Categorias = (new Model.CategoriaModel()).Categorias; }
                );
            void Abrir()
            {
                ManCategoria window = new ManCategoria();
                window.ShowDialog();
            }
        }
    }
}
