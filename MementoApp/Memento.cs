using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoApp
{
    public class Memento
    {
        public TextInput textInput { get; set; }

        public Memento(TextInput textInput)
        {
            this.textInput = textInput;
        }

        public string getInput()
        {
            return textInput.getInput();
        }

        public string getInputDetails()
        {
            return textInput.getInputDetails();
        }
    }
}
