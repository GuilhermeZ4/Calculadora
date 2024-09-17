using System.Drawing.Text;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        bool adicao = false, subtracao = false, multiplicacao = false, divisao = false, resultado = false;
        double numero1, numero2;
        int contadorO = 0, numeroBinario;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "1";

            TxtOperacao.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2";

            TxtOperacao.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";

            TxtOperacao.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";

            TxtOperacao.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";

            TxtOperacao.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";

            TxtOperacao.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";

            TxtOperacao.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";

            TxtOperacao.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";

            TxtOperacao.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0";

            TxtOperacao.Text += "0";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (contadorO == 0)
            {
                numero1 = Convert.ToDouble(TxtResultado.Text);

                TxtResultado.Text = "";

                TxtOperacao.Text += "+";

                adicao = true;

                contadorO = 1;
            }
            else
            {
                MessageBox.Show("Opa, parece que já há uma operação sendo feita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (contadorO == 0)
            {
                numero1 = Convert.ToDouble(TxtResultado.Text);

                TxtResultado.Text = "";

                TxtOperacao.Text += "-";

                subtracao = true;

                contadorO = 1;
            }
            else
            {
                MessageBox.Show("Opa, parece que já há uma operação sendo feita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (contadorO == 0)
            {
                numero1 = Convert.ToDouble(TxtResultado.Text);

                TxtResultado.Text = "";

                TxtOperacao.Text += "x";

                multiplicacao = true;

                contadorO = 1;
            }
            else
            {
                MessageBox.Show("Opa, parece que já há uma operação sendo feita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (contadorO == 0)
            {
                numero1 = Convert.ToDouble(TxtResultado.Text);

                TxtResultado.Text = "";

                TxtOperacao.Text += ":";

                divisao = true;

                contadorO = 1;
            }
            else
            {
                MessageBox.Show("Opa, parece que já há uma operação sendo feita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            if (contadorO == 0)
            {
                try
                {
                    numero1 = Convert.ToDouble(TxtResultado.Text);
                    TxtOperacao.Text += "(sin)";

                    double seno;
                    numero1 = (numero1 * (Math.PI)) / 180;
                    seno = Math.Round(Math.Sin(numero1), 2);

                    resultado = true;
                    TxtOperacao.Text += "=" + seno;
                    TxtResultado.Text = Convert.ToString(seno);
                    contadorO = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Opa, valor inserido é nulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Opa, parece que já há uma operação sendo feita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {
            if (contadorO == 0)
            {
                try
                {
                    numero1 = Convert.ToDouble(TxtResultado.Text);
                    TxtOperacao.Text += "(cos)";

                    double cosseno;
                    numero1 = (numero1 * (Math.PI)) / 180;
                    cosseno = Math.Round(Math.Cos(numero1), 2);

                    resultado = true;
                    TxtOperacao.Text += "=" + cosseno;
                    TxtResultado.Text = Convert.ToString(cosseno);
                    contadorO = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Opa, valor inserido é nulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Opa, parece que já há uma operação sendo feita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (contadorO == 0)
            {
                try
                {
                    numero1 = Convert.ToDouble(TxtResultado.Text);
                    TxtOperacao.Text += "(tan)";

                    double tangente;
                    numero1 = (numero1 * (Math.PI)) / 180;
                    tangente = Math.Round(Math.Tan(numero1), 2);

                    resultado = true;
                    TxtOperacao.Text += "=" + tangente;
                    TxtResultado.Text = Convert.ToString(tangente);
                    contadorO = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Opa, valor inserido é nulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Opa, parece que já há uma operação sendo feita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            if (contadorO == 0)
            {
                try
                {
                    numero1 = Convert.ToInt32(TxtResultado.Text);
                    TxtOperacao.Text += "!";

                    int fatorial = 1;

                    for (int i = 1; i <= numero1; i++)
                    {
                        fatorial *= i;
                    }

                    resultado = true;
                    TxtOperacao.Text += "=" + fatorial;
                    TxtResultado.Text = Convert.ToString(fatorial);
                    contadorO = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Opa, valor inserido é nulo ou decimal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Opa, parece que já há uma operação sendo feita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            if (contadorO == 0)
            {
                try
                {
                    numeroBinario = Convert.ToInt32(TxtResultado.Text);
                    TxtOperacao.Text += "(B2)";

                    string binario = "";
                    while (numeroBinario > 0)
                    {
                        int r = numeroBinario % 2;
                        binario = r + binario;
                        numeroBinario /= 2;
                    }

                    resultado = true;
                    TxtOperacao.Text += "=" + binario;
                    TxtResultado.Text = Convert.ToString(binario);
                    contadorO = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Opa, valor inserido é nulo ou decimal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Opa, parece que já há uma operação sendo feita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (contadorO == 1)
                {
                    numero2 = Convert.ToDouble(TxtResultado.Text);

                    if (adicao == true)
                    {
                        TxtResultado.Text = Convert.ToString(numero1 + numero2);
                        adicao = false;
                    }

                    if (subtracao == true)
                    {
                        TxtResultado.Text = Convert.ToString(numero1 - numero2);
                        subtracao = false;
                    }

                    if (multiplicacao == true)
                    {
                        TxtResultado.Text = Convert.ToString(numero1 * numero2);
                        multiplicacao = false;
                    }

                    if (divisao == true)
                    {
                        TxtResultado.Text = Convert.ToString(numero1 / numero2);
                        divisao = false;
                    }

                    contadorO = 0;
                    resultado = true;
                    TxtOperacao.Text += "=";
                    TxtOperacao.Text += TxtResultado.Text;
                }
                else
                {
                    MessageBox.Show("Opa, parece que não há uma operação a ser feita no momento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Opa, parece que não há um número no momento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";

            TxtOperacao.Text = "";
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            try
            {
                string apagarR = TxtResultado.Text;
                string apagarO = TxtOperacao.Text;

                apagarR = apagarR.Remove(apagarR.Length - 1);
                apagarO = apagarO.Remove(apagarO.Length - 1);

                TxtResultado.Text = apagarR;
                TxtOperacao.Text = apagarO;
            }
            catch (Exception)
            {
                MessageBox.Show("Opa, parece que não tem números para serem apagados!");
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {

            int contador = (TxtResultado.Text).Count(c => c == ',');

            if (contador < 1)
            {
                TxtResultado.Text += ",";
                TxtOperacao.Text += ",";
            }
            else
            {
                MessageBox.Show("Opa, parece que já há uma vírgula em seu número!");
            }
        }
    }
}
