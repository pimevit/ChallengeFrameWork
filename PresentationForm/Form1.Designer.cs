
namespace PresentationForm
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
      this.components = new System.ComponentModel.Container();
      this.btnCalcProva = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.btnCheckNumPrimo = new System.Windows.Forms.Button();
      this.btnFindPrimos = new System.Windows.Forms.Button();
      this.ltbDivisores = new System.Windows.Forms.ListBox();
      this.ltbNumPrimos = new System.Windows.Forms.ListBox();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.num = new System.Windows.Forms.NumericUpDown();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnCalcProva
      // 
      this.btnCalcProva.Location = new System.Drawing.Point(6, 22);
      this.btnCalcProva.Name = "btnCalcProva";
      this.btnCalcProva.Size = new System.Drawing.Size(109, 43);
      this.btnCalcProva.TabIndex = 0;
      this.btnCalcProva.Text = "Calcular Divisores ";
      this.toolTip1.SetToolTip(this.btnCalcProva, "Calcular Divisores e Encontrar Números Primos");
      this.btnCalcProva.UseVisualStyleBackColor = true;
      this.btnCalcProva.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoEllipsis = true;
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(15, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(115, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "Informe o Número:";
      // 
      // btnCheckNumPrimo
      // 
      this.btnCheckNumPrimo.Location = new System.Drawing.Point(141, 22);
      this.btnCheckNumPrimo.Name = "btnCheckNumPrimo";
      this.btnCheckNumPrimo.Size = new System.Drawing.Size(109, 43);
      this.btnCheckNumPrimo.TabIndex = 3;
      this.btnCheckNumPrimo.Text = "Validar Número Primo";
      this.toolTip1.SetToolTip(this.btnCheckNumPrimo, "Verifica se o número Selecionado é primo");
      this.btnCheckNumPrimo.UseVisualStyleBackColor = true;
      this.btnCheckNumPrimo.Click += new System.EventHandler(this.btnCheckNumPrimo_Click);
      // 
      // btnFindPrimos
      // 
      this.btnFindPrimos.Location = new System.Drawing.Point(6, 78);
      this.btnFindPrimos.Name = "btnFindPrimos";
      this.btnFindPrimos.Size = new System.Drawing.Size(109, 41);
      this.btnFindPrimos.TabIndex = 4;
      this.btnFindPrimos.Text = "Encontrar Numeros Primos";
      this.btnFindPrimos.UseVisualStyleBackColor = true;
      this.btnFindPrimos.Click += new System.EventHandler(this.btnFindPrimos_Click);
      // 
      // ltbDivisores
      // 
      this.ltbDivisores.FormattingEnabled = true;
      this.ltbDivisores.ItemHeight = 15;
      this.ltbDivisores.Location = new System.Drawing.Point(11, 52);
      this.ltbDivisores.Name = "ltbDivisores";
      this.ltbDivisores.Size = new System.Drawing.Size(187, 109);
      this.ltbDivisores.TabIndex = 7;
      this.toolTip1.SetToolTip(this.ltbDivisores, "Lista contendo os Divisores");
      // 
      // ltbNumPrimos
      // 
      this.ltbNumPrimos.FormattingEnabled = true;
      this.ltbNumPrimos.ItemHeight = 15;
      this.ltbNumPrimos.Location = new System.Drawing.Point(231, 52);
      this.ltbNumPrimos.Name = "ltbNumPrimos";
      this.ltbNumPrimos.Size = new System.Drawing.Size(179, 109);
      this.ltbNumPrimos.TabIndex = 8;
      this.toolTip1.SetToolTip(this.ltbNumPrimos, "Lista contendo os Números Primos");
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.Text = "Informações:\r\n";
      this.notifyIcon1.Visible = true;
      // 
      // num
      // 
      this.num.Location = new System.Drawing.Point(15, 52);
      this.num.Name = "num";
      this.num.Size = new System.Drawing.Size(120, 23);
      this.num.TabIndex = 9;
      this.toolTip1.SetToolTip(this.num, "Informe / Selecione um número Positivo");
      this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(141, 78);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(111, 41);
      this.button1.TabIndex = 5;
      this.button1.Text = "Limpar";
      this.toolTip1.SetToolTip(this.button1, "Limpar Campos");
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // label2
      // 
      this.label2.AutoEllipsis = true;
      this.label2.AutoSize = true;
      this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(11, 22);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 15);
      this.label2.TabIndex = 10;
      this.label2.Text = "Divisores:";
      this.toolTip1.SetToolTip(this.label2, "Lista contendo os Divisores");
      // 
      // label3
      // 
      this.label3.AutoEllipsis = true;
      this.label3.AutoSize = true;
      this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(231, 22);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(102, 15);
      this.label3.TabIndex = 11;
      this.label3.Text = "Números Primos:";
      this.toolTip1.SetToolTip(this.label3, "Lista contendo os Números Primos");
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.btnCalcProva);
      this.groupBox1.Controls.Add(this.btnCheckNumPrimo);
      this.groupBox1.Controls.Add(this.btnFindPrimos);
      this.groupBox1.Location = new System.Drawing.Point(160, 34);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(258, 127);
      this.groupBox1.TabIndex = 12;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Opções";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ltbNumPrimos);
      this.panel1.Controls.Add(this.ltbDivisores);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 170);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(426, 180);
      this.panel1.TabIndex = 13;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(426, 350);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.num);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalcProva;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnCheckNumPrimo;
    private System.Windows.Forms.Button btnFindPrimos;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.ListBox ltbDivisores;
    private System.Windows.Forms.ListBox ltbNumPrimos;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.NumericUpDown num;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel1;
  }
}

