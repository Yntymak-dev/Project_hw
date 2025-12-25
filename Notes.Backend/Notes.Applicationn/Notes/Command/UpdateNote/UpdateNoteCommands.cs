using System;
using MediatR;

namespace Notes.Applicationn.Notes.Command.UpdateNote
{
    public class UpdateNoteCommands : IRequest
    {
        public Guid UserID { get; set; }

        public Guid ID { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }
    }
}
