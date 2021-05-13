using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoApp
{
    public class Originator
    {
        public TextInput textInput;

        public void setTextInput(TextInput textInput)
        {
            this.textInput = textInput;
        }

        public TextInput getTextInput()
        {
            return textInput;
        }

        public Memento saveTextInputToMemento()
        {
            return new Memento(textInput);
        }

        public void getTextInputFromMemento(Memento memento)
        {
            textInput = memento.textInput;
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
