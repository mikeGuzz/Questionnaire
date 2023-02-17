namespace Questionnaire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.total_progressBar = new System.Windows.Forms.ProgressBar();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.dateOfBirth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bloodType_comboBox = new System.Windows.Forms.ComboBox();
            this.create_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // total_progressBar
            // 
            this.total_progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.total_progressBar.Location = new System.Drawing.Point(12, 288);
            this.total_progressBar.Name = "total_progressBar";
            this.total_progressBar.Size = new System.Drawing.Size(200, 10);
            this.total_progressBar.Step = 20;
            this.total_progressBar.TabIndex = 0;
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstName_textBox.Location = new System.Drawing.Point(12, 33);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(200, 23);
            this.firstName_textBox.TabIndex = 1;
            this.firstName_textBox.Leave += new System.EventHandler(this.onLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second name";
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastName_textBox.Location = new System.Drawing.Point(12, 77);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(200, 23);
            this.lastName_textBox.TabIndex = 3;
            this.lastName_textBox.Leave += new System.EventHandler(this.onLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "I prefer not to mention"});
            this.gender_comboBox.Location = new System.Drawing.Point(12, 121);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(200, 23);
            this.gender_comboBox.TabIndex = 5;
            this.gender_comboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.gender_comboBox.Leave += new System.EventHandler(this.onLeave);
            // 
            // dateOfBirth_dateTimePicker
            // 
            this.dateOfBirth_dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirth_dateTimePicker.Location = new System.Drawing.Point(12, 165);
            this.dateOfBirth_dateTimePicker.Name = "dateOfBirth_dateTimePicker";
            this.dateOfBirth_dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateOfBirth_dateTimePicker.TabIndex = 7;
            this.dateOfBirth_dateTimePicker.Value = new System.DateTime(2023, 2, 6, 12, 36, 1, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Blood type";
            // 
            // bloodType_comboBox
            // 
            this.bloodType_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bloodType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodType_comboBox.FormattingEnabled = true;
            this.bloodType_comboBox.Items.AddRange(new object[] {
            "O",
            "A",
            "B",
            "AB"});
            this.bloodType_comboBox.Location = new System.Drawing.Point(12, 209);
            this.bloodType_comboBox.Name = "bloodType_comboBox";
            this.bloodType_comboBox.Size = new System.Drawing.Size(200, 23);
            this.bloodType_comboBox.TabIndex = 10;
            this.bloodType_comboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.bloodType_comboBox.Leave += new System.EventHandler(this.onLeave);
            // 
            // create_button
            // 
            this.create_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.create_button.Location = new System.Drawing.Point(140, 238);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(72, 25);
            this.create_button.TabIndex = 11;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(12, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 310);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.bloodType_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateOfBirth_dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gender_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName_textBox);
            this.Controls.Add(this.total_progressBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Questionnaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar total_progressBar;
        private TextBox firstName_textBox;
        private Label label1;
        private Label label2;
        private TextBox lastName_textBox;
        private Label label3;
        private ComboBox gender_comboBox;
        private DateTimePicker dateOfBirth_dateTimePicker;
        private Label label4;
        private Label label5;
        private ComboBox bloodType_comboBox;
        private Button create_button;
        private Label label6;
    }
}