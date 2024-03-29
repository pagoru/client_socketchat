﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace client_socketchat
{
    public class SocketHelper
    {
        public string ServerIp = "localhost";
        public int ServerPort = 55555;

        public string Username { get; set; } = "Default";
        public string Roomname { get; set; } = "Global";

        public TcpClient TcpClient { get; } = new TcpClient();

        public StreamWriter StreamWriter { get; set; }
        public StreamReader StreamReader { get; set; }

        private Thread ReadThread { get; set; }

        public async Task<bool> Connect()
        {
            try
            {
                await TcpClient.ConnectAsync(ServerIp, ServerPort);
                NetworkStream networkStream = TcpClient.GetStream();
                StreamWriter = new StreamWriter(networkStream);
                StreamReader = new StreamReader(networkStream);

                ReadThread = new Thread(ReadFrom);
                ReadThread.Start();

                return true;
            } catch(Exception)
            {
                return false;
            }
        }

        public async Task<int> ChangeRoom(string roomname)
        {
            Roomname = roomname;
            return await SendMessage(new SocketAction(SocketActions.ClientChat, roomname, true));
        }

        public async Task<int> SendChatMessage(string message)
        {
            return await SendMessage(new SocketAction(SocketActions.ClientSendMessage, message, true));
        }

        public async Task<int> Login()
        {
            return await SendMessage(new SocketAction(SocketActions.ClientLogin, Username, true));
        }

        public async Task<int> SendMessage(SocketAction message)
        {
            await StreamWriter.WriteLineAsync(message.Serialize());
            await StreamWriter.FlushAsync();
            return 1;
        }

        public void ReadCallback(string message)
        {
            SocketAction socketAction = SocketAction.Deserialize(message);

            switch (socketAction.SocketActions)
            {
                case SocketActions.ServerLogin:
                    break;
                case SocketActions.ServerSendMessage:
                    AddMessage(socketAction.Message);
                    break;
                case SocketActions.CommandUsuaris:
                    AddMessage($"{Username}, hi ha {socketAction.Message} usuaris conectats.");
                    break;
            }
            Console.WriteLine(message);
        }

        private void AddMessage(string message)
        {
            if (Program.ChatForm.Controls[0].InvokeRequired)
            {
                Program.ChatForm.Controls[0].BeginInvoke((Action)(() => {

                    Program.ChatForm.AddMessage(message);
                }));
                return;
            }
            Program.ChatForm.Focus();
        }

        private void ReadFrom()
        {
            try
            {
                while (true)
                {
                    ReadCallback(StreamReader.ReadLine());
                }
            }
            catch (Exception)
            {

            }
        }

        public void EndConnection()
        {
            ReadThread.Abort();
            TcpClient.Close();
        }
    }
}
