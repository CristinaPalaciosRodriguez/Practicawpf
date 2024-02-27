using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class MainViewModel : NotificationObject
    {
        private int _numero1;
        private int _numero2;
        private int _resultado;
        private ICommand sumarCommand;
        private ICommand restarCommand;
        private ICommand multiplicarCommand;
        private ICommand dividirCommand;

        public int Numero1
        {
            get
            {
                return _numero1;
            }
            set
            {
                if (value == _numero1)
                    return;
                 _numero1 = value;
                RaisePropertyChanged(() => Numero1);
            }
        }

        public int Numero2
        {
            get
            {
                return _numero2;
            }
            set
            {
                if (value == _numero2)
                    return;
                _numero2 = value;
                RaisePropertyChanged(() => Numero2);
            }
        }

        public int Resultado
        {
            get
            {
                return _resultado;
            }
            set
            {
                if (value == _resultado)
                    return;
                _resultado = value;
                RaisePropertyChanged(() => Resultado);
            }
        }

        public ICommand SumarCommand
        {
            get
            {
                if(sumarCommand == null)
                {
                    sumarCommand = new DelegateCommand(Sumar, () => true);
                }
                return sumarCommand;
            }
        }

        public ICommand RestarCommand
        {
            get
            {
                if (restarCommand == null)
                {
                    restarCommand = new DelegateCommand(Restar, () => true);
                }
                return restarCommand;
            }
        }

        public ICommand MultiplicarCommand
        {
            get
            {
                if (multiplicarCommand == null)
                {
                    multiplicarCommand = new DelegateCommand(Multiplicar, () => true);
                }
                return multiplicarCommand;
            }
        }

        public ICommand DividirCommand
        {
            get
            {
                if (dividirCommand == null)
                {
                    dividirCommand = new DelegateCommand(Dividir, () => true);
                }
                return dividirCommand;
            }
        }

        public MainViewModel()
        {
            
        }

        public void Sumar()
        {
            Resultado = Numero1 + Numero2;
        }
        public void Restar()
        {
            Resultado = Numero1 - Numero2;
        }

        public void Multiplicar()
        {
            Resultado = Numero1 * Numero2;
        }

        public void Dividir()
        {
            if (Numero1 != 0 && Numero2 != 0)
            {
                Resultado = Numero1 / Numero2;
            }
            else { Resultado = 0; }
        }
    }
}
