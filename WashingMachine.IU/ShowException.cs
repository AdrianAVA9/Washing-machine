using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashingMachine.IU
{
    public partial class ShowException : Form
    {
        public string ExceptionName { get; set; }
        public string ExceptionDescription { get; set; }
        public string TypeException { get; set; }
        public static object Background { get; private set; }

        public ShowException()
        {
            InitializeComponent();
        }

        public ShowException(string exceptionName,string exceptionDescription,string typeException)
        {
            this.ExceptionName = exceptionName;
            this.ExceptionDescription = exceptionDescription;
            this.TypeException = typeException;

            InitializeComponent();
        }

        private void ShowException_Load(object sender, EventArgs e)
        {
            changeStyle();
            SetValues();
        }

        private void changeStyle()
        {
            switch (TypeException)
            {
                case "Error":
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
                    break;
                case "Information":
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
                    break;
                case "Success":
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
                    break;
            }
        }

        private void SetValues()
        {
            this.exceptionName.Text = this.ExceptionName;
            this.exceptionDescription.Text = this.ExceptionDescription;
        }

        private void btnClose_Click(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
