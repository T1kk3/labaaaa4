using System;
using System.Windows.Forms;

namespace labaaaa4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      textBox2.Text = "Результат: ";
    }

    public static double factorial(double n)
    {
      int r = 1;
      for (int i = 2; r <= n; ++i)
        r *= i;
      return r;
    }

      public double CalcSum(double n)
      {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
        sum += (5 + n) / (factorial(3 * n) - 1);
        }

      textBox2.Text += Environment.NewLine +
      "Результат: " + sum.ToString();
      return sum;
      }

    public double CalcPow(double n)
    {
      double sumpow = 0;
      for (int i = 1; i <= n; i++)
      {
        sumpow += 0.5 * (2 + factorial(0.1));
      }

      textBox2.Text += Environment.NewLine +
      "Результат: " + sumpow.ToString();
      return sumpow;
    }
    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    public void button1_Click(object sender, EventArgs e)
    {

      double n = double.Parse(textBox1.Text);
      textBox2.Text += Environment.NewLine +
      "При n = " + n.ToString();
      int x;
      if (radioButton1.Checked) x = 1; else x = 2;

      switch (x)
      {
        case 1:
          CalcSum(n);
          break;

        case 2:
          CalcPow(n);
          break;

        default:
          break;
      }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
  }
}
