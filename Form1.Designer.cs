using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UdpMonitor
{
    partial class Form1
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
            this._buttonClear = new System.Windows.Forms.Button();
            this._listViewMessages = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // _buttonClear
            // 
            this._buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonClear.Location = new System.Drawing.Point(924, 12);
            this._buttonClear.Name = "_buttonClear";
            this._buttonClear.Size = new System.Drawing.Size(75, 23);
            this._buttonClear.TabIndex = 1;
            this._buttonClear.Text = "Clear";
            this._buttonClear.UseVisualStyleBackColor = true;
            this._buttonClear.Click += new System.EventHandler(this._buttonClear_Click);
            // 
            // _listViewMessages
            // 
            this._listViewMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listViewMessages.Location = new System.Drawing.Point(12, 12);
            this._listViewMessages.Name = "_listViewMessages";
            this._listViewMessages.Size = new System.Drawing.Size(884, 557);
            this._listViewMessages.TabIndex = 2;
            this._listViewMessages.UseCompatibleStateImageBehavior = false;
            this._listViewMessages.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 581);
            this.Controls.Add(this._listViewMessages);
            this.Controls.Add(this._buttonClear);
            this.Name = "Form1";
            this.Text = "UDP Listener";
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Button _buttonClear;
        private System.Windows.Forms.ListView _listViewMessages;
    }
}

