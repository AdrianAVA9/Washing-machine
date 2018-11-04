using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashingMachine.IU
{
    class NewTypeOfButton:Button
    {

        public NewTypeOfButton(string text, int x, int y, string name)
        {   
            FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            Location = new System.Drawing.Point(x,y);
            Name = name;
            Size = new System.Drawing.Size(215, 30);
            TabIndex = 7;
            Text = text;
            TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            UseVisualStyleBackColor = true;
        }

        private void AddHandler(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
