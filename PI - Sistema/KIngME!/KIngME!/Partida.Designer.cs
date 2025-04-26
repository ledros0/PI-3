namespace KIngME_
{
    partial class Partida
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
            this.btnCartas = new System.Windows.Forms.Button();
            this.lblCartas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCartas
            // 
            this.btnCartas.Location = new System.Drawing.Point(50, 66);
            this.btnCartas.Name = "btnCartas";
            this.btnCartas.Size = new System.Drawing.Size(75, 23);
            this.btnCartas.TabIndex = 0;
            this.btnCartas.Text = "Pegar cartas";
            this.btnCartas.UseVisualStyleBackColor = true;
            this.btnCartas.Click += new System.EventHandler(this.btnCartas_Click);
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Location = new System.Drawing.Point(12, 32);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(43, 13);
            this.lblCartas.TabIndex = 1;
            this.lblCartas.Text = "Cartas: ";
            // 
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCartas);
            this.Controls.Add(this.btnCartas);
            this.Name = "Partida";
            this.Text = "Partida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCartas;
        private System.Windows.Forms.Label lblCartas;
    }
}