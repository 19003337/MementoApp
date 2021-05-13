using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoApp
{
    public class TextInput
    {
        public string input { get; set; }
        public string dateTimeNow { get; set; }

        public TextInput (string input, string dateTimeNow)
        {
            this.input = input;
            this.dateTimeNow = dateTimeNow;
        }

        public string getInputDetails()
        {
            return "DateTime: " + dateTimeNow + "\nText: " + input;
        }

        public string getInput()
        {
            return input;
        }
    }
}
