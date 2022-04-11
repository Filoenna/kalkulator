namespace KalkulatorGraph
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
            this.display = new System.Windows.Forms.TextBox();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Modulo = new System.Windows.Forms.Button();
            this.Dividing = new System.Windows.Forms.Button();
            this.Multiplying = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(776, 55);
            this.display.TabIndex = 0;
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(38, 116);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(40, 36);
            this.Seven.TabIndex = 1;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.AddText);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(104, 116);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(40, 36);
            this.Eight.TabIndex = 2;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.AddText);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(173, 116);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(40, 36);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.AddText);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(38, 174);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(40, 36);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.AddText);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(104, 174);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(40, 36);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.AddText);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(173, 174);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(40, 36);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.AddText);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(38, 231);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(40, 36);
            this.One.TabIndex = 7;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.AddText);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(104, 231);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(40, 36);
            this.Two.TabIndex = 8;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.AddText);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(173, 231);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(40, 36);
            this.Three.TabIndex = 9;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.AddText);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(38, 290);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(40, 36);
            this.Zero.TabIndex = 10;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.AddText);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(104, 290);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(40, 36);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clr";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(173, 290);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(40, 36);
            this.Addition.TabIndex = 12;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.AddText);
            // 
            // Modulo
            // 
            this.Modulo.Location = new System.Drawing.Point(239, 116);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(40, 36);
            this.Modulo.TabIndex = 13;
            this.Modulo.Text = "%";
            this.Modulo.UseVisualStyleBackColor = true;
            this.Modulo.Click += new System.EventHandler(this.AddText);
            // 
            // Dividing
            // 
            this.Dividing.Location = new System.Drawing.Point(239, 174);
            this.Dividing.Name = "Dividing";
            this.Dividing.Size = new System.Drawing.Size(40, 36);
            this.Dividing.TabIndex = 14;
            this.Dividing.Text = "/";
            this.Dividing.UseVisualStyleBackColor = true;
            this.Dividing.Click += new System.EventHandler(this.AddText);
            // 
            // Multiplying
            // 
            this.Multiplying.Location = new System.Drawing.Point(239, 231);
            this.Multiplying.Name = "Multiplying";
            this.Multiplying.Size = new System.Drawing.Size(40, 36);
            this.Multiplying.TabIndex = 15;
            this.Multiplying.Text = "*";
            this.Multiplying.UseVisualStyleBackColor = true;
            this.Multiplying.Click += new System.EventHandler(this.AddText);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(239, 290);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(40, 36);
            this.Subtraction.TabIndex = 16;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.AddText);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(318, 116);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 209);
            this.result.TabIndex = 17;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Multiplying);
            this.Controls.Add(this.Dividing);
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox display;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Zero;
        private Button Clear;
        private Button Addition;
        private Button Modulo;
        private Button Dividing;
        private Button Multiplying;
        private Button Subtraction;
        private Button result;


    }
}