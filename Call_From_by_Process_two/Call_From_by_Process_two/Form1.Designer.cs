
namespace Call_From_by_Process_two
{
    partial class Program_B
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CloseProgram_A = new System.Windows.Forms.Button();
            this.btn_RunProgram_A = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CloseProgram_A
            // 
            this.btn_CloseProgram_A.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CloseProgram_A.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_CloseProgram_A.Location = new System.Drawing.Point(41, 205);
            this.btn_CloseProgram_A.Name = "btn_CloseProgram_A";
            this.btn_CloseProgram_A.Size = new System.Drawing.Size(230, 120);
            this.btn_CloseProgram_A.TabIndex = 0;
            this.btn_CloseProgram_A.Text = "關閉程式A";
            this.btn_CloseProgram_A.UseVisualStyleBackColor = false;
            this.btn_CloseProgram_A.Click += new System.EventHandler(this.btn_CloseProgram_A_Click);
            // 
            // btn_RunProgram_A
            // 
            this.btn_RunProgram_A.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RunProgram_A.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_RunProgram_A.Location = new System.Drawing.Point(41, 39);
            this.btn_RunProgram_A.Name = "btn_RunProgram_A";
            this.btn_RunProgram_A.Size = new System.Drawing.Size(230, 120);
            this.btn_RunProgram_A.TabIndex = 1;
            this.btn_RunProgram_A.Text = "啟動程式A";
            this.btn_RunProgram_A.UseVisualStyleBackColor = false;
            this.btn_RunProgram_A.Click += new System.EventHandler(this.btn_RunProgram_A_Click);
            // 
            // Program_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 353);
            this.Controls.Add(this.btn_RunProgram_A);
            this.Controls.Add(this.btn_CloseProgram_A);
            this.Name = "Program_B";
            this.Text = "程式B";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CloseProgram_A;
        private System.Windows.Forms.Button btn_RunProgram_A;
    }
}

