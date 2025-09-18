using System;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MergeTextWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool TryGetOperands(out double a, out double b)
        {
            a = b = 0;
            if (!double.TryParse(textBoxA.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out a))
            {
                MessageBox.Show("Неверное число в поле A", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxA.Focus();
                return false;
            }

            if (!double.TryParse(textBoxB.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out b))
            {
                MessageBox.Show("Неверное число в поле B", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxB.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TryGetOperands(out double a, out double b)) return;
            textBoxResult.Text = (a + b).ToString(CultureInfo.CurrentCulture);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!TryGetOperands(out double a, out double b)) return;
            textBoxResult.Text = (a - b).ToString(CultureInfo.CurrentCulture);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (!TryGetOperands(out double a, out double b)) return;
            textBoxResult.Text = (a * b).ToString(CultureInfo.CurrentCulture);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!TryGetOperands(out double a, out double b)) return;
            if (b == 0)
            {
                MessageBox.Show("Деление на ноль невозможно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxB.Focus();
                return;
            }
            textBoxResult.Text = (a / b).ToString(CultureInfo.CurrentCulture);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxResult.Clear();
            textBoxA.Focus();
        }
    }
}
