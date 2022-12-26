namespace WindowsFormsApp1
{
    partial class Form7
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.workshopDataSet = new WindowsFormsApp1.workshopDataSet();
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ремонтTableAdapter = new WindowsFormsApp1.workshopDataSetTableAdapters.РемонтTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.workshopDataSetTableAdapters.TableAdapterManager();
            this.цехTableAdapter = new WindowsFormsApp1.workshopDataSetTableAdapters.ЦехTableAdapter();
            this.цехBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.цехDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
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
            this.tableAdapterManager.ЦехTableAdapter = this.цехTableAdapter;
            // 
            // цехTableAdapter
            // 
            this.цехTableAdapter.ClearBeforeFill = true;
            // 
            // цехBindingSource
            // 
            this.цехBindingSource.DataMember = "Цех";
            this.цехBindingSource.DataSource = this.workshopDataSet;
            // 
            // цехDataGridView
            // 
            this.цехDataGridView.AutoGenerateColumns = false;
            this.цехDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.цехDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.цехDataGridView.DataSource = this.цехBindingSource;
            this.цехDataGridView.Location = new System.Drawing.Point(241, 45);
            this.цехDataGridView.Name = "цехDataGridView";
            this.цехDataGridView.Size = new System.Drawing.Size(339, 271);
            this.цехDataGridView.TabIndex = 2;
            this.цехDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.цехDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_цеха";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_цеха";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Количество рабочих";
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество рабочих";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество оборудования";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество оборудования";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.цехDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form7";
            this.Text = "Цех.Работник";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private workshopDataSet workshopDataSet;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private workshopDataSetTableAdapters.РемонтTableAdapter ремонтTableAdapter;
        private workshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private workshopDataSetTableAdapters.ЦехTableAdapter цехTableAdapter;
        private System.Windows.Forms.BindingSource цехBindingSource;
        private System.Windows.Forms.DataGridView цехDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}