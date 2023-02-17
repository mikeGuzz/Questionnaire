using System.Text;

namespace Questionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateProgress();

            this.MinimumSize = this.Size;
            this.MaximumSize = new System.Drawing.Size(this.Size.Width + 200, this.Size.Height);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void onLeave(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void UpdateProgress()
        {
            int step = 100 / 5;
            int n = step;

            if (lastName_textBox.Text != string.Empty) n += step;
            if (firstName_textBox.Text != string.Empty) n += step;
            if (gender_comboBox.Text != string.Empty) n += step;
            if (bloodType_comboBox.Text != string.Empty) n += step;

            total_progressBar.Value = n;

            if(n < total_progressBar.Maximum)
                create_button.Enabled = false;
            else 
                create_button.Enabled = true;
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            StringBuilder content = new StringBuilder($"{firstName_textBox.Text} {lastName_textBox.Text}\n");
            content.Append($"Gender: {gender_comboBox.Text}\n");
            content.Append($"Date of birth: {dateOfBirth_dateTimePicker.Value.ToLongDateString()}\n");
            content.Append($"Blood type: {bloodType_comboBox.Text}\n");
            var resForm = new ResultForm(content.ToString());
            resForm.ShowDialog();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }
    }
}