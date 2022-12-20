
namespace STO
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
            this.dgvListOrders = new System.Windows.Forms.DataGridView();
            this.labListOrders = new System.Windows.Forms.Label();
            this.btAddOrder = new System.Windows.Forms.Button();
            this.btDelOrder = new System.Windows.Forms.Button();
            this.btAddClient = new System.Windows.Forms.Button();
            this.btWorks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterClients = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListOrders
            // 
            this.dgvListOrders.AllowUserToAddRows = false;
            this.dgvListOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOrders.Location = new System.Drawing.Point(12, 74);
            this.dgvListOrders.Name = "dgvListOrders";
            this.dgvListOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOrders.Size = new System.Drawing.Size(776, 364);
            this.dgvListOrders.TabIndex = 0;
            this.dgvListOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvListOrders_MouseDoubleClick);
            // 
            // labListOrders
            // 
            this.labListOrders.AutoSize = true;
            this.labListOrders.Location = new System.Drawing.Point(12, 46);
            this.labListOrders.Name = "labListOrders";
            this.labListOrders.Size = new System.Drawing.Size(83, 13);
            this.labListOrders.TabIndex = 1;
            this.labListOrders.Text = "Список заявок";
            // 
            // btAddOrder
            // 
            this.btAddOrder.Location = new System.Drawing.Point(12, 12);
            this.btAddOrder.Name = "btAddOrder";
            this.btAddOrder.Size = new System.Drawing.Size(128, 23);
            this.btAddOrder.TabIndex = 2;
            this.btAddOrder.Text = "Добавить заявку";
            this.btAddOrder.UseVisualStyleBackColor = true;
            this.btAddOrder.Click += new System.EventHandler(this.btAddOrder_Click);
            // 
            // btDelOrder
            // 
            this.btDelOrder.Location = new System.Drawing.Point(146, 12);
            this.btDelOrder.Name = "btDelOrder";
            this.btDelOrder.Size = new System.Drawing.Size(140, 23);
            this.btDelOrder.TabIndex = 3;
            this.btDelOrder.Text = "Выполнить заявку";
            this.btDelOrder.UseVisualStyleBackColor = true;
            this.btDelOrder.Click += new System.EventHandler(this.btDelOrder_Click);
            // 
            // btAddClient
            // 
            this.btAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddClient.Location = new System.Drawing.Point(653, 12);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(135, 23);
            this.btAddClient.TabIndex = 4;
            this.btAddClient.Text = "Клиенты";
            this.btAddClient.UseVisualStyleBackColor = true;
            this.btAddClient.Click += new System.EventHandler(this.btAddClient_Click);
            // 
            // btWorks
            // 
            this.btWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btWorks.Location = new System.Drawing.Point(525, 12);
            this.btWorks.Name = "btWorks";
            this.btWorks.Size = new System.Drawing.Size(122, 23);
            this.btWorks.TabIndex = 5;
            this.btWorks.Text = "Виды работ";
            this.btWorks.UseVisualStyleBackColor = true;
            this.btWorks.Click += new System.EventHandler(this.btWorks_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фильтр по клиенту";
            // 
            // cbFilterClients
            // 
            this.cbFilterClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterClients.FormattingEnabled = true;
            this.cbFilterClients.Location = new System.Drawing.Point(624, 46);
            this.cbFilterClients.Name = "cbFilterClients";
            this.cbFilterClients.Size = new System.Drawing.Size(164, 21);
            this.cbFilterClients.TabIndex = 7;
            this.cbFilterClients.SelectedIndexChanged += new System.EventHandler(this.cbFilterClients_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbFilterClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWorks);
            this.Controls.Add(this.btAddClient);
            this.Controls.Add(this.btDelOrder);
            this.Controls.Add(this.btAddOrder);
            this.Controls.Add(this.labListOrders);
            this.Controls.Add(this.dgvListOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListOrders;
        private System.Windows.Forms.Label labListOrders;
        private System.Windows.Forms.Button btAddOrder;
        private System.Windows.Forms.Button btDelOrder;
        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.Button btWorks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterClients;
    }
}

