﻿namespace Calculator
{
    partial class Form1
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNumber.Location = new System.Drawing.Point(47, 37);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(803, 61);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(62, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 48);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSeven.Location = new System.Drawing.Point(214, 140);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(132, 48);
            this.btnSeven.TabIndex = 2;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFour.Location = new System.Drawing.Point(214, 218);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(132, 48);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOne.Location = new System.Drawing.Point(214, 290);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(132, 48);
            this.btnOne.TabIndex = 4;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDot.Location = new System.Drawing.Point(214, 366);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(132, 48);
            this.btnDot.TabIndex = 5;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEight.Location = new System.Drawing.Point(368, 140);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(132, 48);
            this.btnEight.TabIndex = 6;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTwo.Location = new System.Drawing.Point(368, 290);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(132, 48);
            this.btnTwo.TabIndex = 7;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFive.Location = new System.Drawing.Point(368, 218);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(132, 48);
            this.btnFive.TabIndex = 8;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnZero.Location = new System.Drawing.Point(368, 366);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(132, 48);
            this.btnZero.TabIndex = 9;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNine.Location = new System.Drawing.Point(515, 140);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(132, 48);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSix.Location = new System.Drawing.Point(515, 218);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(132, 48);
            this.btnSix.TabIndex = 11;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnThree.Location = new System.Drawing.Point(515, 290);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(132, 48);
            this.btnThree.TabIndex = 12;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEqual.Location = new System.Drawing.Point(515, 366);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(132, 48);
            this.btnEqual.TabIndex = 13;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDivide.Location = new System.Drawing.Point(662, 140);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(132, 48);
            this.btnDivide.TabIndex = 14;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.Location = new System.Drawing.Point(662, 218);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(132, 48);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "*";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.Location = new System.Drawing.Point(662, 290);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(132, 48);
            this.btnMinus.TabIndex = 16;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(662, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 48);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 451);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAdd;
    }
}
