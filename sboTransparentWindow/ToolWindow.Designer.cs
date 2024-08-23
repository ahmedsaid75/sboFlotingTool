namespace sboTransparentWindow
{
    partial class ToolWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.lblForm = new System.Windows.Forms.Label();
            this.txtDocEntry = new System.Windows.Forms.TextBox();
            this.lblDocEntry = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdShow
            // 
            this.cmdShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdShow.BackColor = System.Drawing.SystemColors.Control;
            this.cmdShow.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShow.Location = new System.Drawing.Point(241, 2);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(44, 24);
            this.cmdShow.TabIndex = 50;
            this.cmdShow.Text = "˄˄";
            this.cmdShow.UseVisualStyleBackColor = false;
            this.cmdShow.Click += new System.EventHandler(this.cmdShowJournal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtMode);
            this.groupBox1.Controls.Add(this.lblMode);
            this.groupBox1.Controls.Add(this.txtForm);
            this.groupBox1.Controls.Add(this.lblForm);
            this.groupBox1.Controls.Add(this.txtDocEntry);
            this.groupBox1.Controls.Add(this.lblDocEntry);
            this.groupBox1.Location = new System.Drawing.Point(0, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 104);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // txtMode
            // 
            this.txtMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMode.Location = new System.Drawing.Point(97, 29);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(144, 22);
            this.txtMode.TabIndex = 11;
            this.txtMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(3, 33);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(53, 20);
            this.lblMode.TabIndex = 10;
            this.lblMode.Text = "Mode";
            // 
            // txtForm
            // 
            this.txtForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForm.Location = new System.Drawing.Point(97, 8);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(144, 22);
            this.txtForm.TabIndex = 9;
            this.txtForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.Location = new System.Drawing.Point(3, 12);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(48, 20);
            this.lblForm.TabIndex = 8;
            this.lblForm.Text = "Form";
            // 
            // txtDocEntry
            // 
            this.txtDocEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocEntry.Location = new System.Drawing.Point(97, 50);
            this.txtDocEntry.Name = "txtDocEntry";
            this.txtDocEntry.Size = new System.Drawing.Size(144, 22);
            this.txtDocEntry.TabIndex = 7;
            this.txtDocEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDocEntry
            // 
            this.lblDocEntry.AutoSize = true;
            this.lblDocEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocEntry.Location = new System.Drawing.Point(3, 54);
            this.lblDocEntry.Name = "lblDocEntry";
            this.lblDocEntry.Size = new System.Drawing.Size(78, 20);
            this.lblDocEntry.TabIndex = 6;
            this.lblDocEntry.Text = "DocEntry";
            // 
            // ToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolWindow";
            this.Opacity = 0.35D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SBO Tools";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolWindow_FormClosing);
            this.Load += new System.EventHandler(this.ToolWindow_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ToolWindow_MouseDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtForm;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.TextBox txtDocEntry;
        private System.Windows.Forms.Label lblDocEntry;
    }
}

