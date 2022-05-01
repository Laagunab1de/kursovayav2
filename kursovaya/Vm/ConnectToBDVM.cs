using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using kursovaya.DTO;
using kursovaya.Vm;
using kursovaya;
using kursovaya.Model;
using kursovaya.Pages;
using kursovaya.Tools;
using MySql.Data.MySqlClient;

namespace kursovaya.Vm
{
    class ConnectToBDVM
    {
        PasswordBox passwordBox;

        public string Server { get; set; }
        public string User { get; set; }
        public string BD { get; set; }

        public Command TestConnectionToBD { get; set; }
        public Command SaveConnect { get; set; }

        public ConnectToBDVM(PasswordBox passwordBox)
        {
            this.passwordBox = passwordBox;

            Server = Properties.Settings.Default.server;
            User = Properties.Settings.Default.user;
            BD = Properties.Settings.Default.BD;
            passwordBox.Password = Properties.Settings.Default.pass;

            TestConnectionToBD = new Command(() => {
                var BD = MySqlDB.GetDB();
                BD.InitConnection(Server, User, this.BD, passwordBox.Password);
                if (BD.OpenConnection())
                {
                    BD.CloseConnection();
                    System.Windows.MessageBox.Show("Соединение успешно!");
                }
            });

            SaveConnect = new Command(() => {
                Properties.Settings.Default.user = User;
                Properties.Settings.Default.BD = BD;
                Properties.Settings.Default.pass = passwordBox.Password;
                Properties.Settings.Default.server = Server;
                Properties.Settings.Default.Save();
                System.Windows.MessageBox.Show("Данные сохранены!");
            });
        }
    }
}
