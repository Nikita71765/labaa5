namespace WindowsFormsApp1
{
    partial class Form9
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
            this.components = new System.ComponentModel.Container();
            this.workshopDataSet = new WindowsFormsApp1.workshopDataSet();
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ремонтTableAdapter = new WindowsFormsApp1.workshopDataSetTableAdapters.РемонтTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.workshopDataSetTableAdapters.TableAdapterManager();
            this.ремонтDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workshopDataSet
            // 
            this.workshopDataSet.DataSetName = "workshopDataSet";
            this.workshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataMember = "Ремонт";
            this.ремонтBindingSource.DataSource = this.workshopDataSet;
            // 
            // ремонтTableAdapter
            // 
            this.ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.RepairTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.workshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksopTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = null;
            this.tableAdapterManager.РемонтTableAdapter = this.ремонтTableAdapter;
            this.tableAdapterManager.ЦехTableAdapter = null;
            // 
            // ремонтDataGridView
            // 
            this.ремонтDataGridView.AutoGenerateColumns = false;
            this.ремонтDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ремонтDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ремонтDataGridView.DataSource = this.ремонтBindingSource;
            this.ремонтDataGridView.Location = new System.Drawing.Point(190, 68);
            this.ремонтDataGridView.Name = "ремонтDataGridView";
            this.ремонтDataGridView.Size = new System.Drawing.Size(444, 220);
            this.ремонтDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_оборудования";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_оборудования";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Плановый";
            this.dataGridViewTextBoxColumn2.HeaderText = "Плановый";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Аварийный";
            this.dataGridViewTextBoxColumn3.HeaderText = "Аварийный";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Капитальный";
            this.dataGridViewTextBoxColumn4.HeaderText = "Капитальный";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ремонтDataGridView);
            this.Name = "Form9";
            this.Text = "Ремонт.Работник";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private workshopDataSet workshopDataSet;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private workshopDataSetTableAdapters.РемонтTableAdapter ремонтTableAdapter;
        private workshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ремонтDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}