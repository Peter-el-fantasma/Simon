namespace Simon
{
    partial class Simon
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
            this.components = new System.ComponentModel.Container();
            this.pbRojo = new System.Windows.Forms.PictureBox();
            this.pbAmarillo = new System.Windows.Forms.PictureBox();
            this.pbAzul = new System.Windows.Forms.PictureBox();
            this.pbVerde = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.nvl_1 = new System.Windows.Forms.Label();
            this.nvl_2 = new System.Windows.Forms.Label();
            this.nvl_3 = new System.Windows.Forms.Label();
            this.nvl_4 = new System.Windows.Forms.Label();
            this.lbl_corona = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRojo
            // 
            this.pbRojo.Image = global::Simon.Properties.Resources.Rojo;
            this.pbRojo.Location = new System.Drawing.Point(400, 104);
            this.pbRojo.Margin = new System.Windows.Forms.Padding(4);
            this.pbRojo.Name = "pbRojo";
            this.pbRojo.Size = new System.Drawing.Size(297, 274);
            this.pbRojo.TabIndex = 3;
            this.pbRojo.TabStop = false;
            this.pbRojo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRojo_MouseClick);
            this.pbRojo.MouseEnter += new System.EventHandler(this.pbRojo_MouseEnter);
            this.pbRojo.MouseLeave += new System.EventHandler(this.pbRojo_MouseLeave);
            // 
            // pbAmarillo
            // 
            this.pbAmarillo.Image = global::Simon.Properties.Resources.Amarillo;
            this.pbAmarillo.Location = new System.Drawing.Point(94, 386);
            this.pbAmarillo.Margin = new System.Windows.Forms.Padding(4);
            this.pbAmarillo.Name = "pbAmarillo";
            this.pbAmarillo.Size = new System.Drawing.Size(297, 274);
            this.pbAmarillo.TabIndex = 2;
            this.pbAmarillo.TabStop = false;
            this.pbAmarillo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbAmarillo_MouseClick);
            this.pbAmarillo.MouseEnter += new System.EventHandler(this.pbAmarillo_MouseEnter);
            this.pbAmarillo.MouseLeave += new System.EventHandler(this.pbAmarillo_MouseLeave);
            // 
            // pbAzul
            // 
            this.pbAzul.Image = global::Simon.Properties.Resources.Azul;
            this.pbAzul.Location = new System.Drawing.Point(400, 386);
            this.pbAzul.Margin = new System.Windows.Forms.Padding(4);
            this.pbAzul.Name = "pbAzul";
            this.pbAzul.Size = new System.Drawing.Size(297, 274);
            this.pbAzul.TabIndex = 1;
            this.pbAzul.TabStop = false;
            this.pbAzul.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbAzul_MouseClick);
            this.pbAzul.MouseEnter += new System.EventHandler(this.pbAzul_MouseEnter);
            this.pbAzul.MouseLeave += new System.EventHandler(this.pbAzul_MouseLeave);
            // 
            // pbVerde
            // 
            this.pbVerde.Image = global::Simon.Properties.Resources.Verde;
            this.pbVerde.Location = new System.Drawing.Point(94, 104);
            this.pbVerde.Margin = new System.Windows.Forms.Padding(4);
            this.pbVerde.Name = "pbVerde";
            this.pbVerde.Size = new System.Drawing.Size(297, 274);
            this.pbVerde.TabIndex = 0;
            this.pbVerde.TabStop = false;
            this.pbVerde.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbVerde_MouseClick);
            this.pbVerde.MouseEnter += new System.EventHandler(this.pbVerde_MouseEnter);
            this.pbVerde.MouseLeave += new System.EventHandler(this.pbVerde_MouseLeave);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Himalaya", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_start.Location = new System.Drawing.Point(310, 351);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(166, 71);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // nvl_1
            // 
            this.nvl_1.AutoSize = true;
            this.nvl_1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvl_1.Location = new System.Drawing.Point(249, 20);
            this.nvl_1.Name = "nvl_1";
            this.nvl_1.Size = new System.Drawing.Size(270, 80);
            this.nvl_1.TabIndex = 5;
            this.nvl_1.Text = "NIVEL 1";
            // 
            // nvl_2
            // 
            this.nvl_2.AutoSize = true;
            this.nvl_2.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvl_2.Location = new System.Drawing.Point(249, 20);
            this.nvl_2.Name = "nvl_2";
            this.nvl_2.Size = new System.Drawing.Size(270, 80);
            this.nvl_2.TabIndex = 6;
            this.nvl_2.Text = "NIVEL 2";
            // 
            // nvl_3
            // 
            this.nvl_3.AutoSize = true;
            this.nvl_3.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvl_3.Location = new System.Drawing.Point(249, 20);
            this.nvl_3.Name = "nvl_3";
            this.nvl_3.Size = new System.Drawing.Size(270, 80);
            this.nvl_3.TabIndex = 7;
            this.nvl_3.Text = "NIVEL 3";
            // 
            // nvl_4
            // 
            this.nvl_4.AutoSize = true;
            this.nvl_4.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvl_4.Location = new System.Drawing.Point(249, 20);
            this.nvl_4.Name = "nvl_4";
            this.nvl_4.Size = new System.Drawing.Size(270, 80);
            this.nvl_4.TabIndex = 8;
            this.nvl_4.Text = "NIVEL 4";
            // 
            // lbl_corona
            // 
            this.lbl_corona.AutoSize = true;
            this.lbl_corona.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_corona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_corona.Location = new System.Drawing.Point(12, 592);
            this.lbl_corona.Name = "lbl_corona";
            this.lbl_corona.Size = new System.Drawing.Size(99, 91);
            this.lbl_corona.TabIndex = 9;
            this.lbl_corona.Text = "🜲";
            // 
            // Simon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 692);
            this.Controls.Add(this.lbl_corona);
            this.Controls.Add(this.nvl_4);
            this.Controls.Add(this.nvl_3);
            this.Controls.Add(this.nvl_2);
            this.Controls.Add(this.nvl_1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pbRojo);
            this.Controls.Add(this.pbAmarillo);
            this.Controls.Add(this.pbAzul);
            this.Controls.Add(this.pbVerde);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Simon";
            this.Text = "Simon";
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVerde;
        private System.Windows.Forms.PictureBox pbAzul;
        private System.Windows.Forms.PictureBox pbAmarillo;
        private System.Windows.Forms.PictureBox pbRojo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label nvl_1;
        private System.Windows.Forms.Label nvl_2;
        private System.Windows.Forms.Label nvl_3;
        private System.Windows.Forms.Label nvl_4;
        private System.Windows.Forms.Label lbl_corona;
    }
}

