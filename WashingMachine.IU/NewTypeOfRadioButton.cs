using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashingMachine.IU
{
    class NewTypeOfRadioButton:RadioButton
    {
        public NewTypeOfRadioButton(string name,string text,int positionX,int positionY)
        {

            AutoSize = true;
            FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            Location = new System.Drawing.Point(positionX, positionY);
            Name = name;
            Size = new System.Drawing.Size(58, 24);
            TabStop = true;
            Text = text;
            UseVisualStyleBackColor = true;
        }

        public Color MouseDownBackColor { get; }
    }
}
