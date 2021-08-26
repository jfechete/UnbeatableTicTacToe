
namespace UnbeatableTicTacToe
{
    partial class FirstPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPrompt));
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.btn_player = new System.Windows.Forms.Button();
            this.btn_computer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lbl_prompt.Location = new System.Drawing.Point(12, 9);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(180, 21);
            this.lbl_prompt.TabIndex = 1;
            this.lbl_prompt.Text = "Who do you want to go first?";
            this.lbl_prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_player
            // 
            this.btn_player.Location = new System.Drawing.Point(15, 33);
            this.btn_player.Name = "btn_player";
            this.btn_player.Size = new System.Drawing.Size(75, 23);
            this.btn_player.TabIndex = 2;
            this.btn_player.Text = "You";
            this.btn_player.UseVisualStyleBackColor = true;
            // 
            // btn_computer
            // 
            this.btn_computer.Location = new System.Drawing.Point(117, 33);
            this.btn_computer.Name = "btn_computer";
            this.btn_computer.Size = new System.Drawing.Size(75, 23);
            this.btn_computer.TabIndex = 3;
            this.btn_computer.Text = "Computer";
            this.btn_computer.UseVisualStyleBackColor = true;
            // 
            // FirstPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 61);
            this.Controls.Add(this.btn_computer);
            this.Controls.Add(this.btn_player);
            this.Controls.Add(this.lbl_prompt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstPrompt";
            this.Text = "First Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.Button btn_player;
        private System.Windows.Forms.Button btn_computer;
    }
}