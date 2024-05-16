namespace Animal_Zoo
{
    partial class Form
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
            components = new System.ComponentModel.Container();
            Clock_Timer = new System.Windows.Forms.Timer(components);
            Lbl_time = new Label();
            Title = new Label();
            SuspendLayout();
            // 
            // Clock_Timer
            // 
            Clock_Timer.Enabled = true;
            Clock_Timer.Tick += Clock_Timer_Tick;
            // 
            // Lbl_time
            // 
            Lbl_time.AutoSize = true;
            Lbl_time.Location = new Point(12, 29);
            Lbl_time.Name = "Lbl_time";
            Lbl_time.Size = new Size(85, 40);
            Lbl_time.TabIndex = 0;
            Lbl_time.Text = "04-12-1996\r\n00:00";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Goudy Stout", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(189, 20);
            Title.TabIndex = 1;
            Title.Text = "Animal Zoo";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Title);
            Controls.Add(Lbl_time);
            Name = "Form";
            Text = "Animal Zoo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Clock_Timer;
        private Label Lbl_time;
        private Label Title;
    }
}
