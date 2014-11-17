using System;
using System.Threading;
using System.Net.Sockets;
using YGOCore;
using System.Net;
using YGOCore.Game;

namespace YGOServer
{
    public class SocketBaseWatcher: IGameWatcher
    {
        private Thread m_watch_thread;
        private TcpListener m_watch_listener;
        public volatile bool IsWatching;
        private Socket m_watch_socket;

        public SocketBaseWatcher(int port)
        {
            m_watch_thread = new Thread(WatchLoop);
            m_watch_listener = new TcpListener(IPAddress.Any, port);
            m_watch_listener.Start(1);
            IsWatching = false;
        }

        public void Start() {
            if (!IsWatching) {
                IsWatching = true;
                try {
                    m_watch_thread.Start();
                } catch (ThreadStateException) {
                    Logger.WriteError("The watch thread has already started.");
                    IsWatching = false;
                    return;
                }
            }
        }

        public void Stop() {
            if (IsWatching) {
                IsWatching = false;
            }
        }

        public void OnEvent(String unicodeStrEvent) {

        }

        private void WatchLoop() {
            while (IsWatching) {
                m_watch_socket = m_watch_listener.AcceptSocket();
                if (m_watch_socket == null)
                {
                    continue;
                }
                foreach (GameRoom room in GameManager.GetRooms())
                {
                }
            }
        }

    }
}

