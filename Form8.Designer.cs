namespace WindowsFormsApp1
{
    partial class Form8
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
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оборудованиеTableAdapter = new WindowsFormsApp1.workshopDataSetTableAdapters.ОборудованиеTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.workshopDataSetTableAdapters.TableAdapterManager();
            this.оборудованиеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workshopDataSet
            // 
            this.workshopDataSet.DataSetName = "workshopDataSet";
            this.workshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.workshopDataSet;
            // 
            // оборудованиеTableAdapter
            // 
            this.оборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.RepairTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.workshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksopTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = this.оборудованиеTableAdapter;
            this.tableAdapterManager.РемонтTableAdapter = null;
            this.tableAdapterManager.ЦехTableAdapter = null;
            // 
            // оборудованиеDataGridView
            // 
            this.оборудованиеDataGridView.AutoGenerateColumns = false;
            this.оборудованиеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.оборудованиеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.оборудованиеDataGridView.DataSource = this.оборудованиеBindingSource;
            this.оборудованиеDataGridView.Location = new System.Drawing.Point(189, 46);
            this.оборудованиеDataGridView.Name = "оборудованиеDataGridView";
            this.оборудованиеDataGridView.Size = new System.Drawing.Size(442, 250);
            this.оборудованиеDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_цеха";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_цеха";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_оборудования";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_оборудования";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Состояние";
            this.dataGridViewTextBoxColumn3.HeaderText = "Состояние";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.оборудованиеDataGridView);
            this.Name = "Form8";
            this.Text = "Оборудование.Работник";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private workshopDataSet workshopDataSet;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        private workshopDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private workshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView оборудованиеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}