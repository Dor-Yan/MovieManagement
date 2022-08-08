using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Exeptions
{
    public class EmailExeption : Exception
    {
        public EmailExeption(String email, Exception ex) : base($"Email \"{email}\" is not valid", ex)
        {

        }
    }
}
