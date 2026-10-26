namespace NetFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button btnEditEquipment;
        private Button btnAddEquipment;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnEditEquipment = new Button();
            btnAddEquipment = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // dataGridView1
            //
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(787, 348);
            dataGridView1.TabIndex = 0;
            //
            // btnEditEquipment
            //
            btnEditEquipment.Location = new Point(80, 357);
            btnEditEquipment.Name = "btnEditEquipment";
            btnEditEquipment.Size = new Size(75, 23);
            btnEditEquipment.TabIndex = 1;
            btnEditEquipment.Text = "Изменить";
            btnEditEquipment.UseVisualStyleBackColor = true;
            btnEditEquipment.Click += btnEditEquipment_Click;
            //
            // btnAddEquipment
            //
            btnAddEquipment.Location = new Point(3, 357);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(75, 23);
            btnAddEquipment.TabIndex = 2;
            btnAddEquipment.Text = "Добавить";
            btnAddEquipment.UseVisualStyleBackColor = true;
            btnAddEquipment.Click += btnAddEquipment_Click;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddEquipment);
            Controls.Add(btnEditEquipment);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
