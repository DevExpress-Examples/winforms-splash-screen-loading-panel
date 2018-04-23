using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Threading;
using DevExpress.XtraWaitForm;

namespace WaitForm_SetDescription {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        void OnBtnShowWaitFormClick(object sender, EventArgs e) {
            //Open Wait Form
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            try {
                LoadData();
            }
            finally {
                //Close Wait Form
                SplashScreenManager.CloseForm(false);
            }
        }
        void LoadData() {
            gridControl1.DataSource = DataSource.Source;
            Thread.Sleep(4000); // fake delay
        }
    }

    public class DataSource {
        static BindingList<Person> source = null;
        public static BindingList<Person> Source {
            get {
                if(source == null) {
                    source = new BindingList<Person>();
                    source.Add(new Person("John", 10));
                    source.Add(new Person("Jane", 12));
                    source.Add(new Person("Stan", 11));
                    source.Add(new Person("Dan", 13));
                    source.Add(new Person("Molly", 25));
                }
                return source;
            }
        }
    }

    public class Person {
        public Person(string name, int age) {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
