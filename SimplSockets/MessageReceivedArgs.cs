using System;

namespace SimplSockets
{
    /// <summary>
    /// Message received args.
    /// </summary>
    public class MessageReceivedArgs : EventArgs
    {
        /// <summary>
        /// Internal constructor.
        /// </summary>
        public MessageReceivedArgs() { }

        /// <summary>
        /// The received message.
        /// </summary>
        public ReceivedMessage ReceivedMessage { get; set; }
    }
}

