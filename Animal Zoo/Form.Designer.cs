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
            Lbl_bank_amount = new Label();
            Flw_AnimalOffers = new FlowLayoutPanel();
            Flw_TemplateAnimalOffer = new FlowLayoutPanel();
            label1 = new Label();
            Btn_BuyAnimal = new Button();
            Lbl_HabitatLimit = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Lbl_MaxOffers = new Label();
            Flw_AnimalOffers.SuspendLayout();
            Flw_TemplateAnimalOffer.SuspendLayout();
            SuspendLayout();
            // 
            // Clock_Timer
            // 
            Clock_Timer.Enabled = true;
            Clock_Timer.Interval = 1000;
            Clock_Timer.Tick += Clock_Timer_Tick;
            // 
            // Lbl_time
            // 
            Lbl_time.AutoSize = true;
            Lbl_time.CausesValidation = false;
            Lbl_time.Font = new Font("Segoe UI", 10F);
            Lbl_time.Location = new Point(12, 39);
            Lbl_time.Name = "Lbl_time";
            Lbl_time.Size = new Size(96, 46);
            Lbl_time.TabIndex = 0;
            Lbl_time.Text = "04-12-1996\r\n00:00";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Goudy Stout", 12F);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(250, 27);
            Title.TabIndex = 1;
            Title.Text = "Animal Zoo";
            // 
            // Lbl_bank_amount
            // 
            Lbl_bank_amount.AutoSize = true;
            Lbl_bank_amount.Font = new Font("Segoe UI", 10F);
            Lbl_bank_amount.Location = new Point(226, 62);
            Lbl_bank_amount.Name = "Lbl_bank_amount";
            Lbl_bank_amount.Size = new Size(55, 23);
            Lbl_bank_amount.TabIndex = 2;
            Lbl_bank_amount.Text = "$0000";
            // 
            // Flw_AnimalOffers
            // 
            Flw_AnimalOffers.AutoSize = true;
            Flw_AnimalOffers.BorderStyle = BorderStyle.Fixed3D;
            Flw_AnimalOffers.Controls.Add(Flw_TemplateAnimalOffer);
            Flw_AnimalOffers.FlowDirection = FlowDirection.TopDown;
            Flw_AnimalOffers.Location = new Point(12, 88);
            Flw_AnimalOffers.Name = "Flw_AnimalOffers";
            Flw_AnimalOffers.Size = new Size(272, 354);
            Flw_AnimalOffers.TabIndex = 4;
            // 
            // Flw_TemplateAnimalOffer
            // 
            Flw_TemplateAnimalOffer.AutoSize = true;
            Flw_TemplateAnimalOffer.BorderStyle = BorderStyle.FixedSingle;
            Flw_TemplateAnimalOffer.Controls.Add(label1);
            Flw_TemplateAnimalOffer.Controls.Add(Btn_BuyAnimal);
            Flw_TemplateAnimalOffer.FlowDirection = FlowDirection.TopDown;
            Flw_TemplateAnimalOffer.Location = new Point(3, 3);
            Flw_TemplateAnimalOffer.Name = "Flw_TemplateAnimalOffer";
            Flw_TemplateAnimalOffer.Padding = new Padding(5);
            Flw_TemplateAnimalOffer.Size = new Size(262, 68);
            Flw_TemplateAnimalOffer.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Animal Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_BuyAnimal
            // 
            Btn_BuyAnimal.AutoSize = true;
            Btn_BuyAnimal.Location = new Point(8, 28);
            Btn_BuyAnimal.Name = "Btn_BuyAnimal";
            Btn_BuyAnimal.Size = new Size(244, 30);
            Btn_BuyAnimal.TabIndex = 0;
            Btn_BuyAnimal.Text = "Buy $0";
            Btn_BuyAnimal.UseVisualStyleBackColor = true;
            // 
            // Lbl_HabitatLimit
            // 
            Lbl_HabitatLimit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_HabitatLimit.Location = new Point(712, 63);
            Lbl_HabitatLimit.Name = "Lbl_HabitatLimit";
            Lbl_HabitatLimit.Size = new Size(167, 23);
            Lbl_HabitatLimit.TabIndex = 5;
            Lbl_HabitatLimit.Text = "Habitats 0/0";
            Lbl_HabitatLimit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(287, 88);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(592, 354);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // Lbl_MaxOffers
            // 
            Lbl_MaxOffers.AutoSize = true;
            Lbl_MaxOffers.Location = new Point(12, 445);
            Lbl_MaxOffers.Name = "Lbl_MaxOffers";
            Lbl_MaxOffers.Size = new Size(31, 20);
            Lbl_MaxOffers.TabIndex = 0;
            Lbl_MaxOffers.Text = "0/0";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 474);
            Controls.Add(Lbl_MaxOffers);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Lbl_HabitatLimit);
            Controls.Add(Flw_AnimalOffers);
            Controls.Add(Lbl_bank_amount);
            Controls.Add(Title);
            Controls.Add(Lbl_time);
            Name = "Form";
            Text = "Animal Zoo";
            Load += Form1_Load;
            Flw_AnimalOffers.ResumeLayout(false);
            Flw_AnimalOffers.PerformLayout();
            Flw_TemplateAnimalOffer.ResumeLayout(false);
            Flw_TemplateAnimalOffer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Clock_Timer;
        private Label Lbl_time;
        private Label Title;
        private Label Lbl_bank_amount;
        private FlowLayoutPanel Flw_AnimalOffers;
        private FlowLayoutPanel Flw_TemplateAnimalOffer;
        private Button Btn_BuyAnimal;
        private Label label1;
        private Label Lbl_HabitatLimit;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Lbl_MaxOffers;
    }
}
