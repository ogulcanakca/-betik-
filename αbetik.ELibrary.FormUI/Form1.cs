using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using αbetik.ELibrary.Business.Abstract;
using αbetik.ELibrary.Business.Concrete;
using αbetik.ELibrary.DataAccess.Abstract;

namespace αbetik.ELibrary.FormUI
{
    public partial class Form1 : Form
    {
        private IPersonService _personService;
        public Form1(IPersonService personService)
        {
            _personService = personService;
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          var items =  _personService.GetPeople();
            foreach (var item in items)
            {
                label1.Text = item.FirstName;
            }

        }
    }
}
