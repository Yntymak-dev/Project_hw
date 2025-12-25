using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Notes.Applicationn.Notes.Command.CreateNotes
{
    public class CreateNotesCommands : IRequest<Guid>
    {
        public Guid UserID { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }
    }
}
