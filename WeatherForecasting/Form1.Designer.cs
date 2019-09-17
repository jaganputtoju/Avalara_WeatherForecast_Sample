namespace WeatherForecasting
{
    partial class Form1
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
            this.btnGetWeatherForeacst = new System.Windows.Forms.Button();
            this.dtForecastDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextWaetherResult = new System.Windows.Forms.RichTextBox();
            this.lblWeatherDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetWeatherForeacst
            // 
            this.btnGetWeatherForeacst.Location = new System.Drawing.Point(518, 100);
            this.btnGetWeatherForeacst.Name = "btnGetWeatherForeacst";
            this.btnGetWeatherForeacst.Size = new System.Drawing.Size(161, 23);
            this.btnGetWeatherForeacst.TabIndex = 0;
            this.btnGetWeatherForeacst.Text = "Get Weather Forecasting";
            this.btnGetWeatherForeacst.UseVisualStyleBackColor = true;
            this.btnGetWeatherForeacst.Click += new System.EventHandler(this.btnGetWeatherForeacst_Click);
            // 
            // dtForecastDay
            // 
            this.dtForecastDay.Location = new System.Drawing.Point(217, 103);
            this.dtForecastDay.Name = "dtForecastDay";
            this.dtForecastDay.Size = new System.Drawing.Size(200, 20);
            this.dtForecastDay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select A Date:";
            // 
            // richTextWaetherResult
            // 
            this.richTextWaetherResult.Location = new System.Drawing.Point(47, 188);
            this.richTextWaetherResult.Name = "richTextWaetherResult";
            this.richTextWaetherResult.Size = new System.Drawing.Size(987, 198);
            this.richTextWaetherResult.TabIndex = 3;
            this.richTextWaetherResult.Text = "";
            // 
            // lblWeatherDay
            // 
            this.lblWeatherDay.AutoSize = true;
            this.lblWeatherDay.Location = new System.Drawing.Point(44, 172);
            this.lblWeatherDay.Name = "lblWeatherDay";
            this.lblWeatherDay.Size = new System.Drawing.Size(91, 13);
            this.lblWeatherDay.TabIndex = 4;
            this.lblWeatherDay.Text = "Weather For Day ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 445);
            this.Controls.Add(this.lblWeatherDay);
            this.Controls.Add(this.richTextWaetherResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtForecastDay);
            this.Controls.Add(this.btnGetWeatherForeacst);
            this.Name = "Form1";
            this.Text = "Weather Forecasting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetWeatherForeacst;
        private System.Windows.Forms.DateTimePicker dtForecastDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextWaetherResult;
        private System.Windows.Forms.Label lblWeatherDay;
    }
}

