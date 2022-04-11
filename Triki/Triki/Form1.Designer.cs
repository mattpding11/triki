namespace Triki
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
            this.pctPlay = new System.Windows.Forms.PictureBox();
            this.pctPlayer1 = new System.Windows.Forms.PictureBox();
            this.pctPlayer2 = new System.Windows.Forms.PictureBox();
            this.pctGanador = new System.Windows.Forms.PictureBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblFichasJuego = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGanador)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPlay
            // 
            this.pctPlay.BackColor = System.Drawing.Color.Transparent;
            this.pctPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctPlay.Image = global::Triki.Properties.Resources.BOTON_PLAY;
            this.pctPlay.Location = new System.Drawing.Point(734, 520);
            this.pctPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctPlay.Name = "pctPlay";
            this.pctPlay.Size = new System.Drawing.Size(273, 82);
            this.pctPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPlay.TabIndex = 4;
            this.pctPlay.TabStop = false;
            this.pctPlay.Click += new System.EventHandler(this.pctPlay_Click);
            // 
            // pctPlayer1
            // 
            this.pctPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.pctPlayer1.Image = global::Triki.Properties.Resources.f_1;
            this.pctPlayer1.Location = new System.Drawing.Point(640, 95);
            this.pctPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctPlayer1.Name = "pctPlayer1";
            this.pctPlayer1.Size = new System.Drawing.Size(184, 222);
            this.pctPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPlayer1.TabIndex = 1;
            this.pctPlayer1.TabStop = false;
            // 
            // pctPlayer2
            // 
            this.pctPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.pctPlayer2.Image = global::Triki.Properties.Resources.f_2;
            this.pctPlayer2.Location = new System.Drawing.Point(874, 95);
            this.pctPlayer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctPlayer2.Name = "pctPlayer2";
            this.pctPlayer2.Size = new System.Drawing.Size(184, 222);
            this.pctPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPlayer2.TabIndex = 2;
            this.pctPlayer2.TabStop = false;
            // 
            // pctGanador
            // 
            this.pctGanador.BackColor = System.Drawing.Color.Transparent;
            this.pctGanador.Image = global::Triki.Properties.Resources.f_01;
            this.pctGanador.Location = new System.Drawing.Point(1394, 174);
            this.pctGanador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctGanador.Name = "pctGanador";
            this.pctGanador.Size = new System.Drawing.Size(380, 400);
            this.pctGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGanador.TabIndex = 3;
            this.pctGanador.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(657, 322);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(151, 29);
            this.lblPlayer1.TabIndex = 6;
            this.lblPlayer1.Text = "JUGADOR 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(886, 322);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(158, 29);
            this.lblPlayer2.TabIndex = 7;
            this.lblPlayer2.Text = "JUGADOR 2 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1510, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 39);
            this.label6.TabIndex = 10;
            this.label6.Text = "GANADOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(832, 1018);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "TIC TAC TOE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(200, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "TRIKI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(834, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "VS";
            // 
            // tblFichasJuego
            // 
            this.tblFichasJuego.BackColor = System.Drawing.Color.Transparent;
            this.tblFichasJuego.ColumnCount = 3;
            this.tblFichasJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFichasJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFichasJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tblFichasJuego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblFichasJuego.Location = new System.Drawing.Point(18, 95);
            this.tblFichasJuego.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblFichasJuego.Name = "tblFichasJuego";
            this.tblFichasJuego.RowCount = 3;
            this.tblFichasJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFichasJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFichasJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tblFichasJuego.Size = new System.Drawing.Size(525, 538);
            this.tblFichasJuego.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(13, 727);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 60);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Triki.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctPlay);
            this.Controls.Add(this.pctGanador);
            this.Controls.Add(this.pctPlayer2);
            this.Controls.Add(this.pctPlayer1);
            this.Controls.Add(this.tblFichasJuego);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRIKI-HOME-COVID";
            ((System.ComponentModel.ISupportInitialize)(this.pctPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGanador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPlay;
        private System.Windows.Forms.PictureBox pctPlayer1;
        private System.Windows.Forms.PictureBox pctPlayer2;
        private System.Windows.Forms.PictureBox pctGanador;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblFichasJuego;
        private System.Windows.Forms.Button btnSalir;
     
    }
}

