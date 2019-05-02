using System;
using System.Windows.Forms;
using HSLibrary;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace Lab2OOP
{
    public partial class Form1 : Form
    {
        Form NewForm;
        int SelIndex;
        Boolean EditObj;
        

        List<Type> list;
        List<object> elements = new List<object>();
        public List<ICreator> itemCreatorList = new List<ICreator>() {
            new ComputerCreator(),
            new LaptopCreator(),
            new SmartCreator(),
            new SmartphoneCreator(),
            new SmartWatchCreator(),
            new TabletCreator(),
            new OwnerCreator()
        };

        public Form1()
        {
            InitializeComponent();
            
            this.Height = 550;
            this.listBox1.Height = 450;
            var ourType = typeof(Device);
            list = Assembly.GetAssembly(ourType).GetTypes().Where(type => type.IsSubclassOf(ourType)).ToList();
            list.Add(typeof(Owner));
            foreach (var item in list)
            {
                  var attributes = item.GetCustomAttributes(inherit: false);
                  foreach (var attribute in attributes)
                  {
                      ChooseDevice.Items.Add(attribute);
                  }
            }
        }

        private void ChooceDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            object obj = itemCreatorList[ChooseDevice.SelectedIndex-1].Create();
            EditObj = false;
            var form = CreateForm();
            NewForm = form;
            CreateElForm(form,obj,EditObj);
        }

        public void but_Click(object sender, EventArgs e)
        {
            bool IsSelect = true;
            object obj;
            Type ChoosenType;
            if (EditObj)
            {
                ChoosenType = elements[SelIndex].GetType();
                obj = elements[SelIndex];
            }
            else
            {
                ChoosenType = GetMyType(ChooseDevice); 
                obj = Activator.CreateInstance(ChoosenType);
            }

            var properties = ChoosenType.GetProperties();
            foreach (var prop in properties.Reverse())
            {
                if (prop.PropertyType.IsClass && (!prop.PropertyType.IsValueType) && (prop.PropertyType != typeof(string)))
                {
                    ComboBox MyCombo = NewForm.Controls["combo" + prop.Name] as ComboBox;
                    if (MyCombo.SelectedItem != null)
                    {
                        List<object> suitableItems = elements.Where(sitem => ((sitem.GetType() == prop.PropertyType) || (sitem.GetType().BaseType == prop.PropertyType))).ToList();
                        prop.SetValue(obj, suitableItems[MyCombo.SelectedIndex]);
                    }
                    else
                        IsSelect = false;
                }
                else
                    if (prop.PropertyType.IsEnum)
                    {
                        ComboBox MyCombo = NewForm.Controls["combo" + prop.Name] as ComboBox;
                        if (MyCombo.SelectedItem != null)
                        {
                            prop.SetValue(obj, MyCombo.SelectedItem);
                        }
                        else
                            IsSelect = false;
                    }
                    else 
                    {
                        TextBox Mybox = NewForm.Controls["edit" + prop.Name] as TextBox;
                        if (Mybox.Text.Length > 0)
                        {
                            if (prop.PropertyType == typeof(string))
                            {
                                prop.SetValue(obj, Mybox.Text);
                            }
                            else if (prop.PropertyType == typeof(double))
                                    prop.SetValue(obj, Convert.ToDouble(Mybox.Text));
                                 else
                                    prop.SetValue(obj, Convert.ToInt32(Mybox.Text));
                            
                        }
                        else
                            IsSelect = false;
                    }
            }

            if (IsSelect)
            {
                if(!EditObj)
                    elements.Add(obj);
                CreateList(elements);
                NewForm.Close();
                butDel.Enabled = true;
                butEd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Fill all fields or enter correct values.");
            }
        }

        private void CreateList(List<object> elements)
        {   
            listBox1.Items.Clear();
            foreach (var item in elements)
            {
                string strinfo = "";
                var properties = item.GetType().GetProperties();
                foreach (var prop in properties.Reverse())
                {
                    prop.GetValue(item);
                    strinfo += prop.Name + " - " + prop.GetValue(item) + ", ";
                }
                listBox1.Items.Add(strinfo);
            }
            
        }

        private void butEd_Click(object sender, EventArgs e)
        {
            SelIndex = listBox1.SelectedIndex;
            if (SelIndex > -1)
            {
                EditObj = true;
                var form = CreateForm();
                NewForm = form;
                CreateElForm(form,elements[SelIndex],EditObj);             
            }
            else
            {
                MessageBox.Show("Choose object to edit.");
            }
            
        }

        private Type GetMyType(ComboBox Combo)
        {
            return list[Combo.SelectedIndex];
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            SelIndex = listBox1.SelectedIndex;
            if (SelIndex > -1)
            {
                Boolean DelFl = true;
                if (elements[SelIndex].GetType() == typeof(Owner))
                {
                    foreach (var item in elements.OfType<Device>())
                    {
                        if (item.Owner == elements[SelIndex])
                        {
                            DelFl = false;
                            MessageBox.Show("You can't delete this object.");
                            break;
                        }
                    }
                }
                
                if (DelFl)
                {
                    elements.RemoveAt(listBox1.SelectedIndex);
                    CreateList(elements);
                    MessageBox.Show("You delete object!");
                }
            }
            else
                MessageBox.Show("Choose object to delete.");
        }
    }
  
}
