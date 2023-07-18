namespace HospitalSimulatorForms
{
    partial class DarAlta
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
            this.buttonSoyMedico = new System.Windows.Forms.Button();
            this.buttonSoyPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSoyMedico
            // 
            this.buttonSoyMedico.Location = new System.Drawing.Point(225, 250);
            this.buttonSoyMedico.Name = "buttonSoyMedico";
            this.buttonSoyMedico.Size = new System.Drawing.Size(350, 150);
            this.buttonSoyMedico.TabIndex = 3;
            this.buttonSoyMedico.Text = "Medico";
            this.buttonSoyMedico.UseVisualStyleBackColor = true;
            // 
            // buttonSoyPaciente
            // 
            this.buttonSoyPaciente.Location = new System.Drawing.Point(225, 50);
            this.buttonSoyPaciente.Name = "buttonSoyPaciente";
            this.buttonSoyPaciente.Size = new System.Drawing.Size(350, 150);
            this.buttonSoyPaciente.TabIndex = 2;
            this.buttonSoyPaciente.Text = "Paciente";
            this.buttonSoyPaciente.UseVisualStyleBackColor = true;
            // 
            // DarAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSoyMedico);
            this.Controls.Add(this.buttonSoyPaciente);
            this.Name = "DarAlta";
            this.Text = "DarAlta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSoyMedico;
        private System.Windows.Forms.Button buttonSoyPaciente;
    }
}