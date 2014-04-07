using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.Abstractions
{
    public class IOTimeMachine
    {
        public Control ActiveControl { get; set; }

        private List<Control> _listeners;

        public IOTimeMachine()
        {
            _listeners = new List<Control>();
        }

        public void Listen(Control control)
        {
            control.GotFocus += _onFocus;
            _listeners.Add(control);
        }

        private void _onFocus(object sender, EventArgs e)
        {
            Control control = sender as Control;

            if (control != null)
                ActiveControl = control;
        }

        public void OnUndo(object sender, EventArgs e)
        {
            RichTextBox textBox = ActiveControl as RichTextBox;

            if (textBox != null) textBox.Undo();
        }

        public void OnRedo(object sender, EventArgs e)
        {
            RichTextBox textBox = ActiveControl as RichTextBox;

            if (textBox != null) textBox.Redo();
        }
    }
}