namespace iamsobad6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.iamsobadDataSet = new iamsobad6.iamsobadDataSet();
            this.getStudentByFIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getStudentByFIOTableAdapter = new iamsobad6.iamsobadDataSetTableAdapters.GetStudentByFIOTableAdapter();
            this.tableAdapterManager = new iamsobad6.iamsobadDataSetTableAdapters.TableAdapterManager();
            this.getStudentByFIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.getStudentByFIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.stNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.stNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.getStudentByFIODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getSubjectTableAdapter = new iamsobad6.iamsobadDataSetTableAdapters.GetSubjectTableAdapter();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.subNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.subNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.getSubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iamsobadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentByFIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentByFIOBindingNavigator)).BeginInit();
            this.getStudentByFIOBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentByFIODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSubjectBindingSource)).BeginInit();
            this.fillToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getSubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iamsobadDataSet
            // 
            this.iamsobadDataSet.DataSetName = "iamsobadDataSet";
            this.iamsobadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getStudentByFIOBindingSource
            // 
            this.getStudentByFIOBindingSource.DataMember = "GetStudentByFIO";
            this.getStudentByFIOBindingSource.DataSource = this.iamsobadDataSet;
            // 
            // getStudentByFIOTableAdapter
            // 
            this.getStudentByFIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MarkTableAdapter = null;
            this.tableAdapterManager.StudentListTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iamsobad6.iamsobadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // getStudentByFIOBindingNavigator
            // 
            this.getStudentByFIOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.getStudentByFIOBindingNavigator.BindingSource = this.getStudentByFIOBindingSource;
            this.getStudentByFIOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.getStudentByFIOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.getStudentByFIOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.getStudentByFIOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.getStudentByFIOBindingNavigatorSaveItem});
            this.getStudentByFIOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.getStudentByFIOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.getStudentByFIOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.getStudentByFIOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.getStudentByFIOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.getStudentByFIOBindingNavigator.Name = "getStudentByFIOBindingNavigator";
            this.getStudentByFIOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.getStudentByFIOBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.getStudentByFIOBindingNavigator.TabIndex = 0;
            this.getStudentByFIOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // getStudentByFIOBindingNavigatorSaveItem
            // 
            this.getStudentByFIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.getStudentByFIOBindingNavigatorSaveItem.Enabled = false;
            this.getStudentByFIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("getStudentByFIOBindingNavigatorSaveItem.Image")));
            this.getStudentByFIOBindingNavigatorSaveItem.Name = "getStudentByFIOBindingNavigatorSaveItem";
            this.getStudentByFIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.getStudentByFIOBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stNameToolStripLabel,
            this.stNameToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(800, 34);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // stNameToolStripLabel
            // 
            this.stNameToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stNameToolStripLabel.Name = "stNameToolStripLabel";
            this.stNameToolStripLabel.Size = new System.Drawing.Size(66, 31);
            this.stNameToolStripLabel.Text = "ФИО: ";
            // 
            // stNameToolStripTextBox
            // 
            this.stNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stNameToolStripTextBox.Name = "stNameToolStripTextBox";
            this.stNameToolStripTextBox.Size = new System.Drawing.Size(400, 34);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(56, 31);
            this.fillToolStripButton.Text = "Поиск";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // getStudentByFIODataGridView
            // 
            this.getStudentByFIODataGridView.AutoGenerateColumns = false;
            this.getStudentByFIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getStudentByFIODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.getStudentByFIODataGridView.DataSource = this.getStudentByFIOBindingSource;
            this.getStudentByFIODataGridView.Location = new System.Drawing.Point(0, 64);
            this.getStudentByFIODataGridView.Name = "getStudentByFIODataGridView";
            this.getStudentByFIODataGridView.RowHeadersWidth = 51;
            this.getStudentByFIODataGridView.RowTemplate.Height = 24;
            this.getStudentByFIODataGridView.Size = new System.Drawing.Size(800, 164);
            this.getStudentByFIODataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_student";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_student";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "FIO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_grupp";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_grupp";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // getSubjectBindingSource
            // 
            this.getSubjectBindingSource.DataMember = "GetSubject";
            this.getSubjectBindingSource.DataSource = this.iamsobadDataSet;
            // 
            // getSubjectTableAdapter
            // 
            this.getSubjectTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip1
            // 
            this.fillToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subNameToolStripLabel,
            this.subNameToolStripTextBox,
            this.fillToolStripButton1});
            this.fillToolStrip1.Location = new System.Drawing.Point(0, 231);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(572, 34);
            this.fillToolStrip1.TabIndex = 3;
            this.fillToolStrip1.Text = "fillToolStrip1";
            // 
            // subNameToolStripLabel
            // 
            this.subNameToolStripLabel.Name = "subNameToolStripLabel";
            this.subNameToolStripLabel.Size = new System.Drawing.Size(151, 31);
            this.subNameToolStripLabel.Text = "Название предмета:";
            // 
            // subNameToolStripTextBox
            // 
            this.subNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.subNameToolStripTextBox.Name = "subNameToolStripTextBox";
            this.subNameToolStripTextBox.Size = new System.Drawing.Size(350, 34);
            // 
            // fillToolStripButton1
            // 
            this.fillToolStripButton1.BackColor = System.Drawing.Color.MistyRose;
            this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton1.Name = "fillToolStripButton1";
            this.fillToolStripButton1.Size = new System.Drawing.Size(56, 31);
            this.fillToolStripButton1.Text = "Поиск";
            this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click);
            // 
            // getSubjectDataGridView
            // 
            this.getSubjectDataGridView.AutoGenerateColumns = false;
            this.getSubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getSubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.getSubjectDataGridView.DataSource = this.getSubjectBindingSource;
            this.getSubjectDataGridView.Location = new System.Drawing.Point(0, 268);
            this.getSubjectDataGridView.Name = "getSubjectDataGridView";
            this.getSubjectDataGridView.RowHeadersWidth = 51;
            this.getSubjectDataGridView.RowTemplate.Height = 24;
            this.getSubjectDataGridView.Size = new System.Drawing.Size(800, 220);
            this.getSubjectDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_subject";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_subject";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "name_subject";
            this.dataGridViewTextBoxColumn5.HeaderText = "name_subject";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.getSubjectDataGridView);
            this.Controls.Add(this.fillToolStrip1);
            this.Controls.Add(this.getStudentByFIODataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.getStudentByFIOBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.iamsobadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentByFIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentByFIOBindingNavigator)).EndInit();
            this.getStudentByFIOBindingNavigator.ResumeLayout(false);
            this.getStudentByFIOBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentByFIODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSubjectBindingSource)).EndInit();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getSubjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iamsobadDataSet iamsobadDataSet;
        private System.Windows.Forms.BindingSource getStudentByFIOBindingSource;
        private iamsobadDataSetTableAdapters.GetStudentByFIOTableAdapter getStudentByFIOTableAdapter;
        private iamsobadDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator getStudentByFIOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton getStudentByFIOBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel stNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox stNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView getStudentByFIODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource getSubjectBindingSource;
        private iamsobadDataSetTableAdapters.GetSubjectTableAdapter getSubjectTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel subNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox subNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton1;
        private System.Windows.Forms.DataGridView getSubjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

