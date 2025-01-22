using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace calculator
{
    internal class CalculatorViewModel:INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }


        private CalculatorModel _CalculatorM;

        public CalculatorModel CalculatorM
        {
            get { 
                if (_CalculatorM == null)
                    _CalculatorM = new CalculatorModel();
                return _CalculatorM; 
            }
            set { 
                _CalculatorM = value;
                RaisePropertyChanged("CalculatorM");
            }
        }


        // Calculation Logic
        void CalculateFunc ()
        {
            long result = 0;

            long addnum = long.Parse(CalculatorM.AddNum);
            long subnum = long.Parse(CalculatorM.SubNum);

            object lockObject = new object();

            Thread thread1 = new Thread(() => 
            { 
                lock (lockObject)
                {
                    result += addnum;
                } 
            });

            Thread thread2 = new Thread(() => 
            {
                lock (lockObject) 
                {
                    result -= subnum;
                }
            });

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            CalculatorM.Result = result.ToString();

            CalculatorM = CalculatorM;
        }

        // Clear Logic
        void ClearFunc()
        {
            CalculatorM.AddNum = "";
            CalculatorM.SubNum = "";
            CalculatorM.Result = "";

            CalculatorM = CalculatorM;
        }


        bool CanCalculateExecute()
        {
            return true;
        }

        // Command, bind to the calculate button
        public ICommand CalculateAction
        {
            get
            {
                return new RelayCommand(CalculateFunc, CanCalculateExecute);
            }
        }

        // Command, bind to the clear button
        public ICommand ClearAction
        {
            get
            {
                return new RelayCommand(ClearFunc, CanCalculateExecute);
            }
        }

    }
}
