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

                Vector vector1 = new Vector(firstX, firstY, firstZ);
                Vector vector2 = new Vector(secondX, secondY, secondZ);
                Vector vector3;
                double scalyr;

                switch (cm1.Text)
                {
                    case "+":
                        vector3 = vector1 + vector2;
                        txtResult.Text = '[' + vector3.Verbose() + ']';
                        break;
                    case "-":
                        vector3 = vector1 - vector2;
                        txtResult.Text = '[' + vector3.Verbose() + ']';
                        break;
                    case "*":
                        scalyr = vector1 * vector2;
                        txtResult.Text = scalyr.ToString();
                        break;
                    case "&":
                        vector3 = vector1 & vector2;
                        txtResult.Text = '[' + vector3.Verbose() + ']';
                        break;
                    case "len a":
                        txtResult.Text = vector1.Len().ToString();
                        break;
                    case "len b":
                        txtResult.Text = vector2.Len().ToString();
                        break;

                }
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }
        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
