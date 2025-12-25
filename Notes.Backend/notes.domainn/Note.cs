using System;
using System.Collections.Generic;
using System.Text;

namespace notes.domain
{
    public class Note
    {
        public Guid UserID { get; set; }

        public Guid ID { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public DateTime DateTime { get; set; }

        public DateTime? EditDate { get; set; }

    }
}
