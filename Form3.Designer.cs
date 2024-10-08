namespace NuevaAppBarberia
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblService = new System.Windows.Forms.Label();
            this.cbxService = new System.Windows.Forms.ComboBox();
            this.lblBarber = new System.Windows.Forms.Label();
            this.cbxBarber = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(214, 133);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(75, 23);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Servicio:";
            // 
            // cbxService
            // 
            this.cbxService.FormattingEnabled = true;
            this.cbxService.Items.AddRange(new object[] {
            "Servicio 1",
            "Servicio 2",
            "Servicio 3"});
            this.cbxService.Location = new System.Drawing.Point(217, 168);
            this.cbxService.Name = "cbxService";
            this.cbxService.Size = new System.Drawing.Size(121, 24);
            this.cbxService.TabIndex = 1;
            // 
            // lblBarber
            // 
            this.lblBarber.AutoSize = true;
            this.lblBarber.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarber.Location = new System.Drawing.Point(215, 266);
            this.lblBarber.Name = "lblBarber";
            this.lblBarber.Size = new System.Drawing.Size(74, 23);
            this.lblBarber.TabIndex = 2;
            this.lblBarber.Text = "Barbero:";
            // 
            // cbxBarber
            // 
            this.cbxBarber.FormattingEnabled = true;
            this.cbxBarber.Items.AddRange(new object[] {
            "Barbero Juan",
            "Barbero Marrrco",
            "Barbero Sosa"});
            this.cbxBarber.Location = new System.Drawing.Point(218, 304);
            this.cbxBarber.Name = "cbxBarber";
            this.cbxBarber.Size = new System.Drawing.Size(121, 24);
            this.cbxBarber.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(214, 381);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Fecha:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(218, 407);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(443, 381);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 23);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Hora:";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(447, 407);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 22);
            this.dtpTime.TabIndex = 7;
            // 
            // btnSchedule
            // 
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSchedule.Location = new System.Drawing.Point(345, 471);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(92, 34);
            this.btnSchedule.TabIndex = 8;
            this.btnSchedule.Text = "Agendar";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(276, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Agenda tu cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Costos por servicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Servicio 1: corte de cabello: $100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Servicio 2: corte de barba: $50";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Servicio 3: corte de cabello y barba: $120";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nuestros mejores barberos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Barbero 1: Juan Salas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Barbero 2: El Chocha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Barbero 3: El Marrrrrrco";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbxBarber);
            this.Controls.Add(this.lblBarber);
            this.Controls.Add(this.cbxService);
            this.Controls.Add(this.lblService);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cbxService;
        private System.Windows.Forms.Label lblBarber;
        private System.Windows.Forms.ComboBox cbxBarber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}