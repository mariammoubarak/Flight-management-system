namespace Flight_Management_System
{
    partial class AddFlightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlightForm));
            this.addFlightNo = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_flightNumber = new System.Windows.Forms.TextBox();
            this.addFlightDest = new System.Windows.Forms.Label();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.addArrivalDate = new System.Windows.Forms.Label();
            this.txt_arrivalDate = new System.Windows.Forms.TextBox();
            this.addPassName = new System.Windows.Forms.Label();
            this.txt_passName = new System.Windows.Forms.TextBox();
            this.addPassPhone = new System.Windows.Forms.Label();
            this.txt_passPhone = new System.Windows.Forms.TextBox();
            this.addFlight = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFlightNo
            // 
            this.addFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.addFlightNo.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFlightNo.ForeColor = System.Drawing.Color.White;
            this.addFlightNo.Location = new System.Drawing.Point(136, 102);
            this.addFlightNo.Name = "addFlightNo";
            this.addFlightNo.Size = new System.Drawing.Size(263, 40);
            this.addFlightNo.TabIndex = 1;
            this.addFlightNo.Text = "Add Flight Number";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Teal;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(866, 518);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(216, 57);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add Passenger";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_flightNumber
            // 
            this.txt_flightNumber.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_flightNumber.Location = new System.Drawing.Point(472, 98);
            this.txt_flightNumber.Multiline = true;
            this.txt_flightNumber.Name = "txt_flightNumber";
            this.txt_flightNumber.Size = new System.Drawing.Size(231, 44);
            this.txt_flightNumber.TabIndex = 14;
            // 
            // addFlightDest
            // 
            this.addFlightDest.BackColor = System.Drawing.Color.Transparent;
            this.addFlightDest.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFlightDest.ForeColor = System.Drawing.Color.White;
            this.addFlightDest.Location = new System.Drawing.Point(136, 210);
            this.addFlightDest.Name = "addFlightDest";
            this.addFlightDest.Size = new System.Drawing.Size(302, 40);
            this.addFlightDest.TabIndex = 15;
            this.addFlightDest.Text = "Add Flight Destination";
            // 
            // txt_destination
            // 
            this.txt_destination.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_destination.Location = new System.Drawing.Point(472, 204);
            this.txt_destination.Multiline = true;
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.Size = new System.Drawing.Size(231, 46);
            this.txt_destination.TabIndex = 16;
            // 
            // addArrivalDate
            // 
            this.addArrivalDate.BackColor = System.Drawing.Color.Transparent;
            this.addArrivalDate.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addArrivalDate.ForeColor = System.Drawing.Color.White;
            this.addArrivalDate.Location = new System.Drawing.Point(136, 327);
            this.addArrivalDate.Name = "addArrivalDate";
            this.addArrivalDate.Size = new System.Drawing.Size(302, 40);
            this.addArrivalDate.TabIndex = 17;
            this.addArrivalDate.Text = "Add Arrival Date";
            // 
            // txt_arrivalDate
            // 
            this.txt_arrivalDate.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arrivalDate.Location = new System.Drawing.Point(472, 321);
            this.txt_arrivalDate.Multiline = true;
            this.txt_arrivalDate.Name = "txt_arrivalDate";
            this.txt_arrivalDate.Size = new System.Drawing.Size(231, 46);
            this.txt_arrivalDate.TabIndex = 18;
            // 
            // addPassName
            // 
            this.addPassName.BackColor = System.Drawing.Color.Transparent;
            this.addPassName.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPassName.ForeColor = System.Drawing.Color.White;
            this.addPassName.Location = new System.Drawing.Point(55, 417);
            this.addPassName.Name = "addPassName";
            this.addPassName.Size = new System.Drawing.Size(315, 40);
            this.addPassName.TabIndex = 19;
            this.addPassName.Text = "Add passenger Name";
            // 
            // txt_passName
            // 
            this.txt_passName.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passName.Location = new System.Drawing.Point(361, 417);
            this.txt_passName.Multiline = true;
            this.txt_passName.Name = "txt_passName";
            this.txt_passName.Size = new System.Drawing.Size(173, 43);
            this.txt_passName.TabIndex = 20;
            // 
            // addPassPhone
            // 
            this.addPassPhone.BackColor = System.Drawing.Color.Transparent;
            this.addPassPhone.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPassPhone.ForeColor = System.Drawing.Color.White;
            this.addPassPhone.Location = new System.Drawing.Point(569, 420);
            this.addPassPhone.Name = "addPassPhone";
            this.addPassPhone.Size = new System.Drawing.Size(315, 40);
            this.addPassPhone.TabIndex = 21;
            this.addPassPhone.Text = "Add passenger Phone";
            // 
            // txt_passPhone
            // 
            this.txt_passPhone.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passPhone.Location = new System.Drawing.Point(904, 417);
            this.txt_passPhone.Multiline = true;
            this.txt_passPhone.Name = "txt_passPhone";
            this.txt_passPhone.Size = new System.Drawing.Size(169, 43);
            this.txt_passPhone.TabIndex = 22;
            // 
            // addFlight
            // 
            this.addFlight.BackColor = System.Drawing.Color.Teal;
            this.addFlight.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFlight.ForeColor = System.Drawing.Color.White;
            this.addFlight.Location = new System.Drawing.Point(472, 518);
            this.addFlight.Name = "addFlight";
            this.addFlight.Size = new System.Drawing.Size(184, 58);
            this.addFlight.TabIndex = 23;
            this.addFlight.Text = "Add Flight";
            this.addFlight.UseVisualStyleBackColor = false;
            this.addFlight.Click += new System.EventHandler(this.addFlight_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Teal;
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(47, 518);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(184, 58);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flight_Management_System.Properties.Resources._1_vpXdQgSFVq60q1Eqk8vUFw;
            this.ClientSize = new System.Drawing.Size(1116, 588);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.addFlight);
            this.Controls.Add(this.txt_passPhone);
            this.Controls.Add(this.addPassPhone);
            this.Controls.Add(this.txt_passName);
            this.Controls.Add(this.addPassName);
            this.Controls.Add(this.txt_arrivalDate);
            this.Controls.Add(this.addArrivalDate);
            this.Controls.Add(this.txt_destination);
            this.Controls.Add(this.addFlightDest);
            this.Controls.Add(this.txt_flightNumber);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.addFlightNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFlightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addFlightNo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_flightNumber;
        private System.Windows.Forms.Label addFlightDest;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.Label addArrivalDate;
        private System.Windows.Forms.TextBox txt_arrivalDate;
        private System.Windows.Forms.Label addPassName;
        private System.Windows.Forms.TextBox txt_passName;
        private System.Windows.Forms.Label addPassPhone;
        private System.Windows.Forms.TextBox txt_passPhone;
        private System.Windows.Forms.Button addFlight;
        private System.Windows.Forms.Button btn_back;
    }
}