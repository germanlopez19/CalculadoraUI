using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraUI
{
    public partial class fMain : Form
    {
        private decimal _Operand;
        private string _OperandTxt;
        private string _Operator;

        public fMain()
        {
            InitializeComponent();
            Reset();
        }

        private void SetOperand(string value)
        {
            if(value == "9" || value =="8" || value == "7" || value == "6" || value == "5" || value == "4" || value == "3" || value == "2" || value == "1" || value == "0")
            {
                _OperandTxt += value;
                txtResult.Text = _OperandTxt;
            }
            else if(value == "+" || value== "-" || value == "*" || value == "/")
            {
                _Operator = value;
                _Operand = decimal.Parse(_OperandTxt);
                _OperandTxt = "";
            }
            else if(value == "\b")
            {
                Delete();
            }
            else if(value == "\u001b")
            {
                Reset();
            }
            
        }

        private void Reset()
        {
            _Operand = 0;
            _OperandTxt = "";
            txtResult.Text = "0";
        }

        private void DoOperation()
        {
            decimal result = 0;
            if(_Operator == "+")
            {
                result = _Operand + decimal.Parse(_OperandTxt);
            }
            else if(_Operator == "-")
            {
                result = _Operand - decimal.Parse(_OperandTxt);
            }
            else if (_Operator == "*")
            {
                result = _Operand * decimal.Parse(_OperandTxt);
            }
            else if (_Operator == "/")
            {
                result = _Operand / decimal.Parse(_OperandTxt);
            }
            txtResult.Text = result.ToString();
        }

        private void Delete()
        {
            if (txtResult.Text.Length > 0)
            {
                _OperandTxt = _OperandTxt.Substring(0, _OperandTxt.Length - 1);
                txtResult.Text = _OperandTxt;
            }
            txtResult.Text = "0";
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            SetOperand("4");
        }


        private void btnNumber5_Click(object sender, EventArgs e)
        {
            SetOperand("5");
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            SetOperand("6");
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            SetOperand("7");
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            SetOperand("8");
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            SetOperand("9");
        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            SetOperand("1");
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            SetOperand("2");
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            SetOperand("3");
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            SetOperand("0");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            DoOperation();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetOperand("+");
        }

        private void fMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char keyPressed= e.KeyChar;
            SetOperand(e.KeyChar.ToString());
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            SetOperand("/");
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            SetOperand("*");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            SetOperand("-");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
