using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Logic;

namespace Forms
{
    public partial class Form7 : Form
    {
        private LibraryReflection rfl;
        private Dictionary<Control, Control> propertiesBoxes;
        private string methodName = "";
        private ClassReflection crfl;
        private ClassExample cls;
        private Control methodBox;
        private ClassReflection libRef;
        private ClassExample libExample;
        private bool check = false;
        public Form7()
        {
            InitializeComponent();
            ClassBox.Items.AddRange(Start());
        }
        private string[] Start()
        {
            rfl = new LibraryReflection("Logic.dll", "IEdition");
            Type libType = typeof(NewLibrary);
            libRef = new ClassReflection(libType);
            libExample = new ClassExample(libRef, new object[] { new List<dynamic>() { } });
            return rfl.ClassesList().ToArray(); 
        }

        private void ClassBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PropertiesPanel.Controls.Clear();
            MethodBox.Items.Clear();

            crfl = new ClassReflection(rfl, ClassBox.SelectedItem.ToString());
            string[] methods = crfl.GetClassMethods();
            string[] properties = crfl.GetPropertiesToString();
            Point currentLocation = PropertiesPanel.Location;
            propertiesBoxes = new Dictionary<Control, Control>();
            for (int i = 0; i < properties.Length; i++)
            {
                TextBox propertyBox = new TextBox();
                Label label = new Label();
                label.Text = properties[i];
                label.Location = new Point(0, currentLocation.Y + i * 50);
                propertyBox.Location = new Point(label.Size.Width, currentLocation.Y + i * 50);
                propertiesBoxes.Add(label, propertyBox);
            }
            AddToPanel("PropertiesPanel", propertiesBoxes.Keys.ToArray());
            AddToPanel("PropertiesPanel", propertiesBoxes.Values.ToArray());
            MethodBox.Items.AddRange(methods);
        }
        private void AddToPanel(string name, Control[] objects)
        {
            Control[] panel = Controls.Find(name, true);
            foreach (Control c in objects)
            {
                panel[0].Controls.Add(c);
            }
        }
        private void MethodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParametersPanel.Controls.Clear();
            methodName = MethodBox.SelectedItem.ToString();
            object[] methodParameters = crfl.GetMethodParameters(methodName);
            methodBox = CreateMethodBox(methodName, methodParameters);
            AddToPanel("ParametersPanel", new Control[] { methodBox });
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (cls == null || methodBox == null)
            {
                MessageBox.Show(
                    "Экземпляр не создан",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                object methodResult = null;
                if (methodBox.Text == "AddBook" || methodBox.Text == "RemoveBook")
                {
                    methodResult = libExample.UseMethod(methodBox.Text, new object[] { cls });
                }
                else
                {
                    Control[] textBoxes = methodBox.Controls.Find("parametr", true);
                    Control[] labels = methodBox.Controls.Find("labels", true);
                    List<object> list = new List<object>();

                    for (int i = 0; i < textBoxes.Length; i++)
                    {
                        if (labels[i].Text.Split('.')[0] == "Int32")
                        {
                            list.Add(int.Parse(textBoxes[i].Text));
                        }
                        else
                        {
                            list.Add(textBoxes[i].Text);
                        }
                    }
                    if (check)
                    {
                        methodResult = libExample.UseMethod(methodBox.Text, list.ToArray());
                    }
                    else
                    {
                        methodResult = cls.UseMethod(methodBox.Text, list.ToArray());
                    }
                }
                if (methodResult != null)
                    OutBox.Text = methodResult.ToString();
                if(methodBox.Text == "FindBook")
                {
                    cls = (ClassExample) methodResult;
                }
            }
        }
        private void CreateExampleBut_Click(object sender, EventArgs e)
        {
            if (propertiesBoxes == null)
            {
                MessageBox.Show(
                    "Свойства классов не указаны",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                List<object> properties = new List<object>();
                foreach (KeyValuePair<Control, Control> c in propertiesBoxes)
                {
                    if (c.Key.Text.ToString().Split('.')[1] == "String")
                    {
                        properties.Add(c.Value.Text);
                    }
                    else
                    {
                        properties.Add(int.Parse(c.Value.Text));
                    }
                }
                cls = new ClassExample(crfl, properties.ToArray());
            }
        }
        public Control CreateMethodBox(string name, object[] methodParameters)
        {
            GroupBox gr = new GroupBox();
            gr.Text = name;
            Point currentLocation = new Point(0, 0);
            if (methodParameters.Length == 0)
            {
                RunButton.Text = "Выолнить метод";
                RunButton.Size = new Size(175, RunButton.Height);
                RunButton.Location = new Point(10, 20);
                gr.Size = new Size(RunButton.Width + 25, RunButton.Height + 25);
                gr.Controls.Add(RunButton);
                return gr;
            }
            else
            {
                for (int i = 0; i < methodParameters.Length; i++)
                {
                    Label temp = new Label();
                    temp.Text = methodParameters[i].ToString();
                    temp.Location = new Point(20, currentLocation.Y + 50);
                    temp.Name = "labels";
                    TextBox propertyBox = new TextBox();
                    propertyBox.Name = "parametr";
                    propertyBox.Location = new Point(temp.Size.Width + 100, currentLocation.Y + 50);
                    currentLocation = temp.Location;
                    gr.Controls.Add(propertyBox);
                    gr.Controls.Add(temp);
                    gr.Size = new Size(350, propertyBox.Location.Y + 75);
                }
                RunButton.Text = "Выолнить метод";
                RunButton.Size = new Size(175, RunButton.Height);
                RunButton.Location = new Point(gr.Width - RunButton.Size.Width - 35, gr.Height - 35);
                gr.Controls.Add(RunButton);
                return gr;
            }
        }

        private void RunLibraryBut_Click(object sender, EventArgs e)
        {
            LibMethodsBox.Items.Clear();
            LibPanel.Controls.Clear();
            ParametersPanel.Controls.Clear();

            string[] methods = libRef.GetClassMethods();
            LibMethodsBox.Items.AddRange(methods);
            if (check)
            {
                LibPanel.BackColor = Color.Black;
                ParametersPanel.BackColor = Color.WhiteSmoke;
                check = false;
                CheckerLabel.Text = "false";
            }
            else
            {
                ParametersPanel.BackColor = Color.Black;
                LibPanel.BackColor = Color.WhiteSmoke;
                check = true;
                CheckerLabel.Text = "true";
            }
        }

        private void LibMethodsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LibPanel.Controls.Clear();
            string mName = LibMethodsBox.SelectedItem.ToString();
            object[] methodParameters = libRef.GetMethodParameters(mName);
            methodBox = CreateMethodBox(mName, methodParameters);
            AddToPanel("LibPanel", new Control[] { methodBox });
        }
    }
}
