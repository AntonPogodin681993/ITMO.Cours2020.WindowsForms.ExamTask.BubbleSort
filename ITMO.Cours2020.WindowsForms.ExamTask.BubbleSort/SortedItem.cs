using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace ITMO.Cours2020.WindowsForms.ExamTask.BubleSort
{
    class SortedItem : IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get;private set; }
        public Label Label { get; private set; }

        public int Value { get; private set; }
        public int Number { get; private set; }
        public int StartNumber { get; private set; }

        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            StartNumber = number;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();

            var x = number * 22;

            // 
            // verticalProgressBar1
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = Color.Blue;
            ProgressBar.Location = new Point(x, 3);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "verticalProgressBar1" + number;
            ProgressBar.Size = new Size(23, 161);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            // 
            // label2
            // 
            Label.AutoSize = true;
            Label.Location = new Point(x, 167);
            Label.Name = "label2" + number;
            Label.Size = new Size(24, 17);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
        }

        public void SetPosition(int number)
        {
            Number = number;
            var x = number * 22;
            ProgressBar.Location = new Point(x, 3);
            ProgressBar.Name = "verticalProgressBar1" + number;
            Label.Location = new Point(x, 167);
            Label.Name = "label2" + number;
        }

        public void Refrech()
        {
            Number = StartNumber;
            var x = Number * 22;
            ProgressBar.Location = new Point(x, 3);
            ProgressBar.Name = "verticalProgressBar1" + Number;
            Label.Location = new Point(x, 167);
            Label.Name = "label2" + Number;
        }

        public  void SetColor(Color color)
        {
            ProgressBar.Color = color;
        }

        public int CompareTo (object obj)
        {
            if(obj is SortedItem item)
            {
                return Value.CompareTo(item.Value); 
                
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }

    }
}
