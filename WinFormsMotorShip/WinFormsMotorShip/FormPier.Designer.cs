
namespace WinFormsMotorShip
{
    partial class FormPier
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
            this.parkShipButton = new System.Windows.Forms.Button();
            this.pierPictureBox = new System.Windows.Forms.PictureBox();
            this.parkMotorShipButton = new System.Windows.Forms.Button();
            this.takeShipGroupBox = new System.Windows.Forms.GroupBox();
            this.takeShipButton = new System.Windows.Forms.Button();
            this.parkingPlaceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.placeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pierPictureBox)).BeginInit();
            this.takeShipGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // parkShipButton
            // 
            this.parkShipButton.Location = new System.Drawing.Point(1036, 12);
            this.parkShipButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.parkShipButton.Name = "parkShipButton";
            this.parkShipButton.Size = new System.Drawing.Size(164, 27);
            this.parkShipButton.TabIndex = 2;
            this.parkShipButton.Text = "Пришвартовать корабль";
            this.parkShipButton.UseVisualStyleBackColor = true;
            this.parkShipButton.Click += new System.EventHandler(this.ParkShipButton_Click);
            // 
            // pierPictureBox
            // 
            this.pierPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pierPictureBox.Location = new System.Drawing.Point(1, 1);
            this.pierPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pierPictureBox.Name = "pierPictureBox";
            this.pierPictureBox.Size = new System.Drawing.Size(1013, 513);
            this.pierPictureBox.TabIndex = 1;
            this.pierPictureBox.TabStop = false;
            // 
            // parkMotorShipButton
            // 
            this.parkMotorShipButton.Location = new System.Drawing.Point(1036, 45);
            this.parkMotorShipButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.parkMotorShipButton.Name = "parkMotorShipButton";
            this.parkMotorShipButton.Size = new System.Drawing.Size(164, 27);
            this.parkMotorShipButton.TabIndex = 3;
            this.parkMotorShipButton.Text = "Пришвартовать теплоход";
            this.parkMotorShipButton.UseVisualStyleBackColor = true;
            this.parkMotorShipButton.Click += new System.EventHandler(this.ParkMotorShipButton_Click);
            // 
            // takeShipGroupBox
            // 
            this.takeShipGroupBox.Controls.Add(this.takeShipButton);
            this.takeShipGroupBox.Controls.Add(this.parkingPlaceMaskedTextBox);
            this.takeShipGroupBox.Controls.Add(this.placeLabel);
            this.takeShipGroupBox.Location = new System.Drawing.Point(1036, 79);
            this.takeShipGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.takeShipGroupBox.Name = "takeShipGroupBox";
            this.takeShipGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.takeShipGroupBox.Size = new System.Drawing.Size(164, 105);
            this.takeShipGroupBox.TabIndex = 4;
            this.takeShipGroupBox.TabStop = false;
            this.takeShipGroupBox.Text = "Забрать корабль";
            // 
            // takeShipButton
            // 
            this.takeShipButton.Location = new System.Drawing.Point(40, 59);
            this.takeShipButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.takeShipButton.Name = "takeShipButton";
            this.takeShipButton.Size = new System.Drawing.Size(88, 27);
            this.takeShipButton.TabIndex = 5;
            this.takeShipButton.Text = "Забрать";
            this.takeShipButton.UseVisualStyleBackColor = true;
            this.takeShipButton.Click += new System.EventHandler(this.TakeShipButton_Click);
            // 
            // parkingPlaceMaskedTextBox
            // 
            this.parkingPlaceMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.parkingPlaceMaskedTextBox.Location = new System.Drawing.Point(92, 29);
            this.parkingPlaceMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.parkingPlaceMaskedTextBox.Mask = "00";
            this.parkingPlaceMaskedTextBox.Name = "parkingPlaceMaskedTextBox";
            this.parkingPlaceMaskedTextBox.Size = new System.Drawing.Size(33, 23);
            this.parkingPlaceMaskedTextBox.TabIndex = 1;
            this.parkingPlaceMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.parkingPlaceMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(36, 32);
            this.placeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(45, 15);
            this.placeLabel.TabIndex = 0;
            this.placeLabel.Text = "Место:";
            // 
            // FormPier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 515);
            this.Controls.Add(this.takeShipGroupBox);
            this.Controls.Add(this.parkMotorShipButton);
            this.Controls.Add(this.parkShipButton);
            this.Controls.Add(this.pierPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormPier";
            this.Text = "Пристань";
            ((System.ComponentModel.ISupportInitialize)(this.pierPictureBox)).EndInit();
            this.takeShipGroupBox.ResumeLayout(false);
            this.takeShipGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pierPictureBox;
        private System.Windows.Forms.Button parkShipButton;
        private System.Windows.Forms.Button parkMotorShipButton;
        private System.Windows.Forms.GroupBox takeShipGroupBox;
        private System.Windows.Forms.Button takeShipButton;
        private System.Windows.Forms.MaskedTextBox parkingPlaceMaskedTextBox;
        private System.Windows.Forms.Label placeLabel;
    }
}