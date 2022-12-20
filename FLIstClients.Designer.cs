
namespace STO
{
    partial class FLIstClients
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
            this.btAddClient = new System.Windows.Forms.Button();
            this.btDelClient = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddClient
            // 
            this.btAddClient.Location = new System.Drawing.Point(12, 12);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(75, 23);
            this.btAddClient.TabIndex = 0;
            this.btAddClient.Text = "Добавить";
            this.btAddClient.UseVisualStyleBackColor = true;
            this.btAddClient.Click += new System.EventHandler(this.btAddClient_Click);
            // 
            // btDelClient
            // 
            this.btDelClient.Location = new System.Drawing.Point(95, 12);
            this.btDelClient.Name = "btDelClient";
            this.btDelClient.Size = new System.Drawing.Size(75, 23);
            this.btDelClient.TabIndex = 1;
            this.btDelClient.Text = "Удалить";
            this.btDelClient.UseVisualStyleBackColor = true;
            this.btDelClient.Click += new System.EventHandler(this.btDelClient_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(316, 384);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(12, 41);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(379, 337);
            this.dgvClients.TabIndex = 4;
            // 
            // FLIstClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(403, 419);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDelClient);
            this.Controls.Add(this.btAddClient);
            this.Name = "FLIstClients";
            this.Text = "Список клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.Button btDelClient;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView dgvClients;
    }
}