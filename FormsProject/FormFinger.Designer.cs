namespace FormsProject
{
    partial class FormFinger
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
            InputSerialName = new TextBox();
            PanelFinLeft = new Panel();
            PanelFinRight = new Panel();
            LblFinLeft = new Label();
            LblFinRight = new Label();
            ButUpdate = new Button();
            ButDelete = new Button();
            ButRefresh = new Button();
            ButDelet = new Button();
            InputSerialNum = new TextBox();
            SuspendLayout();
            // 
            // InputSerialName
            // 
            InputSerialName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InputSerialName.Location = new Point(12, 12);
            InputSerialName.Name = "InputSerialName";
            InputSerialName.Size = new Size(92, 31);
            InputSerialName.TabIndex = 0;
            InputSerialName.Text = "المتسلسل";
            // 
            // PanelFinLeft
            // 
            PanelFinLeft.Location = new Point(287, 130);
            PanelFinLeft.Name = "PanelFinLeft";
            PanelFinLeft.Size = new Size(300, 384);
            PanelFinLeft.TabIndex = 1;
            // 
            // PanelFinRight
            // 
            PanelFinRight.Location = new Point(661, 130);
            PanelFinRight.Name = "PanelFinRight";
            PanelFinRight.Size = new Size(300, 384);
            PanelFinRight.TabIndex = 2;
            // 
            // LblFinLeft
            // 
            LblFinLeft.AutoSize = true;
            LblFinLeft.BackColor = SystemColors.Info;
            LblFinLeft.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblFinLeft.Location = new Point(381, 62);
            LblFinLeft.Name = "LblFinLeft";
            LblFinLeft.Size = new Size(92, 28);
            LblFinLeft.TabIndex = 3;
            LblFinLeft.Text = "إبهام أيسر";
            // 
            // LblFinRight
            // 
            LblFinRight.AutoSize = true;
            LblFinRight.BackColor = SystemColors.Info;
            LblFinRight.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblFinRight.Location = new Point(783, 62);
            LblFinRight.Name = "LblFinRight";
            LblFinRight.Size = new Size(94, 28);
            LblFinRight.TabIndex = 4;
            LblFinRight.Text = "إبهام أيمن";
            // 
            // ButUpdate
            // 
            ButUpdate.Location = new Point(971, 552);
            ButUpdate.Name = "ButUpdate";
            ButUpdate.Size = new Size(112, 44);
            ButUpdate.TabIndex = 5;
            ButUpdate.Text = "تعديل";
            ButUpdate.UseVisualStyleBackColor = true;
            // 
            // ButDelete
            // 
            ButDelete.Location = new Point(849, 552);
            ButDelete.Name = "ButDelete";
            ButDelete.Size = new Size(112, 44);
            ButDelete.TabIndex = 6;
            ButDelete.Text = "حذف";
            ButDelete.UseVisualStyleBackColor = true;
            // 
            // ButRefresh
            // 
            ButRefresh.Location = new Point(730, 552);
            ButRefresh.Name = "ButRefresh";
            ButRefresh.Size = new Size(112, 44);
            ButRefresh.TabIndex = 7;
            ButRefresh.Text = "تنشيط";
            ButRefresh.UseVisualStyleBackColor = true;
            // 
            // ButDelet
            // 
            ButDelet.Location = new Point(612, 552);
            ButDelet.Name = "ButDelet";
            ButDelet.Size = new Size(112, 44);
            ButDelet.TabIndex = 8;
            ButDelet.Text = "إلغاء";
            ButDelet.UseVisualStyleBackColor = true;
            // 
            // InputSerialNum
            // 
            InputSerialNum.Location = new Point(110, 12);
            InputSerialNum.Name = "InputSerialNum";
            InputSerialNum.Size = new Size(60, 31);
            InputSerialNum.TabIndex = 9;
            // 
            // FormFinger
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 620);
            Controls.Add(InputSerialNum);
            Controls.Add(ButDelet);
            Controls.Add(ButRefresh);
            Controls.Add(ButDelete);
            Controls.Add(ButUpdate);
            Controls.Add(LblFinRight);
            Controls.Add(LblFinLeft);
            Controls.Add(PanelFinRight);
            Controls.Add(PanelFinLeft);
            Controls.Add(InputSerialName);
            Name = "FormFinger";
            Text = "FormFinger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputSerialName;
        private Panel PanelFinLeft;
        private Panel PanelFinRight;
        private Label LblFinLeft;
        private Label LblFinRight;
        private Button ButUpdate;
        private Button ButDelete;
        private Button ButRefresh;
        private Button ButDelet;
        private TextBox InputSerialNum;
    }
}