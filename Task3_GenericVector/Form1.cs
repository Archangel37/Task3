using System;
using System.Windows.Forms;

namespace Task3_GenericVector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            richTextBox_result.Text = string.Empty;
            try
            {
                var vec1 = new double[2];
                var vec2 = new double[2];

                //тут не продумывал пока, если ввод будет с двумя пробелами или более 2х значений
                //3е значение после пробела просто игнорируется
                //потестил - обёртки try/catch для многого хватает, проблема возникает только в Convert.ToDouble
                //ну и, собственно всё в try т.к. если не удалось сконвертировать, то и дальше нет смысла выполнять после мессадж-бокса
                var split1 = textBox_v1.Text.Split(' ');
                var split2 = textBox_v2.Text.Split(' ');

                for (var i = 0; i < 2; i++)
                {
                    vec1[i] = Convert.ToDouble(split1[i]);
                    vec2[i] = Convert.ToDouble(split2[i]);
                }

                var vector1 = new Vector(vec1[0], vec1[1]);
                var vector2 = new Vector(vec2[0], vec2[1]);

                richTextBox_result.Text += "Vector operations:" + Environment.NewLine;
                richTextBox_result.Text += "Vector Summ: X(" + GenericVector<Vector, Vector>.Add(vector1, vector2).X +
                                           ") Y(" + GenericVector<Vector, Vector>.Add(vector1, vector2).Y + ")" +
                                           Environment.NewLine;
                richTextBox_result.Text += "Vector Subtraction: X(" +
                                           GenericVector<Vector, Vector>.Subtraction(vector1, vector2).X + ") Y(" +
                                           GenericVector<Vector, Vector>.Subtraction(vector1, vector2).Y + ")" +
                                           Environment.NewLine;
                richTextBox_result.Text += "Compare Vectors: " +
                                           GenericVector<Vector, Vector>.Compare(vector1, vector2) +
                                           Environment.NewLine;
            }
            catch (FormatException ex)
            {
                var errorMessage = ex.Message + Environment.NewLine + Environment.NewLine
                                   + ex.StackTrace + Environment.NewLine + Environment.NewLine
                                   + ex.Source + Environment.NewLine
                                   + ex.Data;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK);
                //тут чисто по-человечески жалко пользователя =))) , но очищаю поля, чтоб заново вводить при ошибочном вводе
                textBox_v1.Text = string.Empty;
                textBox_v2.Text = string.Empty;
            }
        }
    }


    //создадим класс для вектора
    //посчитал, что все векторы начинаются в (0,0) и у них есть только координаты конца (х,у)
    public class Vector
    {
        public double X;
        public double Y;

        //инициализация самого вектора
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        //определим операцию вычисления длины вектора, чтоб в дженерике можно было сравнить длины
        public double Length => Math.Sqrt(X * X + Y * Y);

        //определим оператор сложения двух векторов
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        //определим оператор вычитания двух векторов
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }
    }

    public class GenericVector<T,U>
        where T : Vector
        where U : Vector
    {
        public static Vector Add(Vector v1, Vector v2)
        {
            var result = v1 + v2;
            return result;
        }

        public static Vector Subtraction(Vector v1, Vector v2)
        {
            var result = v1 - v2;
            return result;
        }

        public static string Compare(Vector v1, Vector v2)
        {
            var result = "";
            if (v1.Length > v2.Length)
                result = "length v1 > length v2";
            if (v1.Length < v2.Length)
                result = "length v1 < length v2";
            if (v1.Length == v2.Length)
                result = "length v1 = length v2";
            return result;
        }
    }
}