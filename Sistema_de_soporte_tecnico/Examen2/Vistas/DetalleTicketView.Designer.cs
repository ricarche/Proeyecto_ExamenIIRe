
namespace Examen2.Vistas
{
    partial class DetalleTicketView
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MostrarTicketButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "DETALLES DE LOS TICKET";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LimpiarButton);
            this.groupBox1.Controls.Add(this.MostrarTicketButton);
            this.groupBox1.Location = new System.Drawing.Point(265, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 289);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // MostrarTicketButton
            // 
            this.MostrarTicketButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarTicketButton.Location = new System.Drawing.Point(48, 47);
            this.MostrarTicketButton.Name = "MostrarTicketButton";
            this.MostrarTicketButton.Size = new System.Drawing.Size(174, 62);
            this.MostrarTicketButton.TabIndex = 0;
            this.MostrarTicketButton.Text = "Mostrar Tickets";
            this.MostrarTicketButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(48, 162);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(174, 62);
            this.LimpiarButton.TabIndex = 1;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(-2, 434);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.RowHeadersWidth = 51;
            this.DetalleDataGridView.RowTemplate.Height = 24;
            this.DetalleDataGridView.Size = new System.Drawing.Size(780, 182);
            this.DetalleDataGridView.TabIndex = 15;
            // 
            // DetalleTicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(776, 615);
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DetalleTicketView";
            this.Text = "DetalleTicketView";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button LimpiarButton;
        public System.Windows.Forms.Button MostrarTicketButton;
        public System.Windows.Forms.DataGridView DetalleDataGridView;
    }
}