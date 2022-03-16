using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDeti
{
    public class AnswerEventArgs : EventArgs
    {
        public string Player { get; set; }
        public bool Correct { get; set; }
        public string Team { get; set; }
    }

    public class SocketAnswerEventArgs : EventArgs
    {
        public string Address { get; set; }
        public bool Correct { get; set; }
        public string Team { get; set; }
    }
}
