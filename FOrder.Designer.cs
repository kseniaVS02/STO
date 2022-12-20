
namespace STO
{
    partial class FOrder
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
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFromWork = new System.Windows.Forms.ListBox();
            this.lbToWork = new System.Windows.Forms.ListBox();
            this.btApply = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAddWork = new System.Windows.Forms.Button();
            this.btDelWork = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // cbClient
            // 
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(103, 12);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(400, 21);
            this.cbClient.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Работы";
            // 
            // lbFromWork
            // 
            this.lbFromWork.FormattingEnabled = true;
            this.lbFromWork.Location = new System.Drawing.Point(12, 105);
            this.lbFromWork.Name = "lbFromWork";
            this.lbFromWork.Size = new System.Drawing.Size(220, 225);
            this.lbFromWork.TabIndex = 4;
            // 
            // lbToWork
            // 
            this.lbToWork.FormattingEnabled = true;
            this.lbToWork.Location = new System.Drawing.Point(277, 105);
            this.lbToWork.Name = "lbToWork";
            this.lbToWork.Size = new System.Drawing.Size(226, 225);
            this.lbToWork.TabIndex = 5;
            // 
            // btApply
            // 
            this.btApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btApply.Location = new System.Drawing.Point(350, 356);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 23);
            this.btApply.TabIndex = 6;
            this.btApply.Text = "Применить";
            this.btApply.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(431, 356);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btAddWork
            // 
            this.btAddWork.Location = new System.Drawing.Point(238, 171);
            this.btAddWork.Name = "btAddWork";
            this.btAddWork.Size = new System.Drawing.Size(33, 23);
            this.btAddWork.TabIndex = 8;
            this.btAddWork.Text = ">>";
            this.btAddWork.UseVisualStyleBackColor = true;
            this.btAddWork.Click += new System.EventHandler(this.btAddWork_Click);
            // 
            // btDelWork
            // 
            this.btDelWork.Location = new System.Drawing.Point(238, 200);
            this.btDelWork.Name = "btDelWork";
            this.btDelWork.Size = new System.Drawing.Size(33, 23);
            this.btDelWork.TabIndex = 9;
            this.btDelWork.Text = "<<";
            this.btDelWork.UseVisualStyleBackColor = true;
            this.btDelWork.Click += new System.EventHandler(this.btDelWork_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата";
            // 
            // dtpOrder
            // 
            this.dtpOrder.Location = new System.Drawing.Point(103, 43);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(168, 20);
            this.dtpOrder.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Часы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Минуты";
            // 
            // cbHour
            // 
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(327, 43);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(59, 21);
            this.cbHour.TabIndex = 11;
            // 
            // cbMinutes
            // 
            this.cbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Location = new System.Drawing.Point(444, 42);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(59, 21);
            this.cbMinutes.TabIndex = 12;
            // 
            // FOrder
            // 
            this.AcceptButton = this.btApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(518, 391);
            this.Controls.Add(this.cbMinutes);
            this.Controls.Add(this.cbHour);
            this.Controls.Add(this.dtpOrder);
            this.Controls.Add(this.btDelWork);
            this.Controls.Add(this.btAddWork);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.lbToWork);
            this.Controls.Add(this.lbFromWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FOrder";
            this.Text = "Заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFromWork;
        private System.Windows.Forms.ListBox lbToWork;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAddWork;
        private System.Windows.Forms.Button btDelWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbMinutes;
    }
}