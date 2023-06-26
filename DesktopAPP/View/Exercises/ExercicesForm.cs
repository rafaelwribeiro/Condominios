using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DesktopAPP.View.Exercises
{
    public partial class ExercicesForm : Form
    {
        public ExercicesForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtResult.Clear();
        }

        private void Print(string message)
        {
            txtResult.AppendText(message);
        }

        //Exercício 1
        public int[] ProcessVector(int[] A, int[] B)
        {
            IList<int> result = new List<int>();
            HashSet<int> repeatedElements = new HashSet<int>();

            foreach(int i in A)
                if(!repeatedElements.Contains(i))
                    repeatedElements.Add(i);

            foreach(int i in B)
                if(repeatedElements.Contains(i))
                    result.Add(i);

            return result.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();

            int[] A = new int[] { 02, 04, 06, 08, 10, 12, 14, 16, 18, 20 };
            int[] B = new int[] { 03, 06, 09, 12, 15, 18, 21, 24, 27, 30 };
            int[] result = ProcessVector(A, B);
            foreach(int i in result)
            {
                Print(i.ToString() + ", ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
