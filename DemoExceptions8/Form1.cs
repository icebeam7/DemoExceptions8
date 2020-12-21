using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExceptions8
{
    public partial class Form1 : Form
    {
        int[] numbers;

        public Form1()
        {
            InitializeComponent();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, z = 0;

            try
            {
                x = int.Parse(Number1Entry.Text);
                y = int.Parse(Number2Entry.Text);

                z = x / y;
            }
            catch(FormatException fe)
            {
                MessageBox.Show("There is an error with the numbers. Please fix it!"); // for users
                MessageBox.Show("Error details: " + fe.Message); // for developers
            }
            catch(DivideByZeroException de)
            {
                MessageBox.Show("The second number can't be zero");
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error happened");
            }

            ResultEntry.Text = z.ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            int m = 0;
            try
            {
                m = numbers[0] * numbers[1];
            }
            catch(NullReferenceException n)
            {
                MessageBox.Show("Initialize the array first");
            }

            ResultEntry.Text = m.ToString();
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numbers != null)
                {
                    numbers[0] = int.Parse(Number1Entry.Text);
                    numbers[1] = int.Parse(Number2Entry.Text);
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            catch(NullReferenceException n)
            {
                MessageBox.Show("You have to initialize the array first!");
                InitializeButton.PerformClick();
                MessageBox.Show("There. I have done it for you!");
            }
            catch (FormatException fe)
            {
                MessageBox.Show("There is an error with the numbers. Please fix it!"); // for users
                MessageBox.Show("Error details: " + fe.Message); // for developers
            }
        }

        private void InitializeButton_Click(object sender, EventArgs e)
        {
            numbers = new int[2];
        }
    }
}
