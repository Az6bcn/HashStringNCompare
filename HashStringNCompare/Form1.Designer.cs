namespace HashStringNCompare
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.stringToHash = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textStringToHash = new System.Windows.Forms.TextBox();
            this.textResultHash = new System.Windows.Forms.TextBox();
            this.btnToHash = new System.Windows.Forms.Button();
            this.btnCompareToHash = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textHashCompare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stringToHash
            // 
            this.stringToHash.AutoSize = true;
            this.stringToHash.Location = new System.Drawing.Point(41, 82);
            this.stringToHash.Name = "stringToHash";
            this.stringToHash.Size = new System.Drawing.Size(70, 13);
            this.stringToHash.TabIndex = 0;
            this.stringToHash.Text = "stringToHash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "resultHash";
            // 
            // textStringToHash
            // 
            this.textStringToHash.Location = new System.Drawing.Point(113, 82);
            this.textStringToHash.Name = "textStringToHash";
            this.textStringToHash.Size = new System.Drawing.Size(256, 20);
            this.textStringToHash.TabIndex = 2;
            // 
            // textResultHash
            // 
            this.textResultHash.Location = new System.Drawing.Point(113, 138);
            this.textResultHash.Name = "textResultHash";
            this.textResultHash.Size = new System.Drawing.Size(256, 20);
            this.textResultHash.TabIndex = 3;
            // 
            // btnToHash
            // 
            this.btnToHash.Location = new System.Drawing.Point(141, 197);
            this.btnToHash.Name = "btnToHash";
            this.btnToHash.Size = new System.Drawing.Size(75, 23);
            this.btnToHash.TabIndex = 4;
            this.btnToHash.Text = "Hash";
            this.btnToHash.UseVisualStyleBackColor = true;
            this.btnToHash.Click += new System.EventHandler(this.btnToHash_Click);
            // 
            // btnCompareToHash
            // 
            this.btnCompareToHash.Location = new System.Drawing.Point(141, 359);
            this.btnCompareToHash.Name = "btnCompareToHash";
            this.btnCompareToHash.Size = new System.Drawing.Size(85, 23);
            this.btnCompareToHash.TabIndex = 5;
            this.btnCompareToHash.Text = "CompareHash";
            this.btnCompareToHash.UseVisualStyleBackColor = true;
            this.btnCompareToHash.Click += new System.EventHandler(this.btnCompareToHash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "newStringToHash";
            // 
            // textHashCompare
            // 
            this.textHashCompare.Location = new System.Drawing.Point(141, 313);
            this.textHashCompare.Name = "textHashCompare";
            this.textHashCompare.Size = new System.Drawing.Size(256, 20);
            this.textHashCompare.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 411);
            this.Controls.Add(this.textHashCompare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCompareToHash);
            this.Controls.Add(this.btnToHash);
            this.Controls.Add(this.textResultHash);
            this.Controls.Add(this.textStringToHash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stringToHash);
            this.Name = "Form1";
            this.Text = "b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stringToHash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textStringToHash;
        private System.Windows.Forms.TextBox textResultHash;
        private System.Windows.Forms.Button btnToHash;
        private System.Windows.Forms.Button btnCompareToHash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textHashCompare;
    }
}

