namespace Calculadora
{


    //El problema que tengo es que una vez puesto el segundo numero, si presionamos sumar otra vez o algun otro tipo
    // de operacion, seguirá añadiendo numeros, hay que desabilitar el boton, o buscar
    // buscar una solucion que suponga (ARREGLADO)
    public partial class Form1 : Form
    {
        string btnValue;

        string firstNumber = "";
        string secondNumber = "";

        bool secondNumbActivate = false;

        string typeOp;
        bool operationGoing = false;

        bool multyDiv = false;

        public void addingNumber()
        {
            if (!secondNumbActivate)
            {
                firstNumber = firstNumber + String.Join("", btnValue);
                labelScreen.Text = firstNumber;
                
            }
            else if (secondNumbActivate)
            {
                secondNumber = secondNumber + String.Join("", btnValue);
                labelScreen.Text = secondNumber;
                
            }

        }

        public void operations()
        {
            secondNumbActivate = true;
            Labelnum1.Text = firstNumber + " " + typeOp + " ";
            labelScreen.Text = "";
            btnValue = "";    
            addingNumber();
            

        }

        public void result()
        {

            decimal total = 0;

            if (string.IsNullOrEmpty(firstNumber))
            {
                firstNumber = "0";
                Labelnum1.Text = firstNumber + " " + typeOp + " " + secondNumber;

            }
            else if (string.IsNullOrEmpty(secondNumber))
            {
                secondNumber = "0";
                Labelnum1.Text = firstNumber + " " + typeOp + " " + secondNumber;
            }
            else if (!string.IsNullOrEmpty(firstNumber) && !string.IsNullOrEmpty(secondNumber))
            {

                switch (typeOp)
                {

                    case "+":
                        total = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                        Labelnum1.Text += secondNumber;
                        firstNumber = total.ToString();
                        secondNumber = "";
                        break;

                    case "-":
                        total = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                        Labelnum1.Text += secondNumber;
                        firstNumber = total.ToString();
                        secondNumber = "";
                        break;

                    case "*":
                        // (ARREGLADO) arreglar cuando le doy a multiplciar al numero, signo, numero....avrias veces


                            total = Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber);
                            Labelnum1.Text += secondNumber;
                            firstNumber = total.ToString();
                            secondNumber = "";
                            multyDiv = true;
                       
                        break;

                    case "/":
                        //(ARREGLADO) arreglar cuando le doy a dividir varias  al numero, signo, numero... veces

                        if (  Convert.ToInt32(secondNumber) != 0) {
                            labelScreen.Text = secondNumber;
                            total = Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber);
                            Labelnum1.Text += secondNumber;
                            firstNumber = total.ToString();
                            secondNumber = "";
                            multyDiv = true;
                        }

                        break;

                }

                labelScreen.Text = Convert.ToString(total);
                operationGoing = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            labelScreen.Text = "";
            secondNumber = "";
            btnValue = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            typeOp = "*";
            operations();
            if (operationGoing == true) { result(); }
            operationGoing = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            labelScreen.Text = "";
            Labelnum1.Text = "";
            secondNumbActivate = false;
            firstNumber = "";
            secondNumber = "";
            btnValue = "";
            multyDiv = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnValue = btn7.Text;
            addingNumber();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnValue = btn8.Text;
            addingNumber();


        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btnValue = btn9.Text;
            addingNumber();





        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnValue = btn4.Text;
            addingNumber();


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnValue = btn5.Text;
            addingNumber();


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnValue = btn6.Text;
            addingNumber();


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnValue = btn1.Text;
            addingNumber();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnValue = btn2.Text;
            addingNumber();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnValue = btn3.Text;
            addingNumber();

        }

        private void btn00_Click(object sender, EventArgs e)
        {
            btnValue = btn00.Text;
            addingNumber();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnValue = btn0.Text;
            addingNumber();

        }

        private void labelScreen_Click(object sender, EventArgs e)
        {

        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool isANumber = int.TryParse(btnValue, out i);

            if (isANumber && !firstNumber.Contains("."))
            {
                btnValue = ".";
                addingNumber();
            } else if (isANumber && !secondNumber.Contains("."))
            {
                btnValue = ".";
                addingNumber();
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
    
            typeOp = "+";
            operations();

                
            if (operationGoing == true) { result();}
            operationGoing = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            result();
            multyDiv = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        { 
            typeOp = "-";
            operations();

            if (operationGoing == true) { result(); }
            operationGoing = true;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            
                typeOp = "/";
                operations();

                if (operationGoing == true) { result(); }
                operationGoing = true;
            
        }
    }
}
