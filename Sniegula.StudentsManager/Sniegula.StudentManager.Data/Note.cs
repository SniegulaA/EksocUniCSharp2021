using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.StudentManager.Data
{
    public class Note
    {
        public string Subject { get; set; }
        public decimal Value { get; set; }

        public Note(string subject, decimal value)
        {
            Subject = subject;
            Value = value;
        }

        public override string ToString()
        {
           return  this.Subject + ": \t" + this.Value.ToString();
        }
    }
}
