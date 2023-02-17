namespace Questionnaire
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.content_label = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.copyClose_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // content_label
            // 
            this.content_label.Location = new System.Drawing.Point(12, 9);
            this.content_label.Name = "content_label";
            this.content_label.Size = new System.Drawing.Size(251, 140);
            this.content_label.TabIndex = 0;
            this.content_label.Text = "Content...";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(188, 152);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 1;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // copyClose_button
            // 
            this.copyClose_button.Location = new System.Drawing.Point(97, 152);
            this.copyClose_button.Name = "copyClose_button";
            this.copyClose_button.Size = new System.Drawing.Size(85, 23);
            this.copyClose_button.TabIndex = 2;
            this.copyClose_button.Text = "Copy&&Close";
            this.copyClose_button.UseVisualStyleBackColor = true;
            this.copyClose_button.Click += new System.EventHandler(this.copyClose_button_Click);
            // 
            // ResultForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 187);
            this.Controls.Add(this.copyClose_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.content_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Result";
            this.ResumeLayout(false);

        }

        #endregion

        private Label content_label;
        private Button close_button;
        private Button copyClose_button;
    }
}