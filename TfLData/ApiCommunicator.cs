using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TfLData
{
    public class ApiCommunicator
    {
        private string apiUrl;

        public ApiCommunicator(string apiUrl)
        {
            this.apiUrl = apiUrl;
        }

        public object Get()
        {
            throw new NotImplementedException();
        }
    }
}
