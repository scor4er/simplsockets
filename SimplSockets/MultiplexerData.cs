using System.Threading;

namespace SimplSockets
{
    /// <summary>
    /// Contains multiplexer data.
    /// </summary>
    public class MultiplexerData
    {
        public byte[] Message { get; set; }
        public ManualResetEvent ManualResetEvent { get; set; }
    }
}
