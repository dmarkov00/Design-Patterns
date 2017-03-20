using System;
using System.Windows.Forms;
using VisitorPattern;
namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Chicken chicken = new Chicken();
        Beef beef = new Beef();
        IVisitor visitor;
        private void button1_Click(object sender, EventArgs e)
        {
            visitor = new OvenVisitor();

            listBox1.Items.Add(visitor.Visit(chicken));
            listBox1.Items.Add(visitor.Visit(beef));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            visitor = new PanVisitor();

            listBox1.Items.Add(visitor.Visit(chicken));
            listBox1.Items.Add(visitor.Visit(beef));
        }
    }
}
