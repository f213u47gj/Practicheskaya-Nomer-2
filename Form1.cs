namespace ZXC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonCalculateLinear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxXLinear.Text) ||
                    string.IsNullOrWhiteSpace(textBoxYLinear.Text) ||
                    string.IsNullOrWhiteSpace(textBoxZLinear.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля для линейного алгоритма.");
                    return;
                }

                double x = Convert.ToDouble(textBoxXLinear.Text);
                double y = Convert.ToDouble(textBoxYLinear.Text);
                double z = Convert.ToDouble(textBoxZLinear.Text);

                double part1 = 3 * Math.Sqrt(8 + Math.Pow(Math.Abs(x - y), 2) + 1) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2);
                double part2 = Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Tan(z) * Math.Tan(z) + 1, x);
                double u = part1 - part2;

                textBoxLinearResult.Text = u.ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных: " + ex.Message);
            }
        }

        private void buttonCalculateBranch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxXBranch.Text) ||
                    string.IsNullOrWhiteSpace(textBoxYBranch.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля для разветвляющегося алгоритма.");
                    return;
                }

                double x = Convert.ToDouble(textBoxXBranch.Text);
                double y = Convert.ToDouble(textBoxYBranch.Text);

                double result;
                double fx;

                if (comboBoxFunction.SelectedItem == null)
                {
                    MessageBox.Show("Выберите функцию f(x).");
                    return;
                }

                if (comboBoxFunction.SelectedItem.ToString() == "cos(x)")
                {
                    fx = Math.Cos(x);
                }
                else if (comboBoxFunction.SelectedItem.ToString() == "x^2")
                {
                    fx = Math.Pow(x, 2);
                }
                else if (comboBoxFunction.SelectedItem.ToString() == "e^x")
                {
                    fx = Math.Exp(x);
                }
                else
                {
                    MessageBox.Show("Некорректный выбор функции.");
                    return;
                }

                if (3 <= x * y && x * y <= 8)
                {
                    result = Math.Abs(Math.Log(Math.Abs(y)) + fx);
                }
                else if (x * y > 12)
                {
                    result = Math.Cos(fx) - y;
                }
                else
                {
                    result = Math.Sinh(fx) + Math.Cos(y);
                }

                textBoxBranchResult.Text = result.ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных: " + ex.Message);
            }
        }
    }
}
