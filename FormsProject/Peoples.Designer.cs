namespace FormsProject
{
    partial class Peoples
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
            components = new System.ComponentModel.Container();
            InputNumPersone = new TextBox();
            InputNum = new TextBox();
            InputNumFile = new TextBox();
            InputFile = new TextBox();
            InputLastName = new TextBox();
            InputFirstName = new TextBox();
            InputMomName = new TextBox();
            InputDadName = new TextBox();
            InputNumLocRecord = new TextBox();
            InputCountry = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Input1 = new ComboBox();
            Input2 = new ComboBox();
            UnputProsecutor = new ComboBox();
            InputPlaceBirth = new TextBox();
            InputPlaceResidence = new TextBox();
            InputDateOfBirth = new TextBox();
            InputSurname = new TextBox();
            InputProfession = new TextBox();
            textBox10 = new TextBox();
            InputPhoneNumber = new TextBox();
            InputMaritalStatus = new ComboBox();
            InputSex = new ComboBox();
            dataGridView1 = new DataGridView();
            BtInput = new Button();
            BtDelete = new Button();
            BtUpdate = new Button();
            BtCancel = new Button();
            CheckPlaceResidence = new CheckBox();
            CheckNum = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // InputNumPersone
            // 
            InputNumPersone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InputNumPersone.Location = new Point(-1, 12);
            InputNumPersone.Name = "InputNumPersone";
            InputNumPersone.Size = new Size(194, 31);
            InputNumPersone.TabIndex = 0;
            InputNumPersone.Text = "الرقم المتسلسل للشخص";
            // 
            // InputNum
            // 
            InputNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InputNum.Location = new Point(199, 1);
            InputNum.Name = "InputNum";
            InputNum.Size = new Size(42, 31);
            InputNum.TabIndex = 1;
            InputNum.Text = "0";
            // 
            // InputNumFile
            // 
            InputNumFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InputNumFile.Location = new Point(247, 12);
            InputNumFile.Name = "InputNumFile";
            InputNumFile.Size = new Size(180, 31);
            InputNumFile.TabIndex = 2;
            InputNumFile.Text = "الرقم المتسلسل للملف";
            // 
            // InputFile
            // 
            InputFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InputFile.Location = new Point(433, 1);
            InputFile.Name = "InputFile";
            InputFile.Size = new Size(42, 31);
            InputFile.TabIndex = 3;
            InputFile.Text = "1";
            // 
            // InputLastName
            // 
            InputLastName.Location = new Point(-1, 50);
            InputLastName.Name = "InputLastName";
            InputLastName.Size = new Size(223, 31);
            InputLastName.TabIndex = 4;
            InputLastName.Text = "[الشهرة]";
            InputLastName.TextAlign = HorizontalAlignment.Right;
            // 
            // InputFirstName
            // 
            InputFirstName.Location = new Point(252, 50);
            InputFirstName.Name = "InputFirstName";
            InputFirstName.Size = new Size(223, 31);
            InputFirstName.TabIndex = 5;
            InputFirstName.Text = "[الإسم]";
            InputFirstName.TextAlign = HorizontalAlignment.Right;
            // 
            // InputMomName
            // 
            InputMomName.Location = new Point(1, 96);
            InputMomName.Name = "InputMomName";
            InputMomName.Size = new Size(223, 31);
            InputMomName.TabIndex = 6;
            InputMomName.Text = "[اسم الأم]";
            InputMomName.TextAlign = HorizontalAlignment.Right;
            // 
            // InputDadName
            // 
            InputDadName.Location = new Point(252, 96);
            InputDadName.Name = "InputDadName";
            InputDadName.Size = new Size(223, 31);
            InputDadName.TabIndex = 7;
            InputDadName.Text = "[اسم الأب]";
            InputDadName.TextAlign = HorizontalAlignment.Right;
            // 
            // InputNumLocRecord
            // 
            InputNumLocRecord.Location = new Point(-1, 145);
            InputNumLocRecord.Name = "InputNumLocRecord";
            InputNumLocRecord.Size = new Size(476, 31);
            InputNumLocRecord.TabIndex = 8;
            // 
            // InputCountry
            // 
            InputCountry.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InputCountry.FormattingEnabled = true;
            InputCountry.Location = new Point(-1, 195);
            InputCountry.Name = "InputCountry";
            InputCountry.RightToLeft = RightToLeft.Yes;
            InputCountry.Size = new Size(297, 33);
            InputCountry.TabIndex = 9;
            InputCountry.Text = "لبنان";
            InputCountry.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Input1
            // 
            Input1.FormattingEnabled = true;
            Input1.Location = new Point(1, 246);
            Input1.Name = "Input1";
            Input1.RightToLeft = RightToLeft.Yes;
            Input1.Size = new Size(295, 33);
            Input1.TabIndex = 11;
            // 
            // Input2
            // 
            Input2.FormattingEnabled = true;
            Input2.Location = new Point(-1, 302);
            Input2.Name = "Input2";
            Input2.RightToLeft = RightToLeft.Yes;
            Input2.Size = new Size(297, 33);
            Input2.TabIndex = 12;
            // 
            // UnputProsecutor
            // 
            UnputProsecutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UnputProsecutor.FormattingEnabled = true;
            UnputProsecutor.Location = new Point(-1, 355);
            UnputProsecutor.Name = "UnputProsecutor";
            UnputProsecutor.RightToLeft = RightToLeft.Yes;
            UnputProsecutor.Size = new Size(297, 33);
            UnputProsecutor.TabIndex = 13;
            UnputProsecutor.Text = "مدعي";
            // 
            // InputPlaceBirth
            // 
            InputPlaceBirth.Location = new Point(325, 246);
            InputPlaceBirth.Name = "InputPlaceBirth";
            InputPlaceBirth.Size = new Size(150, 31);
            InputPlaceBirth.TabIndex = 14;
            InputPlaceBirth.Text = "[محل الولادة]";
            InputPlaceBirth.TextAlign = HorizontalAlignment.Right;
            // 
            // InputPlaceResidence
            // 
            InputPlaceResidence.Location = new Point(325, 302);
            InputPlaceResidence.Name = "InputPlaceResidence";
            InputPlaceResidence.Size = new Size(150, 31);
            InputPlaceResidence.TabIndex = 15;
            InputPlaceResidence.Text = "[محل الإقامة]";
            InputPlaceResidence.TextAlign = HorizontalAlignment.Right;
            // 
            // InputDateOfBirth
            // 
            InputDateOfBirth.Location = new Point(325, 407);
            InputDateOfBirth.Name = "InputDateOfBirth";
            InputDateOfBirth.Size = new Size(150, 31);
            InputDateOfBirth.TabIndex = 16;
            InputDateOfBirth.Text = "[تاريخ الإقامة]";
            InputDateOfBirth.TextAlign = HorizontalAlignment.Right;
            // 
            // InputSurname
            // 
            InputSurname.Location = new Point(1, 507);
            InputSurname.Name = "InputSurname";
            InputSurname.Size = new Size(150, 31);
            InputSurname.TabIndex = 19;
            InputSurname.Text = "[اللقب]";
            InputSurname.TextAlign = HorizontalAlignment.Right;
            // 
            // InputProfession
            // 
            InputProfession.Location = new Point(-1, 561);
            InputProfession.Name = "InputProfession";
            InputProfession.Size = new Size(150, 31);
            InputProfession.TabIndex = 21;
            InputProfession.Text = "[المهنة]";
            InputProfession.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(325, 561);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(150, 31);
            textBox10.TabIndex = 22;
            // 
            // InputPhoneNumber
            // 
            InputPhoneNumber.ForeColor = Color.Red;
            InputPhoneNumber.Location = new Point(1, 612);
            InputPhoneNumber.Name = "InputPhoneNumber";
            InputPhoneNumber.Size = new Size(150, 31);
            InputPhoneNumber.TabIndex = 23;
            InputPhoneNumber.Text = "+__-__-__-__";
            // 
            // InputMaritalStatus
            // 
            InputMaritalStatus.FormattingEnabled = true;
            InputMaritalStatus.Location = new Point(168, 612);
            InputMaritalStatus.Name = "InputMaritalStatus";
            InputMaritalStatus.RightToLeft = RightToLeft.Yes;
            InputMaritalStatus.Size = new Size(259, 33);
            InputMaritalStatus.TabIndex = 24;
            InputMaritalStatus.Text = "الحالة الإجتماعية";
            // 
            // InputSex
            // 
            InputSex.FormattingEnabled = true;
            InputSex.Location = new Point(450, 610);
            InputSex.Name = "InputSex";
            InputSex.RightToLeft = RightToLeft.Yes;
            InputSex.Size = new Size(156, 33);
            InputSex.TabIndex = 25;
            InputSex.Text = "الجنس";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(512, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(891, 603);
            dataGridView1.TabIndex = 26;
            // 
            // BtInput
            // 
            BtInput.BackColor = Color.FromArgb(255, 128, 0);
            BtInput.Location = new Point(1291, 686);
            BtInput.Name = "BtInput";
            BtInput.RightToLeft = RightToLeft.Yes;
            BtInput.Size = new Size(112, 51);
            BtInput.TabIndex = 27;
            BtInput.Text = "إدخال";
            BtInput.UseVisualStyleBackColor = false;
            // 
            // BtDelete
            // 
            BtDelete.BackColor = Color.FromArgb(255, 128, 0);
            BtDelete.Location = new Point(1151, 686);
            BtDelete.Name = "BtDelete";
            BtDelete.Size = new Size(112, 51);
            BtDelete.TabIndex = 28;
            BtDelete.Text = "حذف";
            BtDelete.UseVisualStyleBackColor = false;
            // 
            // BtUpdate
            // 
            BtUpdate.BackColor = Color.FromArgb(255, 128, 0);
            BtUpdate.Location = new Point(995, 686);
            BtUpdate.Name = "BtUpdate";
            BtUpdate.Size = new Size(112, 51);
            BtUpdate.TabIndex = 29;
            BtUpdate.Text = "تعديل";
            BtUpdate.UseVisualStyleBackColor = false;
            // 
            // BtCancel
            // 
            BtCancel.BackColor = Color.FromArgb(255, 128, 0);
            BtCancel.Location = new Point(839, 686);
            BtCancel.Name = "BtCancel";
            BtCancel.Size = new Size(112, 51);
            BtCancel.TabIndex = 30;
            BtCancel.Text = "إلغاء";
            BtCancel.UseVisualStyleBackColor = false;
            // 
            // CheckPlaceResidence
            // 
            CheckPlaceResidence.AutoSize = true;
            CheckPlaceResidence.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CheckPlaceResidence.Location = new Point(292, 460);
            CheckPlaceResidence.Name = "CheckPlaceResidence";
            CheckPlaceResidence.RightToLeft = RightToLeft.Yes;
            CheckPlaceResidence.Size = new Size(191, 29);
            CheckPlaceResidence.TabIndex = 33;
            CheckPlaceResidence.Text = "هل يوجد عنوان سكن";
            CheckPlaceResidence.UseVisualStyleBackColor = true;
            // 
            // CheckNum
            // 
            CheckNum.AutoSize = true;
            CheckNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CheckNum.Location = new Point(299, 507);
            CheckNum.Name = "CheckNum";
            CheckNum.RightToLeft = RightToLeft.Yes;
            CheckNum.Size = new Size(184, 29);
            CheckNum.TabIndex = 34;
            CheckNum.Text = "هل يوجد رقم داخلي";
            CheckNum.UseVisualStyleBackColor = true;
            // 
            // Peoples
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 779);
            Controls.Add(CheckNum);
            Controls.Add(CheckPlaceResidence);
            Controls.Add(BtCancel);
            Controls.Add(BtUpdate);
            Controls.Add(BtDelete);
            Controls.Add(BtInput);
            Controls.Add(dataGridView1);
            Controls.Add(InputSex);
            Controls.Add(InputMaritalStatus);
            Controls.Add(InputPhoneNumber);
            Controls.Add(textBox10);
            Controls.Add(InputProfession);
            Controls.Add(InputSurname);
            Controls.Add(InputDateOfBirth);
            Controls.Add(InputPlaceResidence);
            Controls.Add(InputPlaceBirth);
            Controls.Add(UnputProsecutor);
            Controls.Add(Input2);
            Controls.Add(Input1);
            Controls.Add(InputCountry);
            Controls.Add(InputNumLocRecord);
            Controls.Add(InputDadName);
            Controls.Add(InputMomName);
            Controls.Add(InputFirstName);
            Controls.Add(InputLastName);
            Controls.Add(InputFile);
            Controls.Add(InputNumFile);
            Controls.Add(InputNum);
            Controls.Add(InputNumPersone);
            Name = "Peoples";
            Text = "الأشخاص";
            Load += Peoples_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputNumPersone;
        private TextBox InputNum;
        private TextBox InputNumFile;
        private TextBox InputFile;
        private TextBox InputLastName;
        private TextBox InputFirstName;
        private TextBox InputMomName;
        private TextBox InputDadName;
        private TextBox InputNumLocRecord;
        private ComboBox InputCountry;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox Input1;
        private ComboBox Input2;
        private ComboBox UnputProsecutor;
        private TextBox InputPlaceBirth;
        private TextBox InputPlaceResidence;
        private TextBox InputDateOfBirth;
        private TextBox InputSurname;
        private TextBox InputProfession;
        private TextBox textBox10;
        private TextBox InputPhoneNumber;
        private ComboBox InputMaritalStatus;
        private ComboBox InputSex;
        private DataGridView dataGridView1;
        private Button BtInput;
        private Button BtDelete;
        private Button BtUpdate;
        private Button BtCancel;
        private CheckBox CheckPlaceResidence;
        private CheckBox CheckNum;
    }
}