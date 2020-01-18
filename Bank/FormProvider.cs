using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class FormProvider
    {
        public static login login
        {
            get
            {
                if (_login == null)
                {
                    _login = new login();
                }
                return _login;
            }
        }
        private static login _login;

        public static transactions transaction
        {
            get
            {
                if (_transaction == null)
                {
                    _transaction = new transactions();
                }
                return _transaction;
            }
        }
        private static transactions _transaction;
    }
}
