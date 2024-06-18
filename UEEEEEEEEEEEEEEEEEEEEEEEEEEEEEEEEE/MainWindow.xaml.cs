using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Identity;
namespace UEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
{
    public partial class MainWindow : Window
    {
        Socket socket;

        public MainWindow()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("26.20.241.147", 8888);
            RecieveMessage();
        }
        private async void SendMessage(string message)
        {
            var bytes = Encoding.UTF8.GetBytes(message);
            await socket.SendAsync(bytes, SocketFlags.None);
            SendMessage(Textik.Text);
        }
        private async void RecieveMessage()
        {
            byte[] bytes = new byte[1024];
            await socket.ReceiveAsync(bytes, SocketFlags.None);
            string message = Encoding.UTF8.GetString(bytes);
            BoxMastersss.Items.Add(message);

        }

    }  
}