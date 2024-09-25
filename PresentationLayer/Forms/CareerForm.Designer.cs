namespace PresentationLayer.Forms
{
    partial class CareerForm
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
            label1 = new Label();
            label2 = new Label();
            txtNameCareer = new TextBox();
            txtDescriptionCareer = new TextBox();
            brnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label3 = new Label();
            dgvCareers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCareers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 80);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 0;
            label1.Text = "Name of the career";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 197);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // txtNameCareer
            // 
            txtNameCareer.Location = new Point(30, 137);
            txtNameCareer.Name = "txtNameCareer";
            txtNameCareer.Size = new Size(393, 27);
            txtNameCareer.TabIndex = 2;
            // 
            // txtDescriptionCareer
            // 
            txtDescriptionCareer.Location = new Point(30, 260);
            txtDescriptionCareer.Multiline = true;
            txtDescriptionCareer.Name = "txtDescriptionCareer";
            txtDescriptionCareer.Size = new Size(393, 170);
            txtDescriptionCareer.TabIndex = 3;
            // 
            // brnSave
            // 
            brnSave.Location = new Point(37, 473);
            brnSave.Name = "brnSave";
            brnSave.Size = new Size(94, 29);
            brnSave.TabIndex = 4;
            brnSave.Text = "Save";
            brnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(193, 473);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(329, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 22);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 7;
            label3.Text = "Administration of Careers";
            // 
            // dgvCareers
            // 
            dgvCareers.AllowUserToAddRows = false;
            dgvCareers.AllowUserToDeleteRows = false;
            dgvCareers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCareers.Location = new Point(487, 137);
            dgvCareers.Name = "dgvCareers";
            dgvCareers.ReadOnly = true;
            dgvCareers.RowHeadersWidth = 51;
            dgvCareers.Size = new Size(394, 365);
            dgvCareers.TabIndex = 8;
            // 
            // CareerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 583);
            Controls.Add(dgvCareers);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(brnSave);
            Controls.Add(txtDescriptionCareer);
            Controls.Add(txtNameCareer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CareerForm";
            Text = "CareerForm";
            ((System.ComponentModel.ISupportInitialize)dgvCareers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNameCareer;
        private TextBox txtDescriptionCareer;
        private Button brnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Label label3;
        private DataGridView dgvCareers;
    }
}