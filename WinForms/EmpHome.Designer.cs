
namespace WinForms
{
    partial class EmpHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpHome));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.btnViewSup = new System.Windows.Forms.Button();
            this.btnViewCar = new System.Windows.Forms.Button();
            this.lbUID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(892, 13);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(257, 57);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.FlatAppearance.BorderSize = 0;
            this.btnManageCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnManageCustomer.Image")));
            this.btnManageCustomer.Location = new System.Drawing.Point(32, 434);
            this.btnManageCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(394, 335);
            this.btnManageCustomer.TabIndex = 12;
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.FlatAppearance.BorderSize = 0;
            this.btnManageOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnManageOrder.Image")));
            this.btnManageOrder.Location = new System.Drawing.Point(456, 78);
            this.btnManageOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(394, 335);
            this.btnManageOrder.TabIndex = 11;
            this.btnManageOrder.UseVisualStyleBackColor = true;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnViewSup
            // 
            this.btnViewSup.FlatAppearance.BorderSize = 0;
            this.btnViewSup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewSup.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSup.Image")));
            this.btnViewSup.Location = new System.Drawing.Point(456, 432);
            this.btnViewSup.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewSup.Name = "btnViewSup";
            this.btnViewSup.Size = new System.Drawing.Size(394, 335);
            this.btnViewSup.TabIndex = 10;
            this.btnViewSup.UseVisualStyleBackColor = true;
            this.btnViewSup.Click += new System.EventHandler(this.btnViewSup_Click);
            // 
            // btnViewCar
            // 
            this.btnViewCar.FlatAppearance.BorderSize = 0;
            this.btnViewCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewCar.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCar.Image")));
            this.btnViewCar.Location = new System.Drawing.Point(32, 78);
            this.btnViewCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewCar.Name = "btnViewCar";
            this.btnViewCar.Size = new System.Drawing.Size(394, 335);
            this.btnViewCar.TabIndex = 8;
            this.btnViewCar.UseVisualStyleBackColor = true;
            this.btnViewCar.Click += new System.EventHandler(this.btnViewCar_Click);
            // 
            // lbUID
            // 
            this.lbUID.AutoSize = true;
            this.lbUID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.lbUID.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.lbUID.Location = new System.Drawing.Point(29, 13);
            this.lbUID.Name = "lbUID";
            this.lbUID.Size = new System.Drawing.Size(0, 45);
            this.lbUID.TabIndex = 14;
            // 
            // EmpHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1154, 782);
            this.Controls.Add(this.lbUID);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageCustomer);
            this.Controls.Add(this.btnManageOrder);
            this.Controls.Add(this.btnViewSup);
            this.Controls.Add(this.btnViewCar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmpHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chain Hang Low - Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpHome_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Button btnManageOrder;
        private System.Windows.Forms.Button btnViewSup;
        private System.Windows.Forms.Button btnViewCar;
        private System.Windows.Forms.Label lbUID;
    }
}