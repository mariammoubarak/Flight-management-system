namespace Flight_Management_System
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btn_Passengers = new System.Windows.Forms.Button();
            this.btn_Flights = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Passengers
            // 
            this.btn_Passengers.BackColor = System.Drawing.Color.White;
            this.btn_Passengers.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Passengers.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_Passengers.Location = new System.Drawing.Point(430, 301);
            this.btn_Passengers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Passengers.Name = "btn_Passengers";
            this.btn_Passengers.Size = new System.Drawing.Size(254, 48);
            this.btn_Passengers.TabIndex = 0;
            this.btn_Passengers.Text = "Passengers";
            this.btn_Passengers.UseVisualStyleBackColor = false;
            this.btn_Passengers.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_Flights
            // 
            this.btn_Flights.BackColor = System.Drawing.Color.White;
            this.btn_Flights.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Flights.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_Flights.Location = new System.Drawing.Point(430, 193);
            this.btn_Flights.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Flights.Name = "btn_Flights";
            this.btn_Flights.Size = new System.Drawing.Size(254, 48);
            this.btn_Flights.TabIndex = 2;
            this.btn_Flights.Text = "Flights";
            this.btn_Flights.UseVisualStyleBackColor = false;
            this.btn_Flights.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 83);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flight_Management_System.Properties.Resources.langkawi_info_jpg;
            this.ClientSize = new System.Drawing.Size(1116, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Flights);
            this.Controls.Add(this.btn_Passengers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sloths Airline";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Passengers;
        private System.Windows.Forms.Button btn_Flights;
        private System.Windows.Forms.Label label1;
    }
}

