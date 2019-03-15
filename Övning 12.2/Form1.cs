using System;
using System.Windows.Forms;

namespace Övning_12._2
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private GenerateNumbers genNum = new GenerateNumbers();
        private DrawDiagram diagram = new DrawDiagram();
        private Bubblesort sort = new Bubblesort();

        private int[] values;
        private int minValue = 0;
        private int maxValue = 100;
        private int numValues = 200;

        public Form1 ()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click (object sender, EventArgs e)
        {
            values = genNum.Generate(random, numValues, minValue, maxValue);
            btnSort.Enabled = true;
            Invalidate();
        }

        private void btnSort_Click (object sender, EventArgs e)
        {
            values = sort.Sort(values);
            Invalidate();
        }

        protected override void OnPaint (PaintEventArgs e)
        {
            if (values != null)
            {
                diagram.Paint(values, maxValue, e.Graphics);
            }
        }
    }
}
