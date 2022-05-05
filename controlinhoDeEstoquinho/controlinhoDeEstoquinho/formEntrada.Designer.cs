namespace controlinhoDeEstoquinho
{
    partial class formEntrada
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valorCustoInput = new System.Windows.Forms.TextBox();
            this.nomeInput = new System.Windows.Forms.TextBox();
            this.qtdEntradaInput = new System.Windows.Forms.TextBox();
            this.IdInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.valorVendaInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.qtdEstoqueInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.erro = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 35);
            this.panel2.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 119);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectProduct);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "VALOR DE CUSTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "NOME PRODUTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "QUANTIDADE DA ENTRADA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "VALOR DE VENDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // valorCustoInput
            // 
            this.valorCustoInput.Location = new System.Drawing.Point(454, 94);
            this.valorCustoInput.Name = "valorCustoInput";
            this.valorCustoInput.Size = new System.Drawing.Size(183, 20);
            this.valorCustoInput.TabIndex = 17;
            // 
            // nomeInput
            // 
            this.nomeInput.Location = new System.Drawing.Point(455, 49);
            this.nomeInput.Name = "nomeInput";
            this.nomeInput.Size = new System.Drawing.Size(182, 20);
            this.nomeInput.TabIndex = 16;
            // 
            // qtdEntradaInput
            // 
            this.qtdEntradaInput.Location = new System.Drawing.Point(177, 139);
            this.qtdEntradaInput.Name = "qtdEntradaInput";
            this.qtdEntradaInput.Size = new System.Drawing.Size(167, 20);
            this.qtdEntradaInput.TabIndex = 15;
            // 
            // IdInput
            // 
            this.IdInput.Location = new System.Drawing.Point(177, 49);
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(167, 20);
            this.IdInput.TabIndex = 13;
            this.IdInput.TextChanged += new System.EventHandler(this.searchProduct);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(166, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(490, 46);
            this.label6.TabIndex = 11;
            this.label6.Text = "ENTRADA DE PRODUTO";
            // 
            // valorVendaInput
            // 
            this.valorVendaInput.Location = new System.Drawing.Point(177, 94);
            this.valorVendaInput.Name = "valorVendaInput";
            this.valorVendaInput.Size = new System.Drawing.Size(167, 20);
            this.valorVendaInput.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 130);
            this.panel1.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(22, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // qtdEstoqueInput
            // 
            this.qtdEstoqueInput.Location = new System.Drawing.Point(455, 139);
            this.qtdEstoqueInput.Name = "qtdEstoqueInput";
            this.qtdEstoqueInput.Size = new System.Drawing.Size(183, 20);
            this.qtdEstoqueInput.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "QUANTIDADE ESTOQUE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.erro);
            this.panel3.Controls.Add(this.IdInput);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.valorVendaInput);
            this.panel3.Controls.Add(this.qtdEstoqueInput);
            this.panel3.Controls.Add(this.qtdEntradaInput);
            this.panel3.Controls.Add(this.nomeInput);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.valorCustoInput);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 201);
            this.panel3.TabIndex = 26;
            // 
            // erro
            // 
            this.erro.AutoSize = true;
            this.erro.BackColor = System.Drawing.Color.Transparent;
            this.erro.ForeColor = System.Drawing.Color.Maroon;
            this.erro.Location = new System.Drawing.Point(3, 185);
            this.erro.Name = "erro";
            this.erro.Size = new System.Drawing.Size(0, 13);
            this.erro.TabIndex = 26;
            // 
            // formEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "formEntrada";
            this.Text = "Entrada";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valorCustoInput;
        private System.Windows.Forms.TextBox nomeInput;
        private System.Windows.Forms.TextBox qtdEntradaInput;
        private System.Windows.Forms.TextBox IdInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valorVendaInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox qtdEstoqueInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label erro;
        private System.Windows.Forms.Button button5;
    }
}