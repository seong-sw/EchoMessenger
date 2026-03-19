namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl = new Label();
            txtList = new ListBox();
            txtMessage = new TextBox();
            lblCount = new Label();
            btnSend = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Pretendard JP Variable", 36F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lbl.Location = new Point(12, 19);
            lbl.Name = "lbl";
            lbl.Size = new Size(576, 86);
            lbl.TabIndex = 0;
            lbl.Text = "Echo Messenger";
            // 
            // txtList
            // 
            txtList.BorderStyle = BorderStyle.FixedSingle;
            txtList.Font = new Font("Pretendard JP Variable", 11F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtList.FormattingEnabled = true;
            txtList.Location = new Point(32, 126);
            txtList.Name = "txtList";
            txtList.Size = new Size(861, 314);
            txtList.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.Font = new Font("Pretendard JP Variable", 11F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtMessage.Location = new Point(32, 473);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "여기에 텍스트 입력...";
            txtMessage.Size = new Size(547, 34);
            txtMessage.TabIndex = 2;
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(30, 447);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(121, 21);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화 : 0개";
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Pretendard JP Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnSend.Location = new Point(601, 473);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(53, 34);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Pretendard JP Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnDelete.Location = new Point(676, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(55, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Pretendard JP Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnClear.Location = new Point(752, 473);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 34);
            btnClear.TabIndex = 6;
            btnClear.Text = "대화 기록 삭제";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 538);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblCount);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtList);
            Controls.Add(lbl);
            Name = "Form1";
            Text = "Echo Messenger";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private ListBox txtList;
        private TextBox txtMessage;
        private Label lblCount;
        private Button btnSend;
        private Button btnDelete;
        private Button btnClear;
    }
}