namespace Lab_Inventory_Monitoring_System
{
    partial class modifyProduct
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
            this.lblNote = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.PictureBox();
            this.btnSubmitRec = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmitRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 9);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(214, 17);
            this.lblNote.TabIndex = 17;
            this.lblNote.Text = "Note: Fields with * are necessery";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(14, 76);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 17);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID*";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(180, 73);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(223, 22);
            this.tbID.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(180, 132);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(223, 22);
            this.tbName.TabIndex = 20;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(180, 189);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(223, 22);
            this.tbDesc.TabIndex = 21;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 132);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(14, 192);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 17);
            this.lblDesc.TabIndex = 23;
            this.lblDesc.Text = "Description";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Image = global::Lab_Inventory_Monitoring_System.Properties.Resources.cancel_button;
            this.btnCloseForm.Location = new System.Drawing.Point(448, 324);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(100, 50);
            this.btnCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseForm.TabIndex = 29;
            this.btnCloseForm.TabStop = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click_1);
            // 
            // btnSubmitRec
            // 
            this.btnSubmitRec.Image = global::Lab_Inventory_Monitoring_System.Properties.Resources.update_button_blue;
            this.btnSubmitRec.Location = new System.Drawing.Point(292, 324);
            this.btnSubmitRec.Name = "btnSubmitRec";
            this.btnSubmitRec.Size = new System.Drawing.Size(100, 50);
            this.btnSubmitRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSubmitRec.TabIndex = 28;
            this.btnSubmitRec.TabStop = false;
            this.btnSubmitRec.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Lab_Inventory_Monitoring_System.Properties.Resources.delete_button;
            this.btnDelete.Location = new System.Drawing.Point(150, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 27;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Lab_Inventory_Monitoring_System.Properties.Resources.cancel_button;
            this.btnCancel.Location = new System.Drawing.Point(263, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 26;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::Lab_Inventory_Monitoring_System.Properties.Resources.Submit_Button;
            this.btnSubmit.Location = new System.Drawing.Point(74, 159);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit1_Click);
            // 
            // modifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 404);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnSubmitRec);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modifyProduct";
            this.Text = "Modify Product";
            this.Load += new System.EventHandler(this.modifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmitRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox btnSubmit;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnSubmitRec;
        private System.Windows.Forms.PictureBox btnCloseForm;
    }
}