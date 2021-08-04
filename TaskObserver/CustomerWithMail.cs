using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskObserver.Service;

namespace TaskObserver
{
    public class CustomerWithMail : ICustomer
    {
        public string ProductName { get; set; }
        public string CustomerEmail { get; set; }

        public void GetMessage()
        {
            SendMailService.SendMail(CustomerEmail);
        }
    }
}
