using System.Windows;

namespace OS_Practice6
{
    partial class Window
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
            button1 = new System.Windows.Forms.Button();
            textMemory = new System.Windows.Forms.RichTextBox();
            textQueue = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(788, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start memory simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textMemory
            // 
            textMemory.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textMemory.ForeColor = System.Drawing.SystemColors.WindowText;
            textMemory.Location = new System.Drawing.Point(88, 262);
            textMemory.MaxLength = 131072;
            textMemory.Name = "textMemory";
            textMemory.ShortcutsEnabled = false;
            textMemory.Size = new System.Drawing.Size(788, 363);
            textMemory.TabIndex = 0;
            textMemory.Text = "";
            // 
            // textQueue
            // 
            textQueue.Location = new System.Drawing.Point(882, 262);
            textQueue.Name = "textQueue";
            textQueue.Size = new System.Drawing.Size(243, 363);
            textQueue.TabIndex = 2;
            textQueue.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(882, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Queue";
            // 
            // Window
            // 
            this.ClientSize = new System.Drawing.Size(1216, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(textQueue);
            this.Controls.Add(textMemory);
            this.Controls.Add(this.button1);
            this.Name = "Window";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Button button1;
        internal static RichTextBox textMemory;
        internal static RichTextBox textQueue;
        private Label label1;
    }
}