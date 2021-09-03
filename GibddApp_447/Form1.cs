using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GibddApp_447
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "192.168.201.12",
                Port = 3306,
                UserID = "testuser",
                Password = "testpass234",
                Database = "testuser_Gibdd447",
                CharacterSet = "utf8"
            };
            Console.WriteLine(builder.ConnectionString);
        }
    }
}
