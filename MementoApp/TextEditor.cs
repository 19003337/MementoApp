using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace MementoApp
{
    public partial class TextEditor : Form
    {
        private static System.Timers.Timer timer; 
        private string text, dateTimeNow;
        private Originator originator = new Originator();
        private Caretaker caretaker = new Caretaker();
        private List<Memento> textInputHistory = new List<Memento>();

        public TextEditor()
        {
            InitializeComponent();
            // Create a timer and set a 30 second interval.
            timer = new System.Timers.Timer();
            timer.Interval = 30000;
            // Hook up the Elapsed event for the timer. 
            timer.Elapsed += OnTimedEvent;
            // Have the timer fire repeated events (true is the default)
            timer.AutoReset = true;
            // Start the timer
            timer.Enabled = true;

            text = txb_Input.Text;
            dateTimeNow = DateTime.Now.ToString();
        }

        private void btn_ClearText_Click(object sender, EventArgs e)
        {
            txb_Input.Clear();
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            Memento memento = caretaker.GetFromStack();
            getStateFromMemento(memento);
        }

        //The save button "Commits the changes made"
        private void btn_Save_Click(object sender, EventArgs e)
        {
            saveToMemento();
        }

        private void btn_ShowHistory_Click(object sender, EventArgs e)
        {
            foreach (Memento memento in textInputHistory)
            {
                lstView_History.Items.Add(memento.getInputDetails());
            }
            
        }

        public Memento saveToMemento()
        {
            text = txb_Input.Text;
            dateTimeNow = DateTime.Now.ToString();
            TextInput textInput = new TextInput(text, dateTimeNow);
            originator.setTextInput(textInput);
            caretaker.AddMemento(originator.saveTextInputToMemento());
            textInputHistory.Add(originator.saveTextInputToMemento());
            return new Memento(textInput);
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            Memento memento = caretaker.GetFromQueue();
            getStateFromMemento(memento);
        }

        //https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer.elapsed?view=net-5.0
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            saveToMemento();
        }


        public void getStateFromMemento(Memento memento)
        {
            text = memento.textInput.input;
            txb_Input.Text = text;
        }

    }
}
