using System;

namespace SimplSockets
{
    /// <summary>
    /// Socket error args.
    /// </summary>
    public class SocketErrorArgs : EventArgs
    {
        /// <summary>
        /// Internal constructor.
        /// </summary>
        public SocketErrorArgs() { }

        /// <summary>
        /// The exception.
        /// </summary>
        public Exception Exception { get; set; }
    }
}

