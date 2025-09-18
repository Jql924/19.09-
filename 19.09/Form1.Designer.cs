namespace MergeTextWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(90, 12);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(180, 20);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.Text = "й";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(90, 41);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(180, 20);
            this.textBoxB.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(90, 100);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(180, 20);
            this.textBoxResult.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 15);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(52, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Число A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 44);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(52, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Число B:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 103);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Результат:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(80, 70);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(62, 24);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "−";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(148, 70);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(62, 24);
            this.btnMul.TabIndex = 8;
            this.btnMul.Text = "×";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(216, 70);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(62, 24);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(90, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 24);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(290, 165);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Мини-калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClear;
    }
}
