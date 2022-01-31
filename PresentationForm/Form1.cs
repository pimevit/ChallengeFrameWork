using AppFrameWork.Application;
using AppFramWork.Domain.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationForm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      calculo = new CalculoService();
    }
    ICalculoService calculo;
    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        Clear();
        var divisores = calculo.ObterDivisoresNumero((int)num.Value);
        FillListBox(ltbDivisores, divisores);
        FillListBox(ltbNumPrimos, calculo.ObterNumerosPrimos(divisores));
      }
      catch (Exception ex)
      {
        MessageErro(ex);
      }
    }

    void Clear(bool reset=false)
    {
      ltbNumPrimos.Items.Clear();
      ltbDivisores.Items.Clear();
      if (reset)
        num.Value = 1;
    }
    void FillListBox(ListBox list, List<int> lista)
    {
      lista.ForEach(x => list.Items.Add(x));
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCheckNumPrimo_Click(object sender, EventArgs e)
    {
      try 
      {
        if (calculo.IdentificarNumeroPrimo((int)num.Value))
        {
          MessageBox.Show($"O número {num.Value} é Primo", "É Primo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ltbNumPrimos.Items.Add(num.Value);
        }
        else
          MessageBox.Show($"Desculpe o número {num.Value} não é Primo", "Não é Primo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
      } catch (Exception ex) 
      {
        MessageErro(ex);
      }
    }
    private void MessageErro(Exception e)
    {
      MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void btnFindPrimos_Click(object sender, EventArgs e)
    {
      Clear();

      List<int> numeros = new List<int>();
      for (int i = 2; i < num.Value; i++)
      {
        numeros.Add(i);
      }
      FillListBox(ltbNumPrimos, calculo.ObterNumerosPrimos(numeros));
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      Clear(true);
    }
  }
}
