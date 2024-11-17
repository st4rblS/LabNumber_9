namespace wfPr20_Var06
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDписьмоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОтправкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресОтправителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусОтправкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.recipientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.n_letterDBDataSet = new wfPr20_Var06.N_letterDBDataSet();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.senderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave1 = new System.Windows.Forms.Button();
            this.letterTableAdapter = new wfPr20_Var06.N_letterDBDataSetTableAdapters.LetterTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDотправительDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave3 = new System.Windows.Forms.Button();
            this.recipientTableAdapter = new wfPr20_Var06.N_letterDBDataSetTableAdapters.RecipientTableAdapter();
            this.senderTableAdapter = new wfPr20_Var06.N_letterDBDataSetTableAdapters.SenderTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.Recipient_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipient_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipient_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipient_Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipient_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_letterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Письма";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDписьмоDataGridViewTextBoxColumn,
            this.датаОтправкиDataGridViewTextBoxColumn,
            this.адресОтправителяDataGridViewTextBoxColumn,
            this.адресПолучателяDataGridViewTextBoxColumn,
            this.статусОтправкиDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.letterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDписьмоDataGridViewTextBoxColumn
            // 
            this.iDписьмоDataGridViewTextBoxColumn.DataPropertyName = "ID_письмо";
            this.iDписьмоDataGridViewTextBoxColumn.Frozen = true;
            this.iDписьмоDataGridViewTextBoxColumn.HeaderText = "Код письма";
            this.iDписьмоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDписьмоDataGridViewTextBoxColumn.Name = "iDписьмоDataGridViewTextBoxColumn";
            this.iDписьмоDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаОтправкиDataGridViewTextBoxColumn
            // 
            this.датаОтправкиDataGridViewTextBoxColumn.DataPropertyName = "Дата отправки";
            this.датаОтправкиDataGridViewTextBoxColumn.Frozen = true;
            this.датаОтправкиDataGridViewTextBoxColumn.HeaderText = "Дата отправки";
            this.датаОтправкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаОтправкиDataGridViewTextBoxColumn.Name = "датаОтправкиDataGridViewTextBoxColumn";
            this.датаОтправкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресОтправителяDataGridViewTextBoxColumn
            // 
            this.адресОтправителяDataGridViewTextBoxColumn.DataPropertyName = "Адрес отправителя";
            this.адресОтправителяDataGridViewTextBoxColumn.Frozen = true;
            this.адресОтправителяDataGridViewTextBoxColumn.HeaderText = "Адрес отправителя";
            this.адресОтправителяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресОтправителяDataGridViewTextBoxColumn.Name = "адресОтправителяDataGridViewTextBoxColumn";
            this.адресОтправителяDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресПолучателяDataGridViewTextBoxColumn
            // 
            this.адресПолучателяDataGridViewTextBoxColumn.DataPropertyName = "Адрес получателя";
            this.адресПолучателяDataGridViewTextBoxColumn.Frozen = true;
            this.адресПолучателяDataGridViewTextBoxColumn.HeaderText = "Адрес получателя";
            this.адресПолучателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресПолучателяDataGridViewTextBoxColumn.Name = "адресПолучателяDataGridViewTextBoxColumn";
            this.адресПолучателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // статусОтправкиDataGridViewTextBoxColumn
            // 
            this.статусОтправкиDataGridViewTextBoxColumn.DataPropertyName = "Статус отправки";
            this.статусОтправкиDataGridViewTextBoxColumn.Frozen = true;
            this.статусОтправкиDataGridViewTextBoxColumn.HeaderText = "Статус отправки";
            this.статусОтправкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусОтправкиDataGridViewTextBoxColumn.Name = "статусОтправкиDataGridViewTextBoxColumn";
            this.статусОтправкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_получатель";
            this.Column1.DataSource = this.recipientBindingSource;
            this.Column1.DisplayMember = "Фамилия";
            this.Column1.HeaderText = "Список получателей";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "ID_получатель";
            this.Column1.Width = 125;
            // 
            // recipientBindingSource
            // 
            this.recipientBindingSource.DataMember = "Recipient";
            this.recipientBindingSource.DataSource = this.n_letterDBDataSet;
            // 
            // n_letterDBDataSet
            // 
            this.n_letterDBDataSet.DataSetName = "N_letterDBDataSet";
            this.n_letterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID_отправитель";
            this.Column2.DataSource = this.senderBindingSource;
            this.Column2.DisplayMember = "Фамилия";
            this.Column2.HeaderText = "Список отправителей";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ValueMember = "ID_отправитель";
            this.Column2.Width = 125;
            // 
            // senderBindingSource
            // 
            this.senderBindingSource.DataMember = "Sender";
            this.senderBindingSource.DataSource = this.n_letterDBDataSet;
            // 
            // letterBindingSource
            // 
            this.letterBindingSource.DataMember = "Letter";
            this.letterBindingSource.DataSource = this.n_letterDBDataSet;
            // 
            // btnSave1
            // 
            this.btnSave1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave1.Location = new System.Drawing.Point(1154, 198);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(110, 28);
            this.btnSave1.TabIndex = 2;
            this.btnSave1.Text = "Сохранить";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // letterTableAdapter
            // 
            this.letterTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Recipient_Code,
            this.Recipient_Surname,
            this.Recipient_Name,
            this.Recipient_Lastname,
            this.адресДоставкиDataGridViewTextBoxColumn,
            this.Recipient_PhoneNumber,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.recipientBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(26, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1238, 163);
            this.dataGridView2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Получатели";
            // 
            // btnSave2
            // 
            this.btnSave2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave2.Location = new System.Drawing.Point(1154, 434);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(110, 28);
            this.btnSave2.TabIndex = 5;
            this.btnSave2.Text = "Сохранить";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDотправительDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn1,
            this.отчествоDataGridViewTextBoxColumn1,
            this.номерТелефонаDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.senderBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(26, 485);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1238, 169);
            this.dataGridView3.TabIndex = 6;
            // 
            // iDотправительDataGridViewTextBoxColumn1
            // 
            this.iDотправительDataGridViewTextBoxColumn1.DataPropertyName = "ID_отправитель";
            this.iDотправительDataGridViewTextBoxColumn1.HeaderText = "Код отправителя";
            this.iDотправительDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDотправительDataGridViewTextBoxColumn1.Name = "iDотправительDataGridViewTextBoxColumn1";
            this.iDотправительDataGridViewTextBoxColumn1.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            this.фамилияDataGridViewTextBoxColumn1.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            this.имяDataGridViewTextBoxColumn1.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn1
            // 
            this.отчествоDataGridViewTextBoxColumn1.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn1.Name = "отчествоDataGridViewTextBoxColumn1";
            this.отчествоDataGridViewTextBoxColumn1.Width = 125;
            // 
            // номерТелефонаDataGridViewTextBoxColumn1
            // 
            this.номерТелефонаDataGridViewTextBoxColumn1.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn1.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.номерТелефонаDataGridViewTextBoxColumn1.Name = "номерТелефонаDataGridViewTextBoxColumn1";
            this.номерТелефонаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Электронная почта";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 125;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отправители";
            // 
            // btnSave3
            // 
            this.btnSave3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave3.Location = new System.Drawing.Point(1154, 660);
            this.btnSave3.Name = "btnSave3";
            this.btnSave3.Size = new System.Drawing.Size(110, 28);
            this.btnSave3.TabIndex = 8;
            this.btnSave3.Text = "Сохранить";
            this.btnSave3.UseVisualStyleBackColor = true;
            this.btnSave3.Click += new System.EventHandler(this.btnSave3_Click);
            // 
            // recipientTableAdapter
            // 
            this.recipientTableAdapter.ClearBeforeFill = true;
            // 
            // senderTableAdapter
            // 
            this.senderTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1003, 199);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 27);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(26, 715);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 26);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWord
            // 
            this.btnWord.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnWord.Location = new System.Drawing.Point(959, 434);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(152, 28);
            this.btnWord.TabIndex = 11;
            this.btnWord.Text = "Экспорт в Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(811, 198);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(144, 28);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.Text = "Экспорт в Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Recipient_Code
            // 
            this.Recipient_Code.DataPropertyName = "ID_получатель";
            this.Recipient_Code.HeaderText = "Код получателя";
            this.Recipient_Code.MinimumWidth = 6;
            this.Recipient_Code.Name = "Recipient_Code";
            this.Recipient_Code.Width = 125;
            // 
            // Recipient_Surname
            // 
            this.Recipient_Surname.DataPropertyName = "Фамилия";
            this.Recipient_Surname.HeaderText = "Фамилия";
            this.Recipient_Surname.MinimumWidth = 6;
            this.Recipient_Surname.Name = "Recipient_Surname";
            this.Recipient_Surname.Width = 125;
            // 
            // Recipient_Name
            // 
            this.Recipient_Name.DataPropertyName = "Имя";
            this.Recipient_Name.HeaderText = "Имя";
            this.Recipient_Name.MinimumWidth = 6;
            this.Recipient_Name.Name = "Recipient_Name";
            this.Recipient_Name.Width = 125;
            // 
            // Recipient_Lastname
            // 
            this.Recipient_Lastname.DataPropertyName = "Отчество";
            this.Recipient_Lastname.HeaderText = "Отчество";
            this.Recipient_Lastname.MinimumWidth = 6;
            this.Recipient_Lastname.Name = "Recipient_Lastname";
            this.Recipient_Lastname.Width = 125;
            // 
            // адресДоставкиDataGridViewTextBoxColumn
            // 
            this.адресДоставкиDataGridViewTextBoxColumn.DataPropertyName = "Адрес доставки";
            this.адресДоставкиDataGridViewTextBoxColumn.HeaderText = "Адрес доставки";
            this.адресДоставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресДоставкиDataGridViewTextBoxColumn.Name = "адресДоставкиDataGridViewTextBoxColumn";
            this.адресДоставкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // Recipient_PhoneNumber
            // 
            this.Recipient_PhoneNumber.DataPropertyName = "Номер телефона";
            this.Recipient_PhoneNumber.HeaderText = "Номер телефона";
            this.Recipient_PhoneNumber.MinimumWidth = 6;
            this.Recipient_PhoneNumber.Name = "Recipient_PhoneNumber";
            this.Recipient_PhoneNumber.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Электронная почта";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1380, 800);
            this.Name = "Form3";
            this.Text = "Работа с БД";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_letterDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave1;
        private N_letterDBDataSet n_letterDBDataSet;
        private System.Windows.Forms.BindingSource letterBindingSource;
        private N_letterDBDataSetTableAdapters.LetterTableAdapter letterTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave3;
        private System.Windows.Forms.BindingSource recipientBindingSource;
        private N_letterDBDataSetTableAdapters.RecipientTableAdapter recipientTableAdapter;
        private System.Windows.Forms.BindingSource senderBindingSource;
        private N_letterDBDataSetTableAdapters.SenderTableAdapter senderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDотправительDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDписьмоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОтправкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресОтправителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусОтправкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipient_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipient_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipient_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipient_Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipient_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}