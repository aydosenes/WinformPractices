using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //*******************1.SORU**************************
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();                       //---> rastgele nesnesi
            int row = 4;                                        //---> satır
            int column = 3;                                     //---> sütun

            //int[,] array = new int[row, column];              //---> iki boyutlu dizi

            int[][] arr = new int[row][];                       //---> dizilerden oluşan dizi
            {
                arr[0] = new int[column];
                arr[1] = new int[column];
                arr[2] = new int[column];
                arr[3] = new int[column];


            };
            // this.listBox1.MultiColumn = true; ---> Form1.Designer.cs kismina eklenecek 
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    //array[i, j] = random.Next(1, 9);
                    arr[i][j] = random.Next(1, 9);              //---> 1-9 aralığında rastgele sayı üreterek matrisi doldurur
                }
            }

            int[] max = new int[row];                           //---> her satırdaki en büyük sayıların bilgisini tutmak için dizi
            for (int a = 0; a < row; a++)
            {
                listBox1.Items.Add(" " + arr[a][0] + "   " + arr[a][1] + "   " + arr[a][2]);  //---> yukarıda oluşturduğumuz matrisi listbox'a ekler
                max[a] = arr[a].Max();                          //---> her bir satırdaki en büyük sayıyı bulur
            }
            textBox1.Text = max[0].ToString() + " , " + max[1].ToString() + " , " + max[2].ToString() + " , " + max[3].ToString();  //---> max değerleri textbox'a ekler

        }

        //*******************2.SORU**************************
        private void button2_Click(object sender, EventArgs e)
        {
            double w;
            int limit = 9999;
            int control = 0;
            double[] woodall = new double[limit];
            bool completed = false;
            while(!completed)
            {
                for (int i = 1; i < limit; i++)
                {                    
                    w = (Math.Pow(2, i) * i) - 1;
                    if(w % 3 == 0 && control != 3)
                    {
                        woodall[i - 1] = w;
                        listBox2.Items.Add(woodall[i - 1]);
                        control++;
                    }
                    
                }
                completed = true;
            }
        }
        //*******************3.SORU**************************
        private void button3_Click(object sender, EventArgs e)
        {             
            double x = Convert.ToDouble(textBox2.Text);
            double value = Math.Cos(Math.Log(x));
            label2.Text = value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            double value = Math.Sqrt(Math.Abs(x));
            label2.Text = value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            double y = Convert.ToDouble(textBox3.Text);
            double value = Math.Exp(Math.Pow(x,y));
            label2.Text = value.ToString();

        }
    }
}
