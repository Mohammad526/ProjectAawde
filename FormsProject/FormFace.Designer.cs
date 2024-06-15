namespace FormsProject
{
    partial class FormFace
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
            InputSerial = new TextBox();
            InputDetainee = new TextBox();
            PanelFaceLeft = new Panel();
            PanelFaceFront = new Panel();
            PanelFaceRight = new Panel();
            ButInput = new Button();
            ButUpdate = new Button();
            ButDelete = new Button();
            ButRefresh = new Button();
            ButClose = new Button();
            LblFaceLeft = new Label();
            LblFaceFront = new Label();
            LblFaceRight = new Label();
            SuspendLayout();
            // 
            // InputSerial
            // 
            InputSerial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InputSerial.Location = new Point(2, 12);
            InputSerial.Name = "InputSerial";
            InputSerial.Size = new Size(101, 31);
            InputSerial.TabIndex = 0;
            InputSerial.Text = "المتسلسل";
            // 
            // InputDetainee
            // 
            InputDetainee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InputDetainee.Location = new Point(109, 12);
            InputDetainee.Name = "InputDetainee";
            InputDetainee.Size = new Size(101, 31);
            InputDetainee.TabIndex = 1;
            InputDetainee.Text = "الموقوف";
            // 
            // PanelFaceLeft
            // 
            PanelFaceLeft.Location = new Point(109, 104);
            PanelFaceLeft.Name = "PanelFaceLeft";
            PanelFaceLeft.Size = new Size(333, 385);
            PanelFaceLeft.TabIndex = 2;
            // 
            // PanelFaceFront
            // 
            PanelFaceFront.Location = new Point(484, 104);
            PanelFaceFront.Name = "PanelFaceFront";
            PanelFaceFront.Size = new Size(333, 385);
            PanelFaceFront.TabIndex = 3;
            // 
            // PanelFaceRight
            // 
            PanelFaceRight.Location = new Point(867, 104);
            PanelFaceRight.Name = "PanelFaceRight";
            PanelFaceRight.Size = new Size(333, 385);
            PanelFaceRight.TabIndex = 4;
            // 
            // ButInput
            // 
            ButInput.Location = new Point(1263, 535);
            ButInput.Name = "ButInput";
            ButInput.Size = new Size(112, 55);
            ButInput.TabIndex = 5;
            ButInput.Text = "إدخال";
            ButInput.UseVisualStyleBackColor = true;
            // 
            // ButUpdate
            // 
            ButUpdate.Location = new Point(1135, 535);
            ButUpdate.Name = "ButUpdate";
            ButUpdate.Size = new Size(112, 55);
            ButUpdate.TabIndex = 6;
            ButUpdate.Text = "تعديل";
            ButUpdate.UseVisualStyleBackColor = true;
            // 
            // ButDelete
            // 
            ButDelete.Location = new Point(1006, 535);
            ButDelete.Name = "ButDelete";
            ButDelete.Size = new Size(112, 55);
            ButDelete.TabIndex = 7;
            ButDelete.Text = "حذف";
            ButDelete.UseVisualStyleBackColor = true;
            // 
            // ButRefresh
            // 
            ButRefresh.Location = new Point(880, 535);
            ButRefresh.Name = "ButRefresh";
            ButRefresh.Size = new Size(112, 55);
            ButRefresh.TabIndex = 8;
            ButRefresh.Text = "تنشيط";
            ButRefresh.UseVisualStyleBackColor = true;
            // 
            // ButClose
            // 
            ButClose.Location = new Point(751, 535);
            ButClose.Name = "ButClose";
            ButClose.Size = new Size(112, 55);
            ButClose.TabIndex = 9;
            ButClose.Text = "إلغاء";
            ButClose.UseVisualStyleBackColor = true;
            // 
            // LblFaceLeft
            // 
            LblFaceLeft.AutoSize = true;
            LblFaceLeft.BackColor = SystemColors.Info;
            LblFaceLeft.Location = new Point(232, 59);
            LblFaceLeft.Name = "LblFaceLeft";
            LblFaceLeft.Size = new Size(79, 25);
            LblFaceLeft.TabIndex = 10;
            LblFaceLeft.Text = "وجه أيسر";
            // 
            // LblFaceFront
            // 
            LblFaceFront.AutoSize = true;
            LblFaceFront.BackColor = SystemColors.Info;
            LblFaceFront.Location = new Point(594, 59);
            LblFaceFront.Name = "LblFaceFront";
            LblFaceFront.Size = new Size(93, 25);
            LblFaceFront.TabIndex = 11;
            LblFaceFront.Text = "وجه أمامي";
            // 
            // LblFaceRight
            // 
            LblFaceRight.AutoSize = true;
            LblFaceRight.BackColor = SystemColors.Info;
            LblFaceRight.Location = new Point(981, 59);
            LblFaceRight.Name = "LblFaceRight";
            LblFaceRight.Size = new Size(80, 25);
            LblFaceRight.TabIndex = 12;
            LblFaceRight.Text = "وجه أيمن";
            // 
            // FormFace
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 628);
            Controls.Add(LblFaceRight);
            Controls.Add(LblFaceFront);
            Controls.Add(LblFaceLeft);
            Controls.Add(ButClose);
            Controls.Add(ButRefresh);
            Controls.Add(ButDelete);
            Controls.Add(ButUpdate);
            Controls.Add(ButInput);
            Controls.Add(PanelFaceRight);
            Controls.Add(PanelFaceFront);
            Controls.Add(PanelFaceLeft);
            Controls.Add(InputDetainee);
            Controls.Add(InputSerial);
            Name = "FormFace";
            Text = "FormFace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputSerial;
        private TextBox InputDetainee;
        private Panel PanelFaceLeft;
        private Panel PanelFaceFront;
        private Panel PanelFaceRight;
        private Button ButInput;
        private Button ButUpdate;
        private Button ButDelete;
        private Button ButRefresh;
        private Button ButClose;
        private Label LblFaceLeft;
        private Label LblFaceFront;
        private Label LblFaceRight;
    }
}