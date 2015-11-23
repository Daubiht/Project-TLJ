using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IGMapEditor;

namespace IGMapEditor
{
    public partial class Map : UserControl
    {
        List<string> IslandName;

        public Map()
        {
            InitializeComponent();
        }

        private void Map_Click(object sender, EventArgs e)
        {
            if (MapEditor.button == 0)
            {
                IslandName.Add(Parent.Parent.Controls.Find("GBProperties", false)[0].Controls.Find("TBElementName", false)[0].Text);
                Console.WriteLine(Parent.Parent.Controls.Find("GBProperties", false)[0].Controls.Find("TBElementName", false)[0].Text);

                Button city = new Button();

               // city.Click += new EventHandler(Menu.City_Click);

                city.Text = Parent.Parent.Controls.Find("GBProperties", false)[0].Controls.Find("TBElementName", false)[0].Text;
                city.Left = this.PointToClient(Cursor.Position).X - city.Width/2;
                city.Top = this.PointToClient(Cursor.Position).Y - city.Height / 2;

                Controls.Add(city);
               
            }
        }

        private void Map_Load(object sender, EventArgs e)
        {
            IslandName = new List<string>();
        }
    }
}
