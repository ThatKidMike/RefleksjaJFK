namespace RefleksjaJFK {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.boxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.boxResults = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.boxArguments = new System.Windows.Forms.TextBox();
            this.lblArguments = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpen.Location = new System.Drawing.Point(39, 28);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(103, 31);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExecute.Location = new System.Drawing.Point(907, 585);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(103, 31);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // boxDescription
            // 
            this.boxDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.boxDescription.Enabled = false;
            this.boxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxDescription.Location = new System.Drawing.Point(675, 137);
            this.boxDescription.Multiline = true;
            this.boxDescription.Name = "boxDescription";
            this.boxDescription.ReadOnly = true;
            this.boxDescription.Size = new System.Drawing.Size(335, 310);
            this.boxDescription.TabIndex = 2;
            this.boxDescription.TextChanged += new System.EventHandler(this.boxDescription_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(672, 117);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // boxResults
            // 
            this.boxResults.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.boxResults.Location = new System.Drawing.Point(39, 489);
            this.boxResults.Name = "boxResults";
            this.boxResults.ReadOnly = true;
            this.boxResults.Size = new System.Drawing.Size(334, 22);
            this.boxResults.TabIndex = 4;
            this.boxResults.TextChanged += new System.EventHandler(this.boxResults_TextChanged);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(36, 469);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(59, 17);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "Results:";
            // 
            // boxArguments
            // 
            this.boxArguments.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.boxArguments.Location = new System.Drawing.Point(39, 425);
            this.boxArguments.Name = "boxArguments";
            this.boxArguments.Size = new System.Drawing.Size(334, 22);
            this.boxArguments.TabIndex = 6;
            this.boxArguments.TextChanged += new System.EventHandler(this.boxArguments_TextChanged);
            this.boxArguments.Enter += new System.EventHandler(this.boxArguments_Enter);
            // 
            // lblArguments
            // 
            this.lblArguments.AutoSize = true;
            this.lblArguments.Location = new System.Drawing.Point(36, 405);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(80, 17);
            this.lblArguments.TabIndex = 7;
            this.lblArguments.Text = "Arguments:";
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeView.Location = new System.Drawing.Point(39, 74);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(334, 309);
            this.treeView.TabIndex = 8;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 663);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.lblArguments);
            this.Controls.Add(this.boxArguments);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.boxResults);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.boxDescription);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox boxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox boxResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox boxArguments;
        private System.Windows.Forms.Label lblArguments;
        private System.Windows.Forms.TreeView treeView;
    }
}

