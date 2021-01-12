using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public class MethodBox
    {
        public string Name { get; set; }
        public object[] MethodParameters { get; set; }
        public Button but = new Button();

        public MethodBox(string name, object[] methodParameters)
        {
            Name = name;
            MethodParameters = methodParameters;
        }

        public Control Create()
        {
            GroupBox gr = new GroupBox();
            gr.Text = Name;
            Point currentLocation = new Point(0, 0);
            but.Click += new EventHandler(this.but_Click);
            if (MethodParameters.Length == 0)
            {
                but.Text = "Выолнить метод";
                but.Size = new Size(175, but.Height);
                but.Location = new Point(10, 20);
                gr.Size = new Size(but.Width + 25, but.Height + 25);
                gr.Controls.Add(but);
                return gr;
            }
            else
            {
                for (int i = 0; i < MethodParameters.Length; i++)
                {
                    Label temp = new Label();
                    temp.Text = MethodParameters[i].ToString();
                    temp.Location = new Point(20, currentLocation.Y + 50);
                    TextBox propertyBox = new TextBox();
                    propertyBox.Location = new Point(temp.Size.Width + 100, currentLocation.Y + 50);
                    currentLocation = temp.Location;
                    gr.Controls.Add(propertyBox);
                    gr.Controls.Add(temp);
                    gr.Size = new Size(350, propertyBox.Location.Y + 75);
                }
                but.Text = "Выолнить метод";
                but.Size = new Size(175, but.Height);
                but.Location = new Point(gr.Width - but.Size.Width - 35, gr.Height - 35);
                gr.Controls.Add(but);
                return gr;
            }
        }

        public void but_Click(object sender, EventArgs e)
        {
            Console.WriteLine(1);
        }
    }
}
