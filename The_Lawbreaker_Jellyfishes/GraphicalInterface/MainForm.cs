using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GraphicalInterface
{
    public partial class MainForm : Form
    {
        MapWorld _w;
        public MainForm()
        {
            InitializeComponent();

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/world.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                _w = (MapWorld)formatter.Deserialize(stream);
            }
            
            World UCW = new World(_w, this, false);
            Controls.Add(UCW);
        }

        public void ChangeUC(UserControl UCI)
        {
            Controls.Clear();
            Controls.Add(UCI);
        }
    }
}
