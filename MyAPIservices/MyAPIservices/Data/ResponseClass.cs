using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MyAPIservices.Data
{
    public class ResponseClass
    {
        private string _Response;

        #region Setters Getters
        public string Response
        {
            set
            {
                _Response = value;
            }
            get
            {
                return _Response;
            }
        }
        #endregion

    }
}
