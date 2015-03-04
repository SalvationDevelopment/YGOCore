using System;
using YGOCore.Game.Enums;

namespace YGOCore
{
    public interface IGameWatcher
    {
        /**
         * Start watch
         */
        void Start();

        /**
         * Stop watch
         */
        void Stop();

        /**
         * when converted event string event triggered.
         */
        void onEvent(GameWatchEvent eventType, Object formatParams);
    }
}

