
namespace STO
{
    partial class FWorks
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.panelAddItem = new System.Windows.Forms.Panel();
            this.btAddCancel = new System.Windows.Forms.Button();
            this.btAddItem = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWorks = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.panelAddItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 12);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(109, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(127, 12);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(109, 23);
            this.btDel.TabIndex = 0;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // panelAddItem
            // 
            this.panelAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddItem.Controls.Add(this.btAddCancel);
            this.panelAddItem.Controls.Add(this.btAddItem);
            this.panelAddItem.Controls.Add(this.tbPrice);
            this.panelAddItem.Controls.Add(this.label2);
            this.panelAddItem.Controls.Add(this.tbName);
            this.panelAddItem.Controls.Add(this.label1);
            this.panelAddItem.Location = new System.Drawing.Point(12, 41);
            this.panelAddItem.Name = "panelAddItem";
            this.panelAddItem.Size = new System.Drawing.Size(522, 38);
            this.panelAddItem.TabIndex = 1;
            this.panelAddItem.Visible = false;
            // 
            // btAddCancel
            // 
            this.btAddCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddCancel.Location = new System.Drawing.Point(454, 9);
            this.btAddCancel.Name = "btAddCancel";
            this.btAddCancel.Size = new System.Drawing.Size(65, 23);
            this.btAddCancel.TabIndex = 3;
            this.btAddCancel.Text = "Отмена";
            this.btAddCancel.UseVisualStyleBackColor = true;
            this.btAddCancel.Click += new System.EventHandler(this.btAddCancel_Click);
            // 
            // btAddItem
            // 
            this.btAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddItem.Location = new System.Drawing.Point(368, 9);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(80, 23);
            this.btAddItem.TabIndex = 2;
            this.btAddItem.Text = "Применить";
            this.btAddItem.UseVisualStyleBackColor = true;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(66, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(176, 20);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // lbWorks
            // 
            this.lbWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWorks.FormattingEnabled = true;
            this.lbWorks.Location = new System.Drawing.Point(12, 85);
            this.lbWorks.Name = "lbWorks";
            this.lbWorks.Size = new System.Drawing.Size(522, 355);
            this.lbWorks.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Цена";
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrice.Location = new System.Drawing.Point(287, 9);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(75, 20);
            this.tbPrice.TabIndex = 1;
            // 
            // FWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.lbWorks);
            this.Controls.Add(this.panelAddItem);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Name = "FWorks";
            this.Text = "Проводимые работы";
            this.panelAddItem.ResumeLayout(false);
            this.panelAddItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Panel panelAddItem;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbWorks;
        private System.Windows.Forms.Button btAddCancel;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label2;
    }
}