using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class ResultForm : Form
    {
        public ResultForm(string content)
        {
            InitializeComponent();

            content_label.Text = content;

        }
        public ResultForm(string content, string resultType)
        {
            InitializeComponent();

            content_label.Text = content;
            this.Text = $"Result ({resultType})";
        }

        private void copyClose_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(content_label.Text);
            close_button_Click(sender, e);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
