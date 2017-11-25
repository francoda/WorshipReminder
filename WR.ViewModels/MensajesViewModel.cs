using System.Collections.Generic;
using System.Linq;
using WR.Models;

namespace WR.ViewModels
{
    public class MensajesViewModel : BaseViewModel
    {
        private List<Mensaje> _listaMensajes; //= MensajeModel.ListaMensajes;
        private Mensaje _mensajeSelected;

        private readonly DelegateCommand<string> _guardarCommand = new DelegateCommand<string>((s) => Guardar(), (s) => ValidarGuardar());

        public List<Mensaje> ListaMensajes
        {
            get { return _listaMensajes; }
            set { _listaMensajes = value; OnPropertyChanged(); }
        }

        public Mensaje MensajeSelected
        {
            get
            {
                if (_mensajeSelected == null && ListaMensajes.Count > 0)
                    return ListaMensajes.FirstOrDefault();
                else
                    return _mensajeSelected;
            }
            set { _mensajeSelected = value; OnPropertyChanged(); }
        }

        public DelegateCommand<string> GuardarCommand
        {
            get { return _guardarCommand; }
        }

        private static void Guardar()
        {
            
        }

        private static bool ValidarGuardar()
        {
            return true;
        }

        //private string _input;
        //public string Input
        //{
        //    get { return _input; }
        //    set { _input = value; _guardarCommand.RaiseCanExecuteChanged(); }
        //}
    }
}
