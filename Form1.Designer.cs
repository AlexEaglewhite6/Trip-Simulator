namespace Trip_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TankVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.TankVolumeValueLabel = new System.Windows.Forms.Label();
            this.ConsumptionValueTextBox = new System.Windows.Forms.TextBox();
            this.DistanceValueTextBox = new System.Windows.Forms.TextBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.ConsumptionLabel = new System.Windows.Forms.Label();
            this.TankVolumeLabel = new System.Windows.Forms.Label();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.TypesOfGasGroupBox = new System.Windows.Forms.GroupBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Gas100CheckBox = new System.Windows.Forms.CheckBox();
            this.GasDieselCheckBox = new System.Windows.Forms.CheckBox();
            this.Gas92CheckBox = new System.Windows.Forms.CheckBox();
            this.Gas95CheckBox = new System.Windows.Forms.CheckBox();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.BackInfoPanel = new System.Windows.Forms.Panel();
            this.AllRefillLabel = new System.Windows.Forms.Label();
            this.AllPriceLabel = new System.Windows.Forms.Label();
            this.BackRefillLabel = new System.Windows.Forms.Label();
            this.BackPriceLabel = new System.Windows.Forms.Label();
            this.TheWayBackCheckBox = new System.Windows.Forms.CheckBox();
            this.RefillLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TankVolumeTrackBar)).BeginInit();
            this.InputGroupBox.SuspendLayout();
            this.TypesOfGasGroupBox.SuspendLayout();
            this.OutputGroupBox.SuspendLayout();
            this.BackInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TankVolumeTrackBar
            // 
            this.TankVolumeTrackBar.Location = new System.Drawing.Point(186, 57);
            this.TankVolumeTrackBar.Maximum = 65;
            this.TankVolumeTrackBar.Minimum = 1;
            this.TankVolumeTrackBar.Name = "TankVolumeTrackBar";
            this.TankVolumeTrackBar.Size = new System.Drawing.Size(106, 45);
            this.TankVolumeTrackBar.SmallChange = 65;
            this.TankVolumeTrackBar.TabIndex = 0;
            this.TankVolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TankVolumeTrackBar.Value = 1;
            this.TankVolumeTrackBar.Scroll += new System.EventHandler(this.TankVolumeTrackBar_Scroll);
            // 
            // TankVolumeValueLabel
            // 
            this.TankVolumeValueLabel.AutoSize = true;
            this.TankVolumeValueLabel.Location = new System.Drawing.Point(298, 62);
            this.TankVolumeValueLabel.Name = "TankVolumeValueLabel";
            this.TankVolumeValueLabel.Size = new System.Drawing.Size(13, 13);
            this.TankVolumeValueLabel.TabIndex = 1;
            this.TankVolumeValueLabel.Text = "1";
            // 
            // ConsumptionValueTextBox
            // 
            this.ConsumptionValueTextBox.Location = new System.Drawing.Point(189, 13);
            this.ConsumptionValueTextBox.Name = "ConsumptionValueTextBox";
            this.ConsumptionValueTextBox.Size = new System.Drawing.Size(128, 20);
            this.ConsumptionValueTextBox.TabIndex = 2;
            this.ConsumptionValueTextBox.TextChanged += new System.EventHandler(this.ConsumptionValueTextBox_TextChanged);
            // 
            // DistanceValueTextBox
            // 
            this.DistanceValueTextBox.Location = new System.Drawing.Point(189, 35);
            this.DistanceValueTextBox.Name = "DistanceValueTextBox";
            this.DistanceValueTextBox.Size = new System.Drawing.Size(128, 20);
            this.DistanceValueTextBox.TabIndex = 3;
            this.DistanceValueTextBox.TextChanged += new System.EventHandler(this.DistanceValueTextBox_TextChanged);
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(3, 38);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(184, 13);
            this.DistanceLabel.TabIndex = 4;
            this.DistanceLabel.Text = "Расстояние до пункта назначения:";
            // 
            // ConsumptionLabel
            // 
            this.ConsumptionLabel.AutoSize = true;
            this.ConsumptionLabel.Location = new System.Drawing.Point(12, 16);
            this.ConsumptionLabel.Name = "ConsumptionLabel";
            this.ConsumptionLabel.Size = new System.Drawing.Size(174, 13);
            this.ConsumptionLabel.TabIndex = 5;
            this.ConsumptionLabel.Text = "Потребление топлива на 100 км:";
            // 
            // TankVolumeLabel
            // 
            this.TankVolumeLabel.AutoSize = true;
            this.TankVolumeLabel.Location = new System.Drawing.Point(111, 57);
            this.TankVolumeLabel.Name = "TankVolumeLabel";
            this.TankVolumeLabel.Size = new System.Drawing.Size(72, 13);
            this.TankVolumeLabel.TabIndex = 6;
            this.TankVolumeLabel.Text = "Объем бака:";
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.ConsumptionLabel);
            this.InputGroupBox.Controls.Add(this.TankVolumeValueLabel);
            this.InputGroupBox.Controls.Add(this.TankVolumeLabel);
            this.InputGroupBox.Controls.Add(this.TankVolumeTrackBar);
            this.InputGroupBox.Controls.Add(this.ConsumptionValueTextBox);
            this.InputGroupBox.Controls.Add(this.DistanceValueTextBox);
            this.InputGroupBox.Controls.Add(this.DistanceLabel);
            this.InputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(320, 107);
            this.InputGroupBox.TabIndex = 7;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Входные данные";
            // 
            // TypesOfGasGroupBox
            // 
            this.TypesOfGasGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TypesOfGasGroupBox.Controls.Add(this.CalculateButton);
            this.TypesOfGasGroupBox.Controls.Add(this.Gas100CheckBox);
            this.TypesOfGasGroupBox.Controls.Add(this.GasDieselCheckBox);
            this.TypesOfGasGroupBox.Controls.Add(this.Gas92CheckBox);
            this.TypesOfGasGroupBox.Controls.Add(this.Gas95CheckBox);
            this.TypesOfGasGroupBox.Location = new System.Drawing.Point(12, 125);
            this.TypesOfGasGroupBox.Name = "TypesOfGasGroupBox";
            this.TypesOfGasGroupBox.Size = new System.Drawing.Size(321, 117);
            this.TypesOfGasGroupBox.TabIndex = 8;
            this.TypesOfGasGroupBox.TabStop = false;
            this.TypesOfGasGroupBox.Text = "Виды топлива";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(180, 41);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(128, 39);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Gas100CheckBox
            // 
            this.Gas100CheckBox.AutoSize = true;
            this.Gas100CheckBox.Location = new System.Drawing.Point(9, 65);
            this.Gas100CheckBox.Name = "Gas100CheckBox";
            this.Gas100CheckBox.Size = new System.Drawing.Size(86, 17);
            this.Gas100CheckBox.TabIndex = 2;
            this.Gas100CheckBox.Text = "100 бензин ";
            this.Gas100CheckBox.UseVisualStyleBackColor = true;
            this.Gas100CheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxChecker);
            // 
            // GasDieselCheckBox
            // 
            this.GasDieselCheckBox.AutoSize = true;
            this.GasDieselCheckBox.Location = new System.Drawing.Point(9, 88);
            this.GasDieselCheckBox.Name = "GasDieselCheckBox";
            this.GasDieselCheckBox.Size = new System.Drawing.Size(65, 17);
            this.GasDieselCheckBox.TabIndex = 3;
            this.GasDieselCheckBox.Text = "Дизель";
            this.GasDieselCheckBox.UseVisualStyleBackColor = true;
            this.GasDieselCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxChecker);
            // 
            // Gas92CheckBox
            // 
            this.Gas92CheckBox.AutoSize = true;
            this.Gas92CheckBox.Location = new System.Drawing.Point(9, 19);
            this.Gas92CheckBox.Name = "Gas92CheckBox";
            this.Gas92CheckBox.Size = new System.Drawing.Size(77, 17);
            this.Gas92CheckBox.TabIndex = 0;
            this.Gas92CheckBox.Text = "92 бензин";
            this.Gas92CheckBox.UseVisualStyleBackColor = true;
            this.Gas92CheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxChecker);
            // 
            // Gas95CheckBox
            // 
            this.Gas95CheckBox.AutoSize = true;
            this.Gas95CheckBox.Location = new System.Drawing.Point(9, 42);
            this.Gas95CheckBox.Name = "Gas95CheckBox";
            this.Gas95CheckBox.Size = new System.Drawing.Size(80, 17);
            this.Gas95CheckBox.TabIndex = 1;
            this.Gas95CheckBox.Text = "95 бензин ";
            this.Gas95CheckBox.UseVisualStyleBackColor = true;
            this.Gas95CheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxChecker);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputGroupBox.Controls.Add(this.BackInfoPanel);
            this.OutputGroupBox.Controls.Add(this.TheWayBackCheckBox);
            this.OutputGroupBox.Controls.Add(this.RefillLabel);
            this.OutputGroupBox.Controls.Add(this.PriceLabel);
            this.OutputGroupBox.Location = new System.Drawing.Point(339, 13);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(311, 229);
            this.OutputGroupBox.TabIndex = 9;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Вывод";
            // 
            // BackInfoPanel
            // 
            this.BackInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackInfoPanel.Controls.Add(this.AllRefillLabel);
            this.BackInfoPanel.Controls.Add(this.AllPriceLabel);
            this.BackInfoPanel.Controls.Add(this.BackRefillLabel);
            this.BackInfoPanel.Controls.Add(this.BackPriceLabel);
            this.BackInfoPanel.Location = new System.Drawing.Point(10, 93);
            this.BackInfoPanel.Name = "BackInfoPanel";
            this.BackInfoPanel.Size = new System.Drawing.Size(295, 133);
            this.BackInfoPanel.TabIndex = 10;
            // 
            // AllRefillLabel
            // 
            this.AllRefillLabel.AutoSize = true;
            this.AllRefillLabel.Location = new System.Drawing.Point(3, 99);
            this.AllRefillLabel.Name = "AllRefillLabel";
            this.AllRefillLabel.Size = new System.Drawing.Size(157, 13);
            this.AllRefillLabel.TabIndex = 6;
            this.AllRefillLabel.Text = "Общее количество заправок:";
            // 
            // AllPriceLabel
            // 
            this.AllPriceLabel.AutoSize = true;
            this.AllPriceLabel.Location = new System.Drawing.Point(3, 79);
            this.AllPriceLabel.Name = "AllPriceLabel";
            this.AllPriceLabel.Size = new System.Drawing.Size(147, 13);
            this.AllPriceLabel.TabIndex = 5;
            this.AllPriceLabel.Text = "Общая стоимость поездки:";
            // 
            // BackRefillLabel
            // 
            this.BackRefillLabel.AutoSize = true;
            this.BackRefillLabel.Location = new System.Drawing.Point(3, 36);
            this.BackRefillLabel.Name = "BackRefillLabel";
            this.BackRefillLabel.Size = new System.Drawing.Size(120, 13);
            this.BackRefillLabel.TabIndex = 4;
            this.BackRefillLabel.Text = "Количество заправок:";
            // 
            // BackPriceLabel
            // 
            this.BackPriceLabel.AutoSize = true;
            this.BackPriceLabel.Location = new System.Drawing.Point(3, 15);
            this.BackPriceLabel.Name = "BackPriceLabel";
            this.BackPriceLabel.Size = new System.Drawing.Size(110, 13);
            this.BackPriceLabel.TabIndex = 3;
            this.BackPriceLabel.Text = "Стоимость поездки:";
            // 
            // TheWayBackCheckBox
            // 
            this.TheWayBackCheckBox.AutoSize = true;
            this.TheWayBackCheckBox.Location = new System.Drawing.Point(10, 70);
            this.TheWayBackCheckBox.Name = "TheWayBackCheckBox";
            this.TheWayBackCheckBox.Size = new System.Drawing.Size(141, 17);
            this.TheWayBackCheckBox.TabIndex = 2;
            this.TheWayBackCheckBox.Text = "Расчет обратного пути";
            this.TheWayBackCheckBox.UseVisualStyleBackColor = true;
            this.TheWayBackCheckBox.CheckedChanged += new System.EventHandler(this.TheWayBackCheckBox_CheckedChanged);
            // 
            // RefillLabel
            // 
            this.RefillLabel.AutoSize = true;
            this.RefillLabel.Location = new System.Drawing.Point(7, 41);
            this.RefillLabel.Name = "RefillLabel";
            this.RefillLabel.Size = new System.Drawing.Size(120, 13);
            this.RefillLabel.TabIndex = 1;
            this.RefillLabel.Text = "Количество заправок:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(7, 20);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(110, 13);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Стоимость поездки:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 244);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.TypesOfGasGroupBox);
            this.Controls.Add(this.InputGroupBox);
            this.MinimumSize = new System.Drawing.Size(620, 283);
            this.Name = "Form1";
            this.Text = "Trip Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TankVolumeTrackBar)).EndInit();
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.TypesOfGasGroupBox.ResumeLayout(false);
            this.TypesOfGasGroupBox.PerformLayout();
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.BackInfoPanel.ResumeLayout(false);
            this.BackInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar TankVolumeTrackBar;
        private System.Windows.Forms.Label TankVolumeValueLabel;
        private System.Windows.Forms.TextBox ConsumptionValueTextBox;
        private System.Windows.Forms.TextBox DistanceValueTextBox;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label ConsumptionLabel;
        private System.Windows.Forms.Label TankVolumeLabel;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.GroupBox TypesOfGasGroupBox;
        private System.Windows.Forms.CheckBox GasDieselCheckBox;
        private System.Windows.Forms.CheckBox Gas100CheckBox;
        private System.Windows.Forms.CheckBox Gas95CheckBox;
        private System.Windows.Forms.CheckBox Gas92CheckBox;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.Label BackRefillLabel;
        private System.Windows.Forms.Label BackPriceLabel;
        private System.Windows.Forms.CheckBox TheWayBackCheckBox;
        private System.Windows.Forms.Label RefillLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Panel BackInfoPanel;
        private System.Windows.Forms.Label AllRefillLabel;
        private System.Windows.Forms.Label AllPriceLabel;
        private System.Windows.Forms.Button CalculateButton;
    }
}

