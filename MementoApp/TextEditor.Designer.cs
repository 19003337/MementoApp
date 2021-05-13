namespace MementoApp
{
    partial class TextEditor
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
            this.btn_ClearText = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txb_Input = new System.Windows.Forms.TextBox();
            this.btn_ShowHistory = new System.Windows.Forms.Button();
            this.lstView_History = new System.Windows.Forms.ListView();
            this.btn_Redo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ClearText
            // 
            this.btn_ClearText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ClearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearText.Location = new System.Drawing.Point(313, 12);
            this.btn_ClearText.Name = "btn_ClearText";
            this.btn_ClearText.Size = new System.Drawing.Size(174, 43);
            this.btn_ClearText.TabIndex = 0;
            this.btn_ClearText.Text = "Clear Text";
            this.btn_ClearText.UseVisualStyleBackColor = false;
            this.btn_ClearText.Click += new System.EventHandler(this.btn_ClearText_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Undo.Location = new System.Drawing.Point(313, 395);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(174, 43);
            this.btn_Undo.TabIndex = 1;
            this.btn_Undo.Text = "Undo";
            this.btn_Undo.UseVisualStyleBackColor = false;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(12, 395);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 43);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txb_Input
            // 
            this.txb_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Input.Location = new System.Drawing.Point(12, 61);
            this.txb_Input.Multiline = true;
            this.txb_Input.Name = "txb_Input";
            this.txb_Input.Size = new System.Drawing.Size(776, 328);
            this.txb_Input.TabIndex = 3;
            // 
            // btn_ShowHistory
            // 
            this.btn_ShowHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowHistory.Location = new System.Drawing.Point(932, 395);
            this.btn_ShowHistory.Name = "btn_ShowHistory";
            this.btn_ShowHistory.Size = new System.Drawing.Size(174, 43);
            this.btn_ShowHistory.TabIndex = 4;
            this.btn_ShowHistory.Text = "Show History";
            this.btn_ShowHistory.UseVisualStyleBackColor = false;
            this.btn_ShowHistory.Click += new System.EventHandler(this.btn_ShowHistory_Click);
            // 
            // lstView_History
            // 
            this.lstView_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_History.HideSelection = false;
            this.lstView_History.Location = new System.Drawing.Point(818, 61);
            this.lstView_History.MultiSelect = false;
            this.lstView_History.Name = "lstView_History";
            this.lstView_History.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstView_History.Size = new System.Drawing.Size(390, 328);
            this.lstView_History.TabIndex = 5;
            this.lstView_History.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Redo
            // 
            this.btn_Redo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Redo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Redo.Location = new System.Drawing.Point(614, 395);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(174, 43);
            this.btn_Redo.TabIndex = 6;
            this.btn_Redo.Text = "Redo";
            this.btn_Redo.UseVisualStyleBackColor = false;
            this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 450);
            this.Controls.Add(this.btn_Redo);
            this.Controls.Add(this.lstView_History);
            this.Controls.Add(this.btn_ShowHistory);
            this.Controls.Add(this.txb_Input);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.btn_ClearText);
            this.Name = "TextEditor";
            this.Text = "TextEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ClearText;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txb_Input;
        private System.Windows.Forms.Button btn_ShowHistory;
        private System.Windows.Forms.ListView lstView_History;
        private System.Windows.Forms.Button btn_Redo;
    }
}

