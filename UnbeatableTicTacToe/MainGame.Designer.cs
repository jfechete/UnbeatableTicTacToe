
namespace UnbeatableTicTacToe
{
    partial class MainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.lbl_turnDisplay = new System.Windows.Forms.Label();
            this.btn_a1 = new System.Windows.Forms.Button();
            this.btn_b1 = new System.Windows.Forms.Button();
            this.btn_c1 = new System.Windows.Forms.Button();
            this.btn_c2 = new System.Windows.Forms.Button();
            this.btn_b2 = new System.Windows.Forms.Button();
            this.btn_a2 = new System.Windows.Forms.Button();
            this.btn_c3 = new System.Windows.Forms.Button();
            this.btn_b3 = new System.Windows.Forms.Button();
            this.btn_a3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_turnDisplay
            // 
            this.lbl_turnDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lbl_turnDisplay.Location = new System.Drawing.Point(12, 0);
            this.lbl_turnDisplay.Name = "lbl_turnDisplay";
            this.lbl_turnDisplay.Size = new System.Drawing.Size(276, 20);
            this.lbl_turnDisplay.TabIndex = 0;
            this.lbl_turnDisplay.Text = "XXXXX\'s turn";
            this.lbl_turnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_a1
            // 
            this.btn_a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a1.Location = new System.Drawing.Point(5, 25);
            this.btn_a1.Name = "btn_a1";
            this.btn_a1.Size = new System.Drawing.Size(90, 90);
            this.btn_a1.TabIndex = 1;
            this.btn_a1.UseVisualStyleBackColor = true;
            this.btn_a1.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn_b1
            // 
            this.btn_b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b1.Location = new System.Drawing.Point(105, 25);
            this.btn_b1.Name = "btn_b1";
            this.btn_b1.Size = new System.Drawing.Size(90, 90);
            this.btn_b1.TabIndex = 2;
            this.btn_b1.UseVisualStyleBackColor = true;
            this.btn_b1.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn_c1
            // 
            this.btn_c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c1.Location = new System.Drawing.Point(205, 25);
            this.btn_c1.Name = "btn_c1";
            this.btn_c1.Size = new System.Drawing.Size(90, 90);
            this.btn_c1.TabIndex = 3;
            this.btn_c1.UseVisualStyleBackColor = true;
            this.btn_c1.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn_c2
            // 
            this.btn_c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c2.Location = new System.Drawing.Point(205, 125);
            this.btn_c2.Name = "btn_c2";
            this.btn_c2.Size = new System.Drawing.Size(90, 90);
            this.btn_c2.TabIndex = 6;
            this.btn_c2.UseVisualStyleBackColor = true;
            this.btn_c2.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn_b2
            // 
            this.btn_b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b2.Location = new System.Drawing.Point(105, 125);
            this.btn_b2.Name = "btn_b2";
            this.btn_b2.Size = new System.Drawing.Size(90, 90);
            this.btn_b2.TabIndex = 5;
            this.btn_b2.UseVisualStyleBackColor = true;
            this.btn_b2.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn_a2
            // 
            this.btn_a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a2.Location = new System.Drawing.Point(5, 125);
            this.btn_a2.Name = "btn_a2";
            this.btn_a2.Size = new System.Drawing.Size(90, 90);
            this.btn_a2.TabIndex = 4;
            this.btn_a2.UseVisualStyleBackColor = true;
            this.btn_a2.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn_c3
            // 
            this.btn_c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c3.Location = new System.Drawing.Point(205, 225);
            this.btn_c3.Name = "btn_c3";
            this.btn_c3.Size = new System.Drawing.Size(90, 90);
            this.btn_c3.TabIndex = 9;
            this.btn_c3.UseVisualStyleBackColor = true;
            this.btn_c3.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn_b3
            // 
            this.btn_b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b3.Location = new System.Drawing.Point(105, 225);
            this.btn_b3.Name = "btn_b3";
            this.btn_b3.Size = new System.Drawing.Size(90, 90);
            this.btn_b3.TabIndex = 8;
            this.btn_b3.UseVisualStyleBackColor = true;
            this.btn_b3.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn_a3
            // 
            this.btn_a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a3.Location = new System.Drawing.Point(5, 225);
            this.btn_a3.Name = "btn_a3";
            this.btn_a3.Size = new System.Drawing.Size(90, 90);
            this.btn_a3.TabIndex = 7;
            this.btn_a3.UseVisualStyleBackColor = true;
            this.btn_a3.Click += new System.EventHandler(this.BtnClick);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 321);
            this.Controls.Add(this.btn_c3);
            this.Controls.Add(this.btn_b3);
            this.Controls.Add(this.btn_a3);
            this.Controls.Add(this.btn_c2);
            this.Controls.Add(this.btn_b2);
            this.Controls.Add(this.btn_a2);
            this.Controls.Add(this.btn_c1);
            this.Controls.Add(this.btn_b1);
            this.Controls.Add(this.btn_a1);
            this.Controls.Add(this.lbl_turnDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(316, 360);
            this.MinimumSize = new System.Drawing.Size(316, 360);
            this.Name = "MainGame";
            this.Text = "Unbeatable Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_turnDisplay;
        private System.Windows.Forms.Button btn_a1;
        private System.Windows.Forms.Button btn_b1;
        private System.Windows.Forms.Button btn_c1;
        private System.Windows.Forms.Button btn_c2;
        private System.Windows.Forms.Button btn_b2;
        private System.Windows.Forms.Button btn_a2;
        private System.Windows.Forms.Button btn_c3;
        private System.Windows.Forms.Button btn_b3;
        private System.Windows.Forms.Button btn_a3;
    }
}

