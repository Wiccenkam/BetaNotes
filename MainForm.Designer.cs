namespace Kursach2
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImport = new System.Windows.Forms.TextBox();
            this.textBoxExport = new System.Windows.Forms.TextBox();
            this.LoadDescription = new System.Windows.Forms.Button();
            this.UpdateNotes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.Label();
            this.OwnerNotes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(91, 236);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 64);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(278, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 100);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxImport
            // 
            this.textBoxImport.Location = new System.Drawing.Point(26, 173);
            this.textBoxImport.Multiline = true;
            this.textBoxImport.Name = "textBoxImport";
            this.textBoxImport.Size = new System.Drawing.Size(304, 324);
            this.textBoxImport.TabIndex = 0;
            // 
            // textBoxExport
            // 
            this.textBoxExport.Location = new System.Drawing.Point(26, 135);
            this.textBoxExport.Multiline = true;
            this.textBoxExport.Name = "textBoxExport";
            this.textBoxExport.Size = new System.Drawing.Size(304, 28);
            this.textBoxExport.TabIndex = 0;
            this.textBoxExport.TextChanged += new System.EventHandler(this.textBoxExport_TextChanged);
            // 
            // LoadDescription
            // 
            this.LoadDescription.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadDescription.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadDescription.ForeColor = System.Drawing.Color.Black;
            this.LoadDescription.Location = new System.Drawing.Point(358, 201);
            this.LoadDescription.Name = "LoadDescription";
            this.LoadDescription.Size = new System.Drawing.Size(225, 43);
            this.LoadDescription.TabIndex = 1;
            this.LoadDescription.Text = "My description";
            this.LoadDescription.UseVisualStyleBackColor = true;
            this.LoadDescription.Click += new System.EventHandler(this.LoadDescription_Click);
            this.LoadDescription.MouseEnter += new System.EventHandler(this.LoadDescription_MouseEnter);
            this.LoadDescription.MouseLeave += new System.EventHandler(this.LoadDescription_MouseLeave);
            // 
            // UpdateNotes
            // 
            this.UpdateNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateNotes.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateNotes.Location = new System.Drawing.Point(358, 135);
            this.UpdateNotes.Name = "UpdateNotes";
            this.UpdateNotes.Size = new System.Drawing.Size(225, 43);
            this.UpdateNotes.TabIndex = 1;
            this.UpdateNotes.Text = "Update Notes";
            this.UpdateNotes.UseVisualStyleBackColor = true;
            this.UpdateNotes.Click += new System.EventHandler(this.UpdateNotes_Click);
            this.UpdateNotes.MouseEnter += new System.EventHandler(this.UpdateNotes_MouseEnter);
            this.UpdateNotes.MouseLeave += new System.EventHandler(this.UpdateNotes_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.ExitLabel);
            this.panel1.Controls.Add(this.Notes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 100);
            this.panel1.TabIndex = 2;
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitLabel.ForeColor = System.Drawing.Color.Red;
            this.ExitLabel.Location = new System.Drawing.Point(566, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(31, 30);
            this.ExitLabel.TabIndex = 3;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.ExitLabel.MouseEnter += new System.EventHandler(this.ExitLabel_MouseEnter);
            this.ExitLabel.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            // 
            // Notes
            // 
            this.Notes.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Notes.Location = new System.Drawing.Point(0, 0);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(609, 100);
            this.Notes.TabIndex = 0;
            this.Notes.Text = "Notes";
            this.Notes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Notes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Notes_MouseDown);
            this.Notes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Notes_MouseMove);
            // 
            // OwnerNotes
            // 
            this.OwnerNotes.AutoSize = true;
            this.OwnerNotes.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnerNotes.Location = new System.Drawing.Point(26, 106);
            this.OwnerNotes.Name = "OwnerNotes";
            this.OwnerNotes.Size = new System.Drawing.Size(47, 15);
            this.OwnerNotes.TabIndex = 3;
            this.OwnerNotes.Text = "label3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(609, 531);
            this.Controls.Add(this.OwnerNotes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpdateNotes);
            this.Controls.Add(this.LoadDescription);
            this.Controls.Add(this.textBoxExport);
            this.Controls.Add(this.textBoxImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImport;
        private System.Windows.Forms.TextBox textBoxExport;
        private System.Windows.Forms.Button LoadDescription;
        private System.Windows.Forms.Button UpdateNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label OwnerNotes;
    }
}