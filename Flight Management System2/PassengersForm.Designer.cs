namespace Flight_Management_System
{
    partial class PassengersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengersForm));
            this.GridView_Passengers = new System.Windows.Forms.DataGridView();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show = new System.Windows.Forms.Button();
            this.cbx_flight = new System.Windows.Forms.ComboBox();
            this.cbx_Date = new System.Windows.Forms.ComboBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_flight = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_SearchByFlightNo = new System.Windows.Forms.Button();
            this.btn_searchByDate = new System.Windows.Forms.Button();
            this.cbx_SearchPass = new System.Windows.Forms.ComboBox();
            this.btn_updatePassInfo = new System.Windows.Forms.Button();
            this.lbl_flightNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Passengers)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_Passengers
            // 
            this.GridView_Passengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Passengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col2,
            this.Col3,
            this.Col4});
            this.GridView_Passengers.Location = new System.Drawing.Point(345, 187);
            this.GridView_Passengers.Margin = new System.Windows.Forms.Padding(4);
            this.GridView_Passengers.Name = "GridView_Passengers";
            this.GridView_Passengers.Size = new System.Drawing.Size(473, 141);
            this.GridView_Passengers.TabIndex = 5;
            this.GridView_Passengers.Visible = false;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Passenger";
            this.Col2.Name = "Col2";
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Phone";
            this.Col3.Name = "Col3";
            // 
            // Col4
            // 
            this.Col4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col4.HeaderText = "flight number";
            this.Col4.Name = "Col4";
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.White;
            this.show.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(880, 80);
            this.show.Margin = new System.Windows.Forms.Padding(4);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(204, 53);
            this.show.TabIndex = 6;
            this.show.Text = "Show all passengers";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // cbx_flight
            // 
            this.cbx_flight.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_flight.FormattingEnabled = true;
            this.cbx_flight.Location = new System.Drawing.Point(486, 71);
            this.cbx_flight.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_flight.Name = "cbx_flight";
            this.cbx_flight.Size = new System.Drawing.Size(160, 34);
            this.cbx_flight.TabIndex = 11;
            this.cbx_flight.Visible = false;
            this.cbx_flight.SelectedIndexChanged += new System.EventHandler(this.cbx_flight_SelectedIndexChanged);
            // 
            // cbx_Date
            // 
            this.cbx_Date.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Date.FormattingEnabled = true;
            this.cbx_Date.Location = new System.Drawing.Point(486, 71);
            this.cbx_Date.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Date.Name = "cbx_Date";
            this.cbx_Date.Size = new System.Drawing.Size(160, 34);
            this.cbx_Date.TabIndex = 12;
            this.cbx_Date.Visible = false;
            this.cbx_Date.SelectedIndexChanged += new System.EventHandler(this.cbx_Date_SelectedIndexChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(244, 309);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(144, 40);
            this.txt_phone.TabIndex = 14;
            this.txt_phone.Visible = false;
            // 
            // txt_flight
            // 
            this.txt_flight.Location = new System.Drawing.Point(729, 302);
            this.txt_flight.Margin = new System.Windows.Forms.Padding(4);
            this.txt_flight.Multiline = true;
            this.txt_flight.Name = "txt_flight";
            this.txt_flight.Size = new System.Drawing.Size(157, 40);
            this.txt_flight.TabIndex = 15;
            this.txt_flight.Visible = false;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phone.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Phone.Location = new System.Drawing.Point(49, 310);
            this.lbl_Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(187, 39);
            this.lbl_Phone.TabIndex = 16;
            this.lbl_Phone.Text = "Phone :";
            this.lbl_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Phone.Visible = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(486, 452);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(157, 54);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_back.Location = new System.Drawing.Point(75, 477);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(130, 45);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_SearchByFlightNo
            // 
            this.btn_SearchByFlightNo.BackColor = System.Drawing.Color.White;
            this.btn_SearchByFlightNo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchByFlightNo.Location = new System.Drawing.Point(880, 210);
            this.btn_SearchByFlightNo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SearchByFlightNo.Name = "btn_SearchByFlightNo";
            this.btn_SearchByFlightNo.Size = new System.Drawing.Size(204, 53);
            this.btn_SearchByFlightNo.TabIndex = 19;
            this.btn_SearchByFlightNo.Text = "Search by Flight Number";
            this.btn_SearchByFlightNo.UseVisualStyleBackColor = false;
            this.btn_SearchByFlightNo.Click += new System.EventHandler(this.btn_SearchByFlightNo_Click);
            // 
            // btn_searchByDate
            // 
            this.btn_searchByDate.BackColor = System.Drawing.Color.White;
            this.btn_searchByDate.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchByDate.Location = new System.Drawing.Point(880, 350);
            this.btn_searchByDate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_searchByDate.Name = "btn_searchByDate";
            this.btn_searchByDate.Size = new System.Drawing.Size(204, 53);
            this.btn_searchByDate.TabIndex = 20;
            this.btn_searchByDate.Text = "Search by Date";
            this.btn_searchByDate.UseVisualStyleBackColor = false;
            this.btn_searchByDate.Click += new System.EventHandler(this.btn_searchByDate_Click);
            // 
            // cbx_SearchPass
            // 
            this.cbx_SearchPass.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_SearchPass.FormattingEnabled = true;
            this.cbx_SearchPass.Location = new System.Drawing.Point(486, 71);
            this.cbx_SearchPass.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_SearchPass.Name = "cbx_SearchPass";
            this.cbx_SearchPass.Size = new System.Drawing.Size(160, 34);
            this.cbx_SearchPass.TabIndex = 21;
            this.cbx_SearchPass.Visible = false;
            // 
            // btn_updatePassInfo
            // 
            this.btn_updatePassInfo.BackColor = System.Drawing.Color.White;
            this.btn_updatePassInfo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePassInfo.Location = new System.Drawing.Point(880, 477);
            this.btn_updatePassInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updatePassInfo.Name = "btn_updatePassInfo";
            this.btn_updatePassInfo.Size = new System.Drawing.Size(204, 53);
            this.btn_updatePassInfo.TabIndex = 22;
            this.btn_updatePassInfo.Text = "Update Passenger";
            this.btn_updatePassInfo.UseVisualStyleBackColor = false;
            this.btn_updatePassInfo.Click += new System.EventHandler(this.btn_updatePassInfo_Click);
            // 
            // lbl_flightNo
            // 
            this.lbl_flightNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_flightNo.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flightNo.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_flightNo.Location = new System.Drawing.Point(480, 310);
            this.lbl_flightNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_flightNo.Name = "lbl_flightNo";
            this.lbl_flightNo.Size = new System.Drawing.Size(187, 39);
            this.lbl_flightNo.TabIndex = 23;
            this.lbl_flightNo.Text = "Flight No :";
            this.lbl_flightNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_flightNo.Visible = false;
            // 
            // PassengersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flight_Management_System.Properties.Resources.IMG_9945;
            this.ClientSize = new System.Drawing.Size(1116, 588);
            this.Controls.Add(this.lbl_flightNo);
            this.Controls.Add(this.btn_updatePassInfo);
            this.Controls.Add(this.cbx_SearchPass);
            this.Controls.Add(this.btn_searchByDate);
            this.Controls.Add(this.btn_SearchByFlightNo);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.txt_flight);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.cbx_Date);
            this.Controls.Add(this.cbx_flight);
            this.Controls.Add(this.show);
            this.Controls.Add(this.GridView_Passengers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PassengersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassengersForm";
            this.Load += new System.EventHandler(this.PassengersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Passengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_Passengers;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.ComboBox cbx_flight;
        private System.Windows.Forms.ComboBox cbx_Date;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_flight;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_SearchByFlightNo;
        private System.Windows.Forms.Button btn_searchByDate;
        private System.Windows.Forms.ComboBox cbx_SearchPass;
        private System.Windows.Forms.Button btn_updatePassInfo;
        private System.Windows.Forms.Label lbl_flightNo;
    }
}