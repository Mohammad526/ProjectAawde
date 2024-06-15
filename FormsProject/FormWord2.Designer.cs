namespace FormsProject
{
    partial class FormWord2
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
            InputNum = new TextBox();
            LblSerial = new Label();
            CheckedListWord = new CheckedListBox();
            DataGridViewWord = new DataGridView();
            ButDelete = new Button();
            PanelWord = new Panel();
            ((System.ComponentModel.ISupportInitialize)DataGridViewWord).BeginInit();
            SuspendLayout();
            // 
            // InputNum
            // 
            InputNum.Location = new Point(52, 56);
            InputNum.Name = "InputNum";
            InputNum.Size = new Size(160, 31);
            InputNum.TabIndex = 0;
            InputNum.Text = "1";
            // 
            // LblSerial
            // 
            LblSerial.AutoSize = true;
            LblSerial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSerial.Location = new Point(52, 9);
            LblSerial.Name = "LblSerial";
            LblSerial.Size = new Size(88, 25);
            LblSerial.TabIndex = 1;
            LblSerial.Text = "المتسلسل";
            // 
            // CheckedListWord
            // 
            CheckedListWord.FormattingEnabled = true;
            CheckedListWord.Items.AddRange(new object[] { "رشوة", "سرقة ", "سلب", "نهب ", "إرهاب", "مجموعات متطرفة/مسلحة", "احتكار", "اقامة غير مشروعة", "اقتناء أسلحة", "تبييض اموال", "اتجار بالمخدرات", "خطف", "تبادل اطلاق النار", "بيع بضائع فاسدة" });
            CheckedListWord.Location = new Point(52, 111);
            CheckedListWord.Name = "CheckedListWord";
            CheckedListWord.Size = new Size(262, 340);
            CheckedListWord.TabIndex = 2;
            // 
            // DataGridViewWord
            // 
            DataGridViewWord.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewWord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewWord.Location = new Point(698, 9);
            DataGridViewWord.Name = "DataGridViewWord";
            DataGridViewWord.RowHeadersWidth = 62;
            DataGridViewWord.Size = new Size(520, 321);
            DataGridViewWord.TabIndex = 3;
            // 
            // ButDelete
            // 
            ButDelete.BackColor = SystemColors.AppWorkspace;
            ButDelete.Location = new Point(1106, 436);
            ButDelete.Name = "ButDelete";
            ButDelete.Size = new Size(112, 71);
            ButDelete.TabIndex = 4;
            ButDelete.Text = "حذف";
            ButDelete.UseVisualStyleBackColor = false;
            // 
            // PanelWord
            // 
            PanelWord.BackColor = SystemColors.ButtonFace;
            PanelWord.Location = new Point(337, 111);
            PanelWord.Name = "PanelWord";
            PanelWord.Size = new Size(300, 340);
            PanelWord.TabIndex = 5;
            // 
            // FormWord2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 541);
            Controls.Add(PanelWord);
            Controls.Add(ButDelete);
            Controls.Add(DataGridViewWord);
            Controls.Add(CheckedListWord);
            Controls.Add(LblSerial);
            Controls.Add(InputNum);
            Name = "FormWord2";
            Text = "FormWord2";
            ((System.ComponentModel.ISupportInitialize)DataGridViewWord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputNum;
        private Label LblSerial;
        private CheckedListBox CheckedListWord;
        private DataGridView DataGridViewWord;
        private Button ButDelete;
        private Panel PanelWord;
    }
}