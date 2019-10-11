namespace Flight_Management_System
{
    partial class FlightsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightsForm));
            this.GridView_flights = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btn_backToMainMenu = new System.Windows.Forms.Button();
            this.btn_addFlight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_flights)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_flights
            // 
            this.GridView_flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_flights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col3});
            this.GridView_flights.Location = new System.Drawing.Point(266, 330);
            this.GridView_flights.Margin = new System.Windows.Forms.Padding(4);
            this.GridView_flights.Name = "GridView_flights";
            this.GridView_flights.Size = new System.Drawing.Size(353, 67);
            this.GridView_flights.TabIndex = 9;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Flight Number";
            this.Col1.MinimumWidth = 20;
            this.Col1.Name = "Col1";
            // 
            // Col3
            // 
            this.Col3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col3.HeaderText = "arrivalDate";
            this.Col3.Name = "Col3";
            // 
            // cbxDestination
            // 
            this.cbxDestination.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Location = new System.Drawing.Point(317, 215);
            this.cbxDestination.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(238, 39);
            this.cbxDestination.TabIndex = 10;
            this.cbxDestination.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.BackColor = System.Drawing.Color.Transparent;
            this.lblDestination.Font = new System.Drawing.Font("Rockwell Condensed", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDestination.Location = new System.Drawing.Point(14, 32);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(685, 46);
            this.lblDestination.TabIndex = 11;
            this.lblDestination.Text = "Choose the Destination you would like to display its info:";
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDestination.Click += new System.EventHandler(this.lblDestination_Click);
            // 
            // btn_backToMainMenu
            // 
            this.btn_backToMainMenu.BackColor = System.Drawing.Color.White;
            this.btn_backToMainMenu.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backToMainMenu.Location = new System.Drawing.Point(37, 477);
            this.btn_backToMainMenu.Name = "btn_backToMainMenu";
            this.btn_backToMainMenu.Size = new System.Drawing.Size(141, 46);
            this.btn_backToMainMenu.TabIndex = 12;
            this.btn_backToMainMenu.Text = "Back";
            this.btn_backToMainMenu.UseVisualStyleBackColor = false;
            this.btn_backToMainMenu.Click += new System.EventHandler(this.btn_backToMainMenu_Click);
            // 
            // btn_addFlight
            // 
            this.btn_addFlight.BackColor = System.Drawing.Color.White;
            this.btn_addFlight.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFlight.Location = new System.Drawing.Point(660, 471);
            this.btn_addFlight.Name = "btn_addFlight";
            this.btn_addFlight.Size = new System.Drawing.Size(232, 46);
            this.btn_addFlight.TabIndex = 13;
            this.btn_addFlight.Text = "Add New Flight";
            this.btn_addFlight.UseVisualStyleBackColor = false;
            this.btn_addFlight.Click += new System.EventHandler(this.btn_addFlight_Click);
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flight_Management_System.Properties.Resources.wings_plane_background_blue_sky_clouds_beautiful_37794_102;
            this.ClientSize = new System.Drawing.Size(976, 588);
            this.Controls.Add(this.btn_addFlight);
            this.Controls.Add(this.btn_backToMainMenu);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.cbxDestination);
            this.Controls.Add(this.GridView_flights);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FlightsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightsForm";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_flights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_flights;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btn_backToMainMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.Button btn_addFlight;
    }
}