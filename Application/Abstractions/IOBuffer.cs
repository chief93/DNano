using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.Abstractions
{
    public class IOBuffer
    {
        public Control ActiveControl { get; set; }

        private List<Control> _listeners;

        public IOBuffer()
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

        public void OnCopy(object sender, EventArgs e)
        {
            RichTextBox textBox = ActiveControl as RichTextBox;

            if (textBox == null) return;

            Clipboard.Clear();
            textBox.Copy();
        }

        public void OnCut(object sender, EventArgs e)
        {
            RichTextBox textBox = ActiveControl as RichTextBox;

            if (textBox == null) return;

            Clipboard.Clear();
            textBox.Cut();
        }

        public void OnPaste(object sender, EventArgs e)
        {
            RichTextBox textBox = ActiveControl as RichTextBox;

            if (textBox != null) textBox.Paste();
        }

        public void OnDelete(object sender, EventArgs e)
        {
            RichTextBox textBox = ActiveControl as RichTextBox;

            if (textBox != null)
                textBox.Text = textBox.Text.Replace(textBox.SelectedText, "");
        }
    }
}