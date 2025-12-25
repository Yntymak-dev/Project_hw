using MediatR;
using notes.domain;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Notes.Applicationn.Interface;

namespace Notes.Applicationn.Notes.Command.CreateNotes
{
    public class CreateNotesCommandHandler : IRequestHandler<CreateNotesCommands, Guid>
    {
        public readonly INotesDbContext _dbContext;

        public CreateNotesCommandHandler(INotesDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Guid> Handle(CreateNotesCommands request, CancellationToken cancellationToken)
        {
            var note = new Note
            {
                UserID = request.UserID,
                Title = request.Title,
                Details = request.Details,
                DateTime = DateTime.Now,
                EditDate = null
            };

            await _dbContext.notes.AddAsync(note, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return note.ID;
        }
    }
}
