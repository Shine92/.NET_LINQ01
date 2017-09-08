using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0908_LINQ01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //Employee emp = new Employee();
            //emp.id = 1;
            //emp.name = "name 1";
            //button1.Text = emp.name.ToString();

            Employee emp = new Employee() { id = 2, name = "name 2" };
            button1.Text = emp.name.ToString();

        }

        private void button2_Click(object sender, EventArgs e) {
            var emp = new { id = 3, name = "name 3" }; //根據資料型態造出var型別
            button2.Text = emp.name.ToString();
            this.Text = emp.GetType().ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            var emp = new[] { //根據資料型態造出var型別
                new { uid = 4,UserName="name 4" },
                new {uid =5,UserName ="name 5"  }
            };
            button3.Text = string.Format("uid: {0} UserName: {1}", emp[0].uid, emp[0].UserName);
            this.Text = emp.GetType().ToString();
        }
    }
    class Employee {
        private int _id;
        public int id {
            set {
                this._id = value;
            }
            get {
                return this._id;
            }
        }

        public string name { get; set; }

    }
}
