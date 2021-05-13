using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MementoApp
{
    public class Caretaker
    {

        public List<Memento> textInputList = new List<Memento>();
        private Stack<Memento> textInputStack = new Stack<Memento>();
        private Queue<Memento> textInputQueue = new Queue<Memento>();

        public void AddMemento(Memento textInput)
        {
            textInputList.Add(textInput);
            textInputStack.Push(textInput);
            textInputQueue.Enqueue(textInput);
            MessageBox.Show(textInput.getInput() + " added to lists!");
        }

        public Memento GetMemento(int index)
        {
            return textInputList[index];
        }


        public Memento GetFromQueue()
        {
            if(textInputQueue.Count > 0)
            {
                return textInputQueue.Dequeue();
            }
            else
            {
                return textInputList.Last();
            }
        }

        public Memento GetFromStack()
        {
            if (textInputStack.Count > 0)
            {
                return textInputStack.Pop();
            }
            else
            {
                return textInputList.Last();
            }
        }
    }
}
