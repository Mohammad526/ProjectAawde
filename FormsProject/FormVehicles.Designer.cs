namespace FormsProject
{
    partial class FormVehicles
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
            InputVehicleID = new TextBox();
            InputCode = new ComboBox();
            InputPhoneNum = new TextBox();
            InputDateTimeProd = new DateTimePicker();
            InputNumStruct = new TextBox();
            InputNumEngine = new TextBox();
            InputColor = new TextBox();
            InputModel = new TextBox();
            InputType = new TextBox();
            InputSpecif = new TextBox();
            InputDateTimePurch = new DateTimePicker();
            InputVillage = new ComboBox();
            LblVehicleID = new Label();
            LblCode = new Label();
            LblPhoneNum = new Label();
            LblDateTimeProd = new Label();
            LblStruct = new Label();
            LblNumEngine = new Label();
            LblColor = new Label();
            LblModel = new Label();
            LblType = new Label();
            LblSpecif = new Label();
            LblDateTimePurch = new Label();
            LblVillage = new Label();
            InputSerial = new TextBox();
            InputCarNum = new TextBox();
            InputFName = new TextBox();
            InputMName = new TextBox();
            InputLName = new TextBox();
            InputAge = new DomainUpDown();
            InputPlaceBirth = new ComboBox();
            InputAddress = new TextBox();
            InputInService = new DomainUpDown();
            InputNumSouls = new TextBox();
            CheckOrder = new CheckBox();
            InputResidence = new TextBox();
            LblAge = new Label();
            LblLName = new Label();
            LblMName = new Label();
            LblFName = new Label();
            LblCarNum = new Label();
            LblSerial = new Label();
            LblResidence = new Label();
            LblOrder = new Label();
            LblSouls = new Label();
            LblInService = new Label();
            LblAddress = new Label();
            LblPlaceBirth = new Label();
            dataGridView = new DataGridView();
            ButInput = new Button();
            ButUpdate = new Button();
            ButDelete = new Button();
            ButCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // InputVehicleID
            // 
            InputVehicleID.Location = new Point(5, 9);
            InputVehicleID.Name = "InputVehicleID";
            InputVehicleID.Size = new Size(150, 31);
            InputVehicleID.TabIndex = 0;
            InputVehicleID.Text = "No Vehicle";
            // 
            // InputCode
            // 
            InputCode.FormattingEnabled = true;
            InputCode.Location = new Point(5, 46);
            InputCode.Name = "InputCode";
            InputCode.Size = new Size(182, 33);
            InputCode.TabIndex = 1;
            InputCode.Text = "No Code";
            // 
            // InputPhoneNum
            // 
            InputPhoneNum.Location = new Point(5, 85);
            InputPhoneNum.Name = "InputPhoneNum";
            InputPhoneNum.Size = new Size(150, 31);
            InputPhoneNum.TabIndex = 2;
            InputPhoneNum.Text = "+__-__-__-__";
            // 
            // InputDateTimeProd
            // 
            InputDateTimeProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InputDateTimeProd.Location = new Point(5, 122);
            InputDateTimeProd.Name = "InputDateTimeProd";
            InputDateTimeProd.Size = new Size(300, 31);
            InputDateTimeProd.TabIndex = 3;
            // 
            // InputNumStruct
            // 
            InputNumStruct.Location = new Point(5, 159);
            InputNumStruct.Name = "InputNumStruct";
            InputNumStruct.Size = new Size(150, 31);
            InputNumStruct.TabIndex = 4;
            // 
            // InputNumEngine
            // 
            InputNumEngine.Location = new Point(5, 196);
            InputNumEngine.Name = "InputNumEngine";
            InputNumEngine.Size = new Size(150, 31);
            InputNumEngine.TabIndex = 5;
            // 
            // InputColor
            // 
            InputColor.Location = new Point(5, 233);
            InputColor.Name = "InputColor";
            InputColor.Size = new Size(150, 31);
            InputColor.TabIndex = 6;
            // 
            // InputModel
            // 
            InputModel.Location = new Point(5, 270);
            InputModel.Name = "InputModel";
            InputModel.Size = new Size(150, 31);
            InputModel.TabIndex = 7;
            // 
            // InputType
            // 
            InputType.Location = new Point(5, 307);
            InputType.Name = "InputType";
            InputType.Size = new Size(150, 31);
            InputType.TabIndex = 8;
            // 
            // InputSpecif
            // 
            InputSpecif.Location = new Point(5, 344);
            InputSpecif.Name = "InputSpecif";
            InputSpecif.Size = new Size(150, 31);
            InputSpecif.TabIndex = 9;
            // 
            // InputDateTimePurch
            // 
            InputDateTimePurch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InputDateTimePurch.Location = new Point(5, 381);
            InputDateTimePurch.Name = "InputDateTimePurch";
            InputDateTimePurch.Size = new Size(300, 31);
            InputDateTimePurch.TabIndex = 10;
            // 
            // InputVillage
            // 
            InputVillage.FormattingEnabled = true;
            InputVillage.Location = new Point(5, 418);
            InputVillage.Name = "InputVillage";
            InputVillage.Size = new Size(182, 33);
            InputVillage.TabIndex = 11;
            // 
            // LblVehicleID
            // 
            LblVehicleID.AutoSize = true;
            LblVehicleID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblVehicleID.Location = new Point(299, 15);
            LblVehicleID.Name = "LblVehicleID";
            LblVehicleID.Size = new Size(97, 25);
            LblVehicleID.TabIndex = 12;
            LblVehicleID.Text = "Vehicle ID";
            // 
            // LblCode
            // 
            LblCode.AutoSize = true;
            LblCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblCode.Location = new Point(340, 48);
            LblCode.Name = "LblCode";
            LblCode.Size = new Size(48, 25);
            LblCode.TabIndex = 13;
            LblCode.Text = "الرمز";
            // 
            // LblPhoneNum
            // 
            LblPhoneNum.AutoSize = true;
            LblPhoneNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblPhoneNum.Location = new Point(311, 85);
            LblPhoneNum.Name = "LblPhoneNum";
            LblPhoneNum.Size = new Size(92, 25);
            LblPhoneNum.TabIndex = 14;
            LblPhoneNum.Text = "رقم الهاتف";
            LblPhoneNum.Click += LblPhoneNum_Click;
            // 
            // LblDateTimeProd
            // 
            LblDateTimeProd.AutoSize = true;
            LblDateTimeProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblDateTimeProd.Location = new Point(311, 122);
            LblDateTimeProd.Name = "LblDateTimeProd";
            LblDateTimeProd.Size = new Size(101, 25);
            LblDateTimeProd.TabIndex = 15;
            LblDateTimeProd.Text = "تاريخ الصنع";
            // 
            // LblStruct
            // 
            LblStruct.AutoSize = true;
            LblStruct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblStruct.Location = new Point(294, 159);
            LblStruct.Name = "LblStruct";
            LblStruct.Size = new Size(90, 25);
            LblStruct.TabIndex = 16;
            LblStruct.Text = "رقم الهيكل";
            // 
            // LblNumEngine
            // 
            LblNumEngine.AutoSize = true;
            LblNumEngine.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblNumEngine.Location = new Point(306, 202);
            LblNumEngine.Name = "LblNumEngine";
            LblNumEngine.Size = new Size(97, 25);
            LblNumEngine.TabIndex = 17;
            LblNumEngine.Text = "رقم المحرك";
            // 
            // LblColor
            // 
            LblColor.AutoSize = true;
            LblColor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblColor.Location = new Point(325, 236);
            LblColor.Name = "LblColor";
            LblColor.Size = new Size(50, 25);
            LblColor.TabIndex = 18;
            LblColor.Text = "اللون";
            // 
            // LblModel
            // 
            LblModel.AutoSize = true;
            LblModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblModel.Location = new Point(325, 276);
            LblModel.Name = "LblModel";
            LblModel.Size = new Size(57, 25);
            LblModel.TabIndex = 19;
            LblModel.Text = "الطراز";
            // 
            // LblType
            // 
            LblType.AutoSize = true;
            LblType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblType.Location = new Point(325, 313);
            LblType.Name = "LblType";
            LblType.Size = new Size(49, 25);
            LblType.TabIndex = 20;
            LblType.Text = "النوع";
            // 
            // LblSpecif
            // 
            LblSpecif.AutoSize = true;
            LblSpecif.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblSpecif.Location = new Point(299, 350);
            LblSpecif.Name = "LblSpecif";
            LblSpecif.Size = new Size(97, 25);
            LblSpecif.TabIndex = 21;
            LblSpecif.Text = "المواصفات";
            // 
            // LblDateTimePurch
            // 
            LblDateTimePurch.AutoSize = true;
            LblDateTimePurch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblDateTimePurch.Location = new Point(311, 387);
            LblDateTimePurch.Name = "LblDateTimePurch";
            LblDateTimePurch.Size = new Size(99, 25);
            LblDateTimePurch.TabIndex = 22;
            LblDateTimePurch.Text = "تاريخ الشراء";
            // 
            // LblVillage
            // 
            LblVillage.AutoSize = true;
            LblVillage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblVillage.Location = new Point(299, 426);
            LblVillage.Name = "LblVillage";
            LblVillage.Size = new Size(64, 25);
            LblVillage.TabIndex = 23;
            LblVillage.Text = "المدينة";
            // 
            // InputSerial
            // 
            InputSerial.Location = new Point(412, 9);
            InputSerial.Name = "InputSerial";
            InputSerial.Size = new Size(150, 31);
            InputSerial.TabIndex = 24;
            // 
            // InputCarNum
            // 
            InputCarNum.Location = new Point(412, 48);
            InputCarNum.Name = "InputCarNum";
            InputCarNum.Size = new Size(150, 31);
            InputCarNum.TabIndex = 25;
            // 
            // InputFName
            // 
            InputFName.Location = new Point(412, 85);
            InputFName.Name = "InputFName";
            InputFName.Size = new Size(150, 31);
            InputFName.TabIndex = 26;
            // 
            // InputMName
            // 
            InputMName.Location = new Point(412, 120);
            InputMName.Name = "InputMName";
            InputMName.Size = new Size(150, 31);
            InputMName.TabIndex = 27;
            // 
            // InputLName
            // 
            InputLName.Location = new Point(412, 164);
            InputLName.Name = "InputLName";
            InputLName.Size = new Size(150, 31);
            InputLName.TabIndex = 28;
            // 
            // InputAge
            // 
            InputAge.Location = new Point(412, 202);
            InputAge.Name = "InputAge";
            InputAge.Size = new Size(180, 31);
            InputAge.TabIndex = 29;
            InputAge.Text = "domainUpDown1";
            // 
            // InputPlaceBirth
            // 
            InputPlaceBirth.FormattingEnabled = true;
            InputPlaceBirth.Location = new Point(412, 239);
            InputPlaceBirth.Name = "InputPlaceBirth";
            InputPlaceBirth.Size = new Size(182, 33);
            InputPlaceBirth.TabIndex = 30;
            // 
            // InputAddress
            // 
            InputAddress.Location = new Point(412, 278);
            InputAddress.Name = "InputAddress";
            InputAddress.Size = new Size(150, 31);
            InputAddress.TabIndex = 31;
            // 
            // InputInService
            // 
            InputInService.Location = new Point(412, 315);
            InputInService.Name = "InputInService";
            InputInService.Size = new Size(180, 31);
            InputInService.TabIndex = 32;
            InputInService.Text = "domainUpDown2";
            // 
            // InputNumSouls
            // 
            InputNumSouls.Location = new Point(412, 352);
            InputNumSouls.Name = "InputNumSouls";
            InputNumSouls.Size = new Size(150, 31);
            InputNumSouls.TabIndex = 33;
            // 
            // CheckOrder
            // 
            CheckOrder.AutoSize = true;
            CheckOrder.Location = new Point(412, 394);
            CheckOrder.Name = "CheckOrder";
            CheckOrder.Size = new Size(144, 29);
            CheckOrder.TabIndex = 34;
            CheckOrder.Text = "Out Of Order";
            CheckOrder.UseVisualStyleBackColor = true;
            // 
            // InputResidence
            // 
            InputResidence.Location = new Point(412, 426);
            InputResidence.Name = "InputResidence";
            InputResidence.Size = new Size(150, 31);
            InputResidence.TabIndex = 35;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblAge.Location = new Point(603, 202);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(53, 25);
            LblAge.TabIndex = 41;
            LblAge.Text = "العمر";
            // 
            // LblLName
            // 
            LblLName.AutoSize = true;
            LblLName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblLName.Location = new Point(603, 157);
            LblLName.Name = "LblLName";
            LblLName.Size = new Size(60, 25);
            LblLName.TabIndex = 40;
            LblLName.Text = "العائلة";
            // 
            // LblMName
            // 
            LblMName.AutoSize = true;
            LblMName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblMName.Location = new Point(603, 120);
            LblMName.Name = "LblMName";
            LblMName.Size = new Size(75, 25);
            LblMName.TabIndex = 39;
            LblMName.Text = "اسم الأم";
            // 
            // LblFName
            // 
            LblFName.AutoSize = true;
            LblFName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblFName.Location = new Point(603, 80);
            LblFName.Name = "LblFName";
            LblFName.Size = new Size(54, 25);
            LblFName.TabIndex = 38;
            LblFName.Text = "الإسم";
            // 
            // LblCarNum
            // 
            LblCarNum.AutoSize = true;
            LblCarNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblCarNum.Location = new Point(603, 46);
            LblCarNum.Name = "LblCarNum";
            LblCarNum.Size = new Size(95, 25);
            LblCarNum.TabIndex = 37;
            LblCarNum.Text = "رقم السيارة";
            // 
            // LblSerial
            // 
            LblSerial.AutoSize = true;
            LblSerial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblSerial.Location = new Point(603, 9);
            LblSerial.Name = "LblSerial";
            LblSerial.Size = new Size(88, 25);
            LblSerial.TabIndex = 36;
            LblSerial.Text = "المتسلسل";
            // 
            // LblResidence
            // 
            LblResidence.AutoSize = true;
            LblResidence.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblResidence.Location = new Point(603, 432);
            LblResidence.Name = "LblResidence";
            LblResidence.Size = new Size(62, 25);
            LblResidence.TabIndex = 47;
            LblResidence.Text = "الإقامة";
            // 
            // LblOrder
            // 
            LblOrder.AutoSize = true;
            LblOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblOrder.Location = new Point(578, 394);
            LblOrder.Name = "LblOrder";
            LblOrder.Size = new Size(153, 25);
            LblOrder.TabIndex = 46;
            LblOrder.Text = "موضوعة في السير";
            // 
            // LblSouls
            // 
            LblSouls.AutoSize = true;
            LblSouls.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblSouls.Location = new Point(603, 352);
            LblSouls.Name = "LblSouls";
            LblSouls.Size = new Size(128, 25);
            LblSouls.TabIndex = 45;
            LblSouls.Text = "رقم قيد النفوس";
            // 
            // LblInService
            // 
            LblInService.AutoSize = true;
            LblInService.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblInService.Location = new Point(598, 315);
            LblInService.Name = "LblInService";
            LblInService.Size = new Size(146, 25);
            LblInService.TabIndex = 44;
            LblInService.Text = "الوضع في الخدمة";
            LblInService.Click += label22_Click;
            // 
            // LblAddress
            // 
            LblAddress.AutoSize = true;
            LblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblAddress.Location = new Point(603, 279);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(66, 25);
            LblAddress.TabIndex = 43;
            LblAddress.Text = "العنوان";
            // 
            // LblPlaceBirth
            // 
            LblPlaceBirth.AutoSize = true;
            LblPlaceBirth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblPlaceBirth.Location = new Point(603, 236);
            LblPlaceBirth.Name = "LblPlaceBirth";
            LblPlaceBirth.Size = new Size(100, 25);
            LblPlaceBirth.TabIndex = 42;
            LblPlaceBirth.Text = "محل الولادة";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(750, 9);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(635, 410);
            dataGridView.TabIndex = 48;
            // 
            // ButInput
            // 
            ButInput.BackColor = SystemColors.ActiveCaption;
            ButInput.Location = new Point(1274, 432);
            ButInput.Name = "ButInput";
            ButInput.Size = new Size(112, 49);
            ButInput.TabIndex = 49;
            ButInput.Text = "إدخال";
            ButInput.UseVisualStyleBackColor = false;
            // 
            // ButUpdate
            // 
            ButUpdate.BackColor = SystemColors.ActiveCaption;
            ButUpdate.Location = new Point(1116, 432);
            ButUpdate.Name = "ButUpdate";
            ButUpdate.Size = new Size(112, 49);
            ButUpdate.TabIndex = 50;
            ButUpdate.Text = "تعديل";
            ButUpdate.UseVisualStyleBackColor = false;
            // 
            // ButDelete
            // 
            ButDelete.BackColor = SystemColors.ActiveCaption;
            ButDelete.Location = new Point(957, 432);
            ButDelete.Name = "ButDelete";
            ButDelete.Size = new Size(112, 49);
            ButDelete.TabIndex = 51;
            ButDelete.Text = "حذف";
            ButDelete.UseVisualStyleBackColor = false;
            // 
            // ButCancel
            // 
            ButCancel.BackColor = SystemColors.ActiveCaption;
            ButCancel.Location = new Point(798, 432);
            ButCancel.Name = "ButCancel";
            ButCancel.Size = new Size(112, 49);
            ButCancel.TabIndex = 52;
            ButCancel.Text = "إلغاء";
            ButCancel.UseVisualStyleBackColor = false;
            // 
            // FormVehicles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 535);
            Controls.Add(ButCancel);
            Controls.Add(ButDelete);
            Controls.Add(ButUpdate);
            Controls.Add(ButInput);
            Controls.Add(dataGridView);
            Controls.Add(LblResidence);
            Controls.Add(LblOrder);
            Controls.Add(LblSouls);
            Controls.Add(LblInService);
            Controls.Add(LblAddress);
            Controls.Add(LblPlaceBirth);
            Controls.Add(LblAge);
            Controls.Add(LblLName);
            Controls.Add(LblMName);
            Controls.Add(LblFName);
            Controls.Add(LblCarNum);
            Controls.Add(LblSerial);
            Controls.Add(InputResidence);
            Controls.Add(CheckOrder);
            Controls.Add(InputNumSouls);
            Controls.Add(InputInService);
            Controls.Add(InputAddress);
            Controls.Add(InputPlaceBirth);
            Controls.Add(InputAge);
            Controls.Add(InputLName);
            Controls.Add(InputMName);
            Controls.Add(InputFName);
            Controls.Add(InputCarNum);
            Controls.Add(InputSerial);
            Controls.Add(LblVillage);
            Controls.Add(LblDateTimePurch);
            Controls.Add(LblSpecif);
            Controls.Add(LblType);
            Controls.Add(LblModel);
            Controls.Add(LblColor);
            Controls.Add(LblNumEngine);
            Controls.Add(LblStruct);
            Controls.Add(LblDateTimeProd);
            Controls.Add(LblPhoneNum);
            Controls.Add(LblCode);
            Controls.Add(LblVehicleID);
            Controls.Add(InputVillage);
            Controls.Add(InputDateTimePurch);
            Controls.Add(InputSpecif);
            Controls.Add(InputType);
            Controls.Add(InputModel);
            Controls.Add(InputColor);
            Controls.Add(InputNumEngine);
            Controls.Add(InputNumStruct);
            Controls.Add(InputDateTimeProd);
            Controls.Add(InputPhoneNum);
            Controls.Add(InputCode);
            Controls.Add(InputVehicleID);
            Name = "FormVehicles";
            Text = "FormVehicles";
            Load += FormVehicles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputVehicleID;
        private ComboBox InputCode;
        private TextBox InputPhoneNum;
        private DateTimePicker InputDateTimeProd;
        private TextBox InputNumStruct;
        private TextBox InputNumEngine;
        private TextBox InputColor;
        private TextBox InputModel;
        private TextBox InputType;
        private TextBox InputSpecif;
        private DateTimePicker InputDateTimePurch;
        private ComboBox InputVillage;
        private Label LblVehicleID;
        private Label LblCode;
        private Label LblPhoneNum;
        private Label LblDateTimeProd;
        private Label LblStruct;
        private Label LblNumEngine;
        private Label LblColor;
        private Label LblModel;
        private Label LblType;
        private Label LblSpecif;
        private Label LblDateTimePurch;
        private Label LblVillage;
        private TextBox InputSerial;
        private TextBox InputCarNum;
        private TextBox InputFName;
        private TextBox InputMName;
        private TextBox InputLName;
        private DomainUpDown InputAge;
        private ComboBox InputPlaceBirth;
        private TextBox InputAddress;
        private DomainUpDown InputInService;
        private TextBox InputNumSouls;
        private CheckBox CheckOrder;
        private TextBox InputResidence;
        private Label LblAge;
        private Label LblLName;
        private Label LblMName;
        private Label LblFName;
        private Label LblCarNum;
        private Label LblSerial;
        private Label LblResidence;
        private Label LblOrder;
        private Label LblSouls;
        private Label LblInService;
        private Label LblAddress;
        private Label LblPlaceBirth;
        private DataGridView dataGridView;
        private Button ButInput;
        private Button ButUpdate;
        private Button ButDelete;
        private Button ButCancel;
    }
}