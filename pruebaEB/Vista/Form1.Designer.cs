namespace pruebaEB
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
            this.table_personas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table_personas)).BeginInit();
            this.SuspendLayout();
            // 
            // table_personas
            // 
            this.table_personas.AllowUserToDeleteRows = false;
            this.table_personas.AllowUserToOrderColumns = true;
            this.table_personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_personas.Location = new System.Drawing.Point(140, 104);
            this.table_personas.Name = "table_personas";
            this.table_personas.ReadOnly = true;
            this.table_personas.RowTemplate.Height = 25;
            this.table_personas.Size = new System.Drawing.Size(490, 303);
            this.table_personas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table_personas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table_personas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView table_personas;
    }
}