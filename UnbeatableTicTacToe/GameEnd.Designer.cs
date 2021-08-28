
namespace UnbeatableTicTacToe
{
    partial class GameEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEnd));
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_again = new System.Windows.Forms.Button();
            this.lbl_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(117, 33);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 6;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            // 
            // btn_again
            // 
            this.btn_again.Location = new System.Drawing.Point(15, 33);
            this.btn_again.Name = "btn_again";
            this.btn_again.Size = new System.Drawing.Size(75, 23);
            this.btn_again.TabIndex = 5;
            this.btn_again.Text = "Play again";
            this.btn_again.UseVisualStyleBackColor = true;
            // 
            // lbl_state
            // 
            this.lbl_state.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lbl_state.Location = new System.Drawing.Point(12, 9);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(180, 21);
            this.lbl_state.TabIndex = 4;
            this.lbl_state.Text = "End state goes here";
            this.lbl_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 61);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_again);
            this.Controls.Add(this.lbl_state);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(220, 100);
            this.MinimumSize = new System.Drawing.Size(220, 100);
            this.Name = "GameEnd";
            this.Text = "Game Over";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_again;
        private System.Windows.Forms.Label lbl_state;
    }
}