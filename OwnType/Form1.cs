namespace OwnType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Calculate()
        {
            try
            {
                var firstX = double.Parse(textFirstX.Text);
                var secondX = double.Parse(textSecondX.Text);

                var firstY = double.Parse(textFirstY.Text);
                var secondY = double.Parse(textSecondY.Text);

                var firstZ = double.Parse(textFirstZ.Text);
                var secondZ = double.Parse(textSecondZ.Text);

                double[] vector = new double[3];

                var result = 0.0;

                switch (cm1.Text)
                {
                    case "+":
                        vector[0] = firstX + secondX;
                        vector[1] = firstY + secondY;
                        vector[2] = firstZ + secondZ;
                        txtResult.Text = '[' + vector[0].ToString() + vector[1].ToString() + vector[2].ToString() + ']';
                        break;
                    case "-":
                        vector[0] = firstX - secondX;
                        vector[1] = firstY - secondY;
                        vector[2] = firstZ - secondZ;
                        txtResult.Text = vector[0].ToString() + vector[1].ToString() + vector[2].ToString();
                        break;
                    case "*":
                        result = (firstX * secondX) + (firstY * secondY) + (firstZ * secondZ);
                        break;
                    case "len a":
                        result = Math.Pow(((firstX * firstX) + (firstY * firstY) + (firstZ * firstZ)), 1 / 2);
                        break;
                    case "len b":
                        result = Math.Pow(((secondX * secondX) + (secondY * secondY) + (secondZ * secondZ)), 1 / 2);
                        break;

                }
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFirstX_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textFirstY_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textFirstZ_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textSecondX_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textSecondY_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textSecondZ_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
