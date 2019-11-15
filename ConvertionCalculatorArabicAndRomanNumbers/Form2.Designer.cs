namespace ConvertionCalculatorArabicAndRomanNumbers
{
    partial class Form2
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
            this.UserInputTB = new System.Windows.Forms.TextBox();
            this.UserOutputTB = new System.Windows.Forms.TextBox();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonL̅ = new System.Windows.Forms.Button();
            this.buttonC̅ = new System.Windows.Forms.Button();
            this.buttonD̅ = new System.Windows.Forms.Button();
            this.buttonV̅ = new System.Windows.Forms.Button();
            this.buttonM̅ = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.buttonX̅ = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserInputTB
            // 
            this.UserInputTB.BackColor = System.Drawing.SystemColors.Window;
            this.UserInputTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserInputTB.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.UserInputTB.Location = new System.Drawing.Point(12, 80);
            this.UserInputTB.MaxLength = 7;
            this.UserInputTB.Multiline = true;
            this.UserInputTB.Name = "UserInputTB";
            this.UserInputTB.ReadOnly = true;
            this.UserInputTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserInputTB.Size = new System.Drawing.Size(309, 70);
            this.UserInputTB.TabIndex = 1;
            this.UserInputTB.TextChanged += new System.EventHandler(this.UserInputTB_TextChanged);
            // 
            // UserOutputTB
            // 
            this.UserOutputTB.BackColor = System.Drawing.SystemColors.Window;
            this.UserOutputTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserOutputTB.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.UserOutputTB.Location = new System.Drawing.Point(12, 156);
            this.UserOutputTB.Multiline = true;
            this.UserOutputTB.Name = "UserOutputTB";
            this.UserOutputTB.ReadOnly = true;
            this.UserOutputTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserOutputTB.Size = new System.Drawing.Size(309, 74);
            this.UserOutputTB.TabIndex = 17;
            // 
            // buttonI
            // 
            this.buttonI.BackColor = System.Drawing.SystemColors.Window;
            this.buttonI.FlatAppearance.BorderSize = 0;
            this.buttonI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonI.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonI.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonI.Location = new System.Drawing.Point(12, 236);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(73, 48);
            this.buttonI.TabIndex = 18;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = false;
            this.buttonI.Click += new System.EventHandler(this.ButtonI_Click);
            // 
            // buttonL
            // 
            this.buttonL.BackColor = System.Drawing.SystemColors.Window;
            this.buttonL.FlatAppearance.BorderSize = 0;
            this.buttonL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonL.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonL.Location = new System.Drawing.Point(248, 236);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(73, 48);
            this.buttonL.TabIndex = 19;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = false;
            this.buttonL.Click += new System.EventHandler(this.ButtonL_Click);
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.SystemColors.Window;
            this.buttonX.FlatAppearance.BorderSize = 0;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonX.Location = new System.Drawing.Point(170, 236);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(73, 48);
            this.buttonX.TabIndex = 20;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.ButtonX_Click);
            // 
            // buttonV
            // 
            this.buttonV.BackColor = System.Drawing.SystemColors.Window;
            this.buttonV.FlatAppearance.BorderSize = 0;
            this.buttonV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonV.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonV.Location = new System.Drawing.Point(91, 236);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(73, 48);
            this.buttonV.TabIndex = 21;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = false;
            this.buttonV.Click += new System.EventHandler(this.ButtonV_Click);
            // 
            // buttonM
            // 
            this.buttonM.BackColor = System.Drawing.SystemColors.Window;
            this.buttonM.FlatAppearance.BorderSize = 0;
            this.buttonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonM.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonM.Location = new System.Drawing.Point(170, 290);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(73, 48);
            this.buttonM.TabIndex = 22;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.ButtonM_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.SystemColors.Window;
            this.buttonD.FlatAppearance.BorderSize = 0;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonD.Location = new System.Drawing.Point(91, 290);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(73, 48);
            this.buttonD.TabIndex = 23;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.ButtonD_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.Window;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonC.Location = new System.Drawing.Point(12, 290);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(73, 48);
            this.buttonC.TabIndex = 24;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // buttonL̅
            // 
            this.buttonL̅.BackColor = System.Drawing.SystemColors.Window;
            this.buttonL̅.FlatAppearance.BorderSize = 0;
            this.buttonL̅.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonL̅.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL̅.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonL̅.Location = new System.Drawing.Point(91, 344);
            this.buttonL̅.Name = "buttonL̅";
            this.buttonL̅.Size = new System.Drawing.Size(73, 48);
            this.buttonL̅.TabIndex = 26;
            this.buttonL̅.Text = "L̅";
            this.buttonL̅.UseVisualStyleBackColor = false;
            this.buttonL̅.Click += new System.EventHandler(this.ButtonL̅_Click);
            // 
            // buttonC̅
            // 
            this.buttonC̅.BackColor = System.Drawing.SystemColors.Window;
            this.buttonC̅.FlatAppearance.BorderSize = 0;
            this.buttonC̅.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC̅.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC̅.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonC̅.Location = new System.Drawing.Point(170, 344);
            this.buttonC̅.Name = "buttonC̅";
            this.buttonC̅.Size = new System.Drawing.Size(73, 48);
            this.buttonC̅.TabIndex = 27;
            this.buttonC̅.Text = "C̅";
            this.buttonC̅.UseVisualStyleBackColor = false;
            this.buttonC̅.Click += new System.EventHandler(this.ButtonC̅_Click);
            // 
            // buttonD̅
            // 
            this.buttonD̅.BackColor = System.Drawing.SystemColors.Window;
            this.buttonD̅.FlatAppearance.BorderSize = 0;
            this.buttonD̅.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD̅.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD̅.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonD̅.Location = new System.Drawing.Point(248, 344);
            this.buttonD̅.Name = "buttonD̅";
            this.buttonD̅.Size = new System.Drawing.Size(73, 48);
            this.buttonD̅.TabIndex = 28;
            this.buttonD̅.Text = "D̅";
            this.buttonD̅.UseVisualStyleBackColor = false;
            this.buttonD̅.Click += new System.EventHandler(this.ButtonD̅_Click);
            // 
            // buttonV̅
            // 
            this.buttonV̅.BackColor = System.Drawing.SystemColors.Window;
            this.buttonV̅.FlatAppearance.BorderSize = 0;
            this.buttonV̅.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonV̅.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonV̅.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonV̅.Location = new System.Drawing.Point(248, 290);
            this.buttonV̅.Name = "buttonV̅";
            this.buttonV̅.Size = new System.Drawing.Size(73, 48);
            this.buttonV̅.TabIndex = 29;
            this.buttonV̅.Text = "V̅";
            this.buttonV̅.UseVisualStyleBackColor = false;
            this.buttonV̅.Click += new System.EventHandler(this.ButtonV̅_Click);
            // 
            // buttonM̅
            // 
            this.buttonM̅.BackColor = System.Drawing.SystemColors.Window;
            this.buttonM̅.FlatAppearance.BorderSize = 0;
            this.buttonM̅.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonM̅.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM̅.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonM̅.Location = new System.Drawing.Point(130, 398);
            this.buttonM̅.Name = "buttonM̅";
            this.buttonM̅.Size = new System.Drawing.Size(73, 48);
            this.buttonM̅.TabIndex = 32;
            this.buttonM̅.Text = "M̅";
            this.buttonM̅.UseVisualStyleBackColor = false;
            this.buttonM̅.Click += new System.EventHandler(this.ButtonM̅_Click);
            // 
            // swapButton
            // 
            this.swapButton.BackColor = System.Drawing.SystemColors.Window;
            this.swapButton.FlatAppearance.BorderSize = 0;
            this.swapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swapButton.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swapButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.swapButton.Location = new System.Drawing.Point(12, 398);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(112, 48);
            this.swapButton.TabIndex = 33;
            this.swapButton.Text = "↶";
            this.swapButton.UseVisualStyleBackColor = false;
            this.swapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // buttonX̅
            // 
            this.buttonX̅.BackColor = System.Drawing.SystemColors.Window;
            this.buttonX̅.FlatAppearance.BorderSize = 0;
            this.buttonX̅.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX̅.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX̅.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonX̅.Location = new System.Drawing.Point(12, 344);
            this.buttonX̅.Name = "buttonX̅";
            this.buttonX̅.Size = new System.Drawing.Size(73, 48);
            this.buttonX̅.TabIndex = 34;
            this.buttonX̅.Text = "X̅";
            this.buttonX̅.UseVisualStyleBackColor = false;
            this.buttonX̅.Click += new System.EventHandler(this.ButtonX̅_Click);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.Window;
            this.convertButton.FlatAppearance.BorderSize = 0;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.convertButton.Location = new System.Drawing.Point(209, 398);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(112, 48);
            this.convertButton.TabIndex = 35;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Window;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clearButton.Location = new System.Drawing.Point(12, 452);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(152, 48);
            this.clearButton.TabIndex = 36;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.BackColor = System.Drawing.SystemColors.Window;
            this.backspaceButton.FlatAppearance.BorderSize = 0;
            this.backspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspaceButton.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.backspaceButton.Location = new System.Drawing.Point(169, 452);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(152, 48);
            this.backspaceButton.TabIndex = 37;
            this.backspaceButton.Text = "⌫";
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 512);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.buttonX̅);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.buttonM̅);
            this.Controls.Add(this.buttonV̅);
            this.Controls.Add(this.buttonD̅);
            this.Controls.Add(this.buttonC̅);
            this.Controls.Add(this.buttonL̅);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.UserOutputTB);
            this.Controls.Add(this.UserInputTB);
            this.Name = "Form2";
            this.Text = "Convertion calculator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputTB;
        private System.Windows.Forms.TextBox UserOutputTB;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonL̅;
        private System.Windows.Forms.Button buttonC̅;
        private System.Windows.Forms.Button buttonD̅;
        private System.Windows.Forms.Button buttonV̅;
        private System.Windows.Forms.Button buttonM̅;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.Button buttonX̅;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backspaceButton;
    }
}