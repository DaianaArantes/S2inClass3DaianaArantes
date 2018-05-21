using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassDog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Dog
        {
            private int age;
            private string name;
            private float weight;

            public int Age { get; set; }
            public string Name { get; set; }
            public float Weight { get; set; }


            public Dog(int _age, float _weight, string _name)
            {
                age = _age;
                weight = _weight;
                name = _name;
            }

            public string Bark()
            {
                return "Woof woof";
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog(Convert.ToInt16(textBoxAge.Text), Convert.ToSingle(textBoxWeight.Text),textBoxName.Text);

            labelResult.Text += "Dog's Data\n\n";
            labelResult.Text += "Dog's Name: " + myDog.Name + "\n\n";
            labelResult.Text += "Dog's Age: " + myDog.Age + "\n\n";
            labelResult.Text += "Dog's Weight: " + myDog.Weight + "\n\n";
            labelResult.Text += "Dog said: " + myDog.Bark() + "\n\n";
        }
    }
}
