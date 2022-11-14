namespace RentalSystem
{
    partial class MightyMotors
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
            this.TableView = new System.Windows.Forms.DataGridView();
            this.MakeBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.RegBox = new System.Windows.Forms.TextBox();
            this.MileageBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.AdminSubmitBtn = new System.Windows.Forms.Button();
            this.ClearanceKeyBox = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.VehicleIDBox = new System.Windows.Forms.TextBox();
            this.IDBtn = new System.Windows.Forms.Button();
            this.MoreInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.RentBox = new System.Windows.Forms.CheckBox();
            this.RemoveBox = new System.Windows.Forms.CheckBox();
            this.RemoveKeyBox = new System.Windows.Forms.TextBox();
            this.ReturnCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableView
            // 
            this.TableView.AllowUserToAddRows = false;
            this.TableView.AllowUserToDeleteRows = false;
            this.TableView.AllowUserToOrderColumns = true;
            this.TableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.TableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TableView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Location = new System.Drawing.Point(697, 0);
            this.TableView.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TableView.Name = "TableView";
            this.TableView.ReadOnly = true;
            this.TableView.RowHeadersWidth = 123;
            this.TableView.RowTemplate.Height = 25;
            this.TableView.RowTemplate.ReadOnly = true;
            this.TableView.Size = new System.Drawing.Size(880, 1234);
            this.TableView.TabIndex = 0;
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(34, 38);
            this.MakeBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.PlaceholderText = "Vehicle Make";
            this.MakeBox.Size = new System.Drawing.Size(638, 55);
            this.MakeBox.TabIndex = 1;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(34, 131);
            this.ModelBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.PlaceholderText = "Vehicle Model";
            this.ModelBox.Size = new System.Drawing.Size(638, 55);
            this.ModelBox.TabIndex = 2;
            // 
            // RegBox
            // 
            this.RegBox.Location = new System.Drawing.Point(34, 224);
            this.RegBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.RegBox.Name = "RegBox";
            this.RegBox.PlaceholderText = "Vehicle Registration Plate";
            this.RegBox.Size = new System.Drawing.Size(638, 55);
            this.RegBox.TabIndex = 3;
            // 
            // MileageBox
            // 
            this.MileageBox.Location = new System.Drawing.Point(34, 317);
            this.MileageBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MileageBox.Name = "MileageBox";
            this.MileageBox.PlaceholderText = "Vehicle Mileage";
            this.MileageBox.Size = new System.Drawing.Size(638, 55);
            this.MileageBox.TabIndex = 4;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(34, 410);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.PlaceholderText = "Cost to rent";
            this.PriceBox.Size = new System.Drawing.Size(638, 55);
            this.PriceBox.TabIndex = 5;
            // 
            // AdminSubmitBtn
            // 
            this.AdminSubmitBtn.Location = new System.Drawing.Point(12, 577);
            this.AdminSubmitBtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.AdminSubmitBtn.Name = "AdminSubmitBtn";
            this.AdminSubmitBtn.Size = new System.Drawing.Size(667, 305);
            this.AdminSubmitBtn.TabIndex = 6;
            this.AdminSubmitBtn.Text = "Submit";
            this.AdminSubmitBtn.UseVisualStyleBackColor = true;
            this.AdminSubmitBtn.Click += new System.EventHandler(this.AdminSubmitBtn_Click);
            // 
            // ClearanceKeyBox
            // 
            this.ClearanceKeyBox.Location = new System.Drawing.Point(34, 502);
            this.ClearanceKeyBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.ClearanceKeyBox.Name = "ClearanceKeyBox";
            this.ClearanceKeyBox.PlaceholderText = "Clearance Key";
            this.ClearanceKeyBox.Size = new System.Drawing.Size(638, 55);
            this.ClearanceKeyBox.TabIndex = 7;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(12, 902);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(667, 294);
            this.RefreshBtn.TabIndex = 8;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // VehicleIDBox
            // 
            this.VehicleIDBox.Location = new System.Drawing.Point(1594, 38);
            this.VehicleIDBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.VehicleIDBox.Name = "VehicleIDBox";
            this.VehicleIDBox.PlaceholderText = "ID of Vehicle";
            this.VehicleIDBox.Size = new System.Drawing.Size(650, 55);
            this.VehicleIDBox.TabIndex = 9;
            // 
            // IDBtn
            // 
            this.IDBtn.Location = new System.Drawing.Point(1594, 562);
            this.IDBtn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.IDBtn.Name = "IDBtn";
            this.IDBtn.Size = new System.Drawing.Size(617, 634);
            this.IDBtn.TabIndex = 10;
            this.IDBtn.Text = "Submit";
            this.IDBtn.UseVisualStyleBackColor = true;
            this.IDBtn.Click += new System.EventHandler(this.IDBtn_Click);
            // 
            // MoreInfoCheckBox
            // 
            this.MoreInfoCheckBox.AutoSize = true;
            this.MoreInfoCheckBox.Location = new System.Drawing.Point(1594, 131);
            this.MoreInfoCheckBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MoreInfoCheckBox.Name = "MoreInfoCheckBox";
            this.MoreInfoCheckBox.Size = new System.Drawing.Size(223, 52);
            this.MoreInfoCheckBox.TabIndex = 11;
            this.MoreInfoCheckBox.Text = "More Info";
            this.MoreInfoCheckBox.UseVisualStyleBackColor = true;
            // 
            // RentBox
            // 
            this.RentBox.AutoSize = true;
            this.RentBox.Location = new System.Drawing.Point(1594, 211);
            this.RentBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.RentBox.Name = "RentBox";
            this.RentBox.Size = new System.Drawing.Size(327, 52);
            this.RentBox.TabIndex = 12;
            this.RentBox.Text = "Rent this Vehicle";
            this.RentBox.UseVisualStyleBackColor = true;
            // 
            // RemoveBox
            // 
            this.RemoveBox.AutoSize = true;
            this.RemoveBox.Location = new System.Drawing.Point(1594, 355);
            this.RemoveBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.RemoveBox.Name = "RemoveBox";
            this.RemoveBox.Size = new System.Drawing.Size(390, 52);
            this.RemoveBox.TabIndex = 13;
            this.RemoveBox.Text = "Remove This Vehicle";
            this.RemoveBox.UseVisualStyleBackColor = true;
            // 
            // RemoveKeyBox
            // 
            this.RemoveKeyBox.Location = new System.Drawing.Point(1594, 454);
            this.RemoveKeyBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.RemoveKeyBox.Name = "RemoveKeyBox";
            this.RemoveKeyBox.PlaceholderText = "Clearance Key";
            this.RemoveKeyBox.Size = new System.Drawing.Size(638, 55);
            this.RemoveKeyBox.TabIndex = 14;
            // 
            // ReturnCheckBox
            // 
            this.ReturnCheckBox.AutoSize = true;
            this.ReturnCheckBox.Location = new System.Drawing.Point(1594, 283);
            this.ReturnCheckBox.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.ReturnCheckBox.Name = "ReturnCheckBox";
            this.ReturnCheckBox.Size = new System.Drawing.Size(367, 52);
            this.ReturnCheckBox.TabIndex = 15;
            this.ReturnCheckBox.Text = "Return This Vehicle";
            this.ReturnCheckBox.UseVisualStyleBackColor = true;
            // 
            // MightyMotors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(2229, 1235);
            this.Controls.Add(this.ReturnCheckBox);
            this.Controls.Add(this.RemoveKeyBox);
            this.Controls.Add(this.RemoveBox);
            this.Controls.Add(this.RentBox);
            this.Controls.Add(this.MoreInfoCheckBox);
            this.Controls.Add(this.IDBtn);
            this.Controls.Add(this.VehicleIDBox);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.ClearanceKeyBox);
            this.Controls.Add(this.AdminSubmitBtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.MileageBox);
            this.Controls.Add(this.RegBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.TableView);
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2265, 1338);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2265, 1338);
            this.Name = "MightyMotors";
            this.Text = "MightyMotors";
            this.Load += new System.EventHandler(this.MightyMotors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView TableView;
        private TextBox MakeBox;
        private TextBox ModelBox;
        private TextBox RegBox;
        private TextBox MileageBox;
        private TextBox PriceBox;
        private Button AdminSubmitBtn;
        private TextBox ClearanceKeyBox;
        private Button RefreshBtn;
        private TextBox VehicleIDBox;
        private Button IDBtn;
        private CheckBox MoreInfoCheckBox;
        private CheckBox RentBox;
        private CheckBox RemoveBox;
        private TextBox RemoveKeyBox;
        private CheckBox ReturnCheckBox;
    }
}