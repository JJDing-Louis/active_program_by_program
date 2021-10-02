
namespace Call_From_by_Process_one
{
    partial class Program_A
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
            this.btn_RunProgram_B = new System.Windows.Forms.Button();
            this.btn_CloseProgram_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RunProgram_B
            // 
            this.btn_RunProgram_B.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RunProgram_B.Location = new System.Drawing.Point(39, 37);
            this.btn_RunProgram_B.Name = "btn_RunProgram_B";
            this.btn_RunProgram_B.Size = new System.Drawing.Size(230, 120);
            this.btn_RunProgram_B.TabIndex = 0;
            this.btn_RunProgram_B.Text = "啟動程式B";
            this.btn_RunProgram_B.UseVisualStyleBackColor = true;
            this.btn_RunProgram_B.Click += new System.EventHandler(this.btn_RunProgram_B_Click);
            // 
            // btn_CloseProgram_B
            // 
            this.btn_CloseProgram_B.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseProgram_B.Location = new System.Drawing.Point(39, 197);
            this.btn_CloseProgram_B.Name = "btn_CloseProgram_B";
            this.btn_CloseProgram_B.Size = new System.Drawing.Size(230, 120);
            this.btn_CloseProgram_B.TabIndex = 1;
            this.btn_CloseProgram_B.Text = "關閉程式B";
            this.btn_CloseProgram_B.UseVisualStyleBackColor = true;
            this.btn_CloseProgram_B.Click += new System.EventHandler(this.btn_CloseProgram_B_Click);
            // 
            // Program_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 353);
            this.Controls.Add(this.btn_CloseProgram_B);
            this.Controls.Add(this.btn_RunProgram_B);
            this.Name = "Program_A";
            this.Text = "程式A";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RunProgram_B;
        private System.Windows.Forms.Button btn_CloseProgram_B;
    }
}

