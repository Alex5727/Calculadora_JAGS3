using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Calculadora_JAGS.VM;

namespace Calculadora_JAGS.VM
{
    public class VMcal : BaseViewModel
    {
        #region VARIABLES
        double _Num1;
        double _Num2;
        double _Respuesta = 10;
        

        #endregion
        #region CONSTRUCTOR
        
        public VMcal(INavigation MainPage)
        {
            Navigation = MainPage;
        }


        #endregion
        #region OBJETOS
        public double Num1
        {
            get { return _Num1; }
            set { SetValue(ref _Num1, value); }
        }
        public double Num2
        {
            get { return _Num2; }
            set { SetValue(ref _Num2, value); }
        }

        public double Respuesta
        {
            get { return _Respuesta; }
            set { SetValue(ref _Respuesta, value); }
        }

        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void Suma()
        {
            double n1 = Convert.ToInt32(_Num1);
            double n2 = Convert.ToInt32(_Num2);

            double resultado = n1 + n2;

            Respuesta = resultado;

        }

        public void Resta()
        {
            double n1 = Convert.ToInt32(Num1);
            double n2 = Convert.ToInt32(Num2);

            double resultado = n1 - n2;

            Respuesta = resultado;

        }
        public void Multiplicacion()
        {
            double n1 = Convert.ToInt32(Num1);
            double n2 = Convert.ToInt32(Num2);

            double resultado = n1 * n2;

            Respuesta = resultado;

        }
        public void Dividir()
        {
            double n1 = Convert.ToInt32(Num1);
            double n2 = Convert.ToInt32(Num2);

            double resultado = n1 / n2;

            //Respuesta = resultado;
            Respuesta = Num1;
        }

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSuma => new Command(Suma);
        public ICommand ProcesoResta => new Command(Resta);
        public ICommand ProcesoMultiplicacion => new Command(Multiplicacion);
        public ICommand ProcesoDividir => new Command(Dividir);


        #endregion
    }
}