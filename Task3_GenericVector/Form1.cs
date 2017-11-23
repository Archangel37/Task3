using System;
using System.Windows.Forms;

namespace Task3_GenericVector
{
    public partial class Form1 : Form
    {
        public const int Dimension = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            richTextBox_result.Text = string.Empty;
            try
            {
                //FIXED - сократил запись
                var split1 = textBox_v1.Text.Split(' ');
                var split2 = textBox_v2.Text.Split(' ');
                var vec1 = new Vector<double>(Convert.ToDouble(split1[0]), Convert.ToDouble(split1[1]));
                var vec2 = new Vector<double>(Convert.ToDouble(split2[0]), Convert.ToDouble(split2[1]));

                richTextBox_result.Text += Vector<double>.ToStringVec(vec1, vec2);
            }
            catch (FormatException ex)
            {
                //FIXED: -unnecessary strings, + MessageBoxIcon.Error
                var errorMessage = ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //тут чисто по-человечески жалко пользователя =))) , но очищаю поля, чтоб заново вводить при ошибочном вводе
                textBox_v1.Text = string.Empty;
                textBox_v2.Text = string.Empty;
            }
        }
    }

    //3. Написать Generic Vector class, где типом может быть
    //только value значение, надо реализовать операции + - и сравнения.
    //В качестве сравнения использовать длину вектора.Вектор двухмерный. 


    //создадим класс для вектора
    //посчитал, что все векторы начинаются в (0,0) и у них есть только координаты конца (х,у)
    //тут решарпер предлагает ещё Equals и GetHashCode, но для задачи вроде не нужно
    public class Vector<T> 
    {
        public T X;
        public T Y;
  
        //инициализация самого вектора
        public Vector(T x, T y)
        {
            X = x;
            Y = y;
        }

        //определим операцию вычисления длины вектора
        //тут думать!!!
        //подумал.. пока не пришёл к пониманию, как записать короче - динамик тип ругается на попытку, к примеру, сложить его с произведением двух T: res1 +=v.X*v.X
        //т.к. не знает, как перемножить 2 значения T
        public dynamic Length(Vector<T> v)
        {
            dynamic res1 = default(T), res2 = default(T); 
            res1 += v.X; res1 *= v.X;
            res2 += v.Y; res2 *= v.Y;
            res1 += res2;
            res1 = Math.Sqrt(res1);
            return res1;
        }

        //определим оператор сложения двух векторов
        public static Vector<T> operator +(Vector<T> v1, Vector<T> v2)
        {
            dynamic resX = default(T), resY = default(T);
            resX += v1.X; resX += v2.X;
            resY += v1.Y; resY += v2.Y;
            return new Vector<T>(resX, resY);
        }

        //определим оператор вычитания двух векторов
        public static Vector<T> operator -(Vector<T> v1, Vector<T> v2)
        {
            dynamic resX = default(T), resY = default(T);
            resX += v1.X; resX -= v2.X;
            resY += v1.Y; resY -= v2.Y;
            return new Vector<T>(resX, resY);
        }

        //тут для компактности переписал в строку и переписал часть условий, к примеру <= - это !>
        public static bool operator <(Vector<T> v1, Vector<T> v2) { return v1.Length(v1) < v2.Length(v2); }

        public static bool operator >(Vector<T> v1, Vector<T> v2) { return v1.Length(v1) > v2.Length(v2); }
        
        public static bool operator <=(Vector<T> v1, Vector<T> v2) { return !(v1 > v2); }

        public static bool operator >=(Vector<T> v1, Vector<T> v2) { return !(v1 < v2); }

        public static bool operator ==(Vector<T> v1, Vector<T> v2) { return !(v1 > v2) && !(v1 < v2); }

        public static bool operator !=(Vector<T> v1, Vector<T> v2) { return !(v1 == v2); }

        public static string CompareVectors(Vector<T> v1, Vector<T> v2)
        {
            if (v1 > v2)
                return "v1 > v2";
            if (v1 < v2)
                return "v1 < v2";
            return "v1 = v2";
        }

        public static string ToStringVec(Vector<T> v1, Vector<T> v2)
        {
            return "Vector operations:" + Environment.NewLine +
                   "Vector Summ: X(" + (v1 + v2).X + ") Y(" + (v1 + v2).Y + ")" + Environment.NewLine +
                   "Vector Subtraction: X(" + (v1 - v2).X + ") Y(" + (v1 - v2).Y + ")" + Environment.NewLine +
                   "Compare Vectors: " + CompareVectors(v1, v2) + Environment.NewLine;
        }
    }

   
}