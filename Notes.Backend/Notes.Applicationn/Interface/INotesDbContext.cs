using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using notes.domain;

namespace Notes.Applicationn.Interface
{
    public interface INotesDbContext
    {
        DbSet<Note> notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
