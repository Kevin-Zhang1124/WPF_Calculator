using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class CalculatorModel
    {
        private string _AddNum;

        public string AddNum
        {
            get { return _AddNum; }
            set
            {
                _AddNum = value;
            }
        }


        private string _SubNum;

        public string SubNum
        {
            get { return _SubNum; }
            set
            {
                _SubNum = value;
            }
        }


        private string _Result;

        public string Result
        {
            get { return _Result; }
            set
            {
                _Result = value;
            }
        }
    }
}
