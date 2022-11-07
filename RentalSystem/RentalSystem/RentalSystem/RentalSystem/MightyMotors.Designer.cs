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
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableView
            // 
            this.TableView.AllowUserToAddRows = false;
            this.TableView.AllowUserToDeleteRows = false;
            this.TableView.AllowUserToOrderColumns = true;
            this.TableView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Location = new System.Drawing.Point(244, 0);
            this.TableView.MaximumSize = new System.Drawing.Size(308, 449);
            this.TableView.MinimumSize = new System.Drawing.Size(308, 449);
            this.TableView.Name = "TableView";
            this.TableView.ReadOnly = true;
            this.TableView.RowTemplate.Height = 25;
            this.TableView.RowTemplate.ReadOnly = true;
            this.TableView.Size = new System.Drawing.Size(308, 449);
            this.TableView.TabIndex = 0;
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(12, 12);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.PlaceholderText = "Vehicle Make";
            this.MakeBox.Size = new System.Drawing.Size(226, 23);
            this.MakeBox.TabIndex = 1;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(12, 41);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.PlaceholderText = "Vehicle Model";
            this.ModelBox.Size = new System.Drawing.Size(226, 23);
            this.ModelBox.TabIndex = 2;
            // 
            // RegBox
            // 
            this.RegBox.Location = new System.Drawing.Point(12, 70);
            this.RegBox.Name = "RegBox";
            this.RegBox.PlaceholderText = "Vehicle Registration Plate";
            this.RegBox.Size = new System.Drawing.Size(226, 23);
            this.RegBox.TabIndex = 3;
            // 
            // MileageBox
            // 
            this.MileageBox.Location = new System.Drawing.Point(12, 99);
            this.MileageBox.Name = "MileageBox";
            this.MileageBox.PlaceholderText = "Vehicle Mileage";
            this.MileageBox.Size = new System.Drawing.Size(226, 23);
            this.MileageBox.TabIndex = 4;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(12, 128);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.PlaceholderText = "Cost to rent";
            this.PriceBox.Size = new System.Drawing.Size(226, 23);
            this.PriceBox.TabIndex = 5;
            // 
            // AdminSubmitBtn
            // 
            this.AdminSubmitBtn.Location = new System.Drawing.Point(12, 186);
            this.AdminSubmitBtn.Name = "AdminSubmitBtn";
            this.AdminSubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.AdminSubmitBtn.TabIndex = 6;
            this.AdminSubmitBtn.Text = "Submit";
            this.AdminSubmitBtn.UseVisualStyleBackColor = true;
            this.AdminSubmitBtn.Click += new System.EventHandler(this.AdminSubmitBtn_Click);
            // 
            // ClearanceKeyBox
            // 
            this.ClearanceKeyBox.Location = new System.Drawing.Point(12, 157);
            this.ClearanceKeyBox.Name = "ClearanceKeyBox";
            this.ClearanceKeyBox.PlaceholderText = "Clearance Key";
            this.ClearanceKeyBox.Size = new System.Drawing.Size(226, 23);
            this.ClearanceKeyBox.TabIndex = 7;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(163, 186);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 8;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // VehicleIDBox
            // 
            this.VehicleIDBox.Location = new System.Drawing.Point(558, 12);
            this.VehicleIDBox.Name = "VehicleIDBox";
            this.VehicleIDBox.PlaceholderText = "ID of Vehicle";
            this.VehicleIDBox.Size = new System.Drawing.Size(230, 23);
            this.VehicleIDBox.TabIndex = 9;
            // 
            // IDBtn
            // 
            this.IDBtn.Location = new System.Drawing.Point(697, 41);
            this.IDBtn.Name = "IDBtn";
            this.IDBtn.Size = new System.Drawing.Size(91, 69);
            this.IDBtn.TabIndex = 10;
            this.IDBtn.Text = "Submit";
            this.IDBtn.UseVisualStyleBackColor = true;
            this.IDBtn.Click += new System.EventHandler(this.IDBtn_Click);
            // 
            // MoreInfoCheckBox
            // 
            this.MoreInfoCheckBox.AutoSize = true;
            this.MoreInfoCheckBox.Location = new System.Drawing.Point(558, 41);
            this.MoreInfoCheckBox.Name = "MoreInfoCheckBox";
            this.MoreInfoCheckBox.Size = new System.Drawing.Size(78, 19);
            this.MoreInfoCheckBox.TabIndex = 11;
            this.MoreInfoCheckBox.Text = "More Info";
            this.MoreInfoCheckBox.UseVisualStyleBackColor = true;
            // 
            // RentBox
            // 
            this.RentBox.AutoSize = true;
            this.RentBox.Location = new System.Drawing.Point(558, 66);
            this.RentBox.Name = "RentBox";
            this.RentBox.Size = new System.Drawing.Size(112, 19);
            this.RentBox.TabIndex = 12;
            this.RentBox.Text = "Rent this Vehicle";
            this.RentBox.UseVisualStyleBackColor = true;
            // 
            // RemoveBox
            // 
            this.RemoveBox.AutoSize = true;
            this.RemoveBox.Location = new System.Drawing.Point(558, 91);
            this.RemoveBox.Name = "RemoveBox";
            this.RemoveBox.Size = new System.Drawing.Size(133, 19);
            this.RemoveBox.TabIndex = 13;
            this.RemoveBox.Text = "Remove This Vehicle";
            this.RemoveBox.UseVisualStyleBackColor = true;
            // 
            // RemoveKeyBox
            // 
            this.RemoveKeyBox.Location = new System.Drawing.Point(558, 116);
            this.RemoveKeyBox.Name = "RemoveKeyBox";
            this.RemoveKeyBox.PlaceholderText = "Clearance Key";
            this.RemoveKeyBox.Size = new System.Drawing.Size(226, 23);
            this.RemoveKeyBox.TabIndex = 14;
            // 
            // MightyMotors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
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
    }
}