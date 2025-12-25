using Microsoft.EntityFrameworkCore;
using Notes.Applicationn.Interface;
using notes.domain;
using note.presintance.EntityTypeConfiguration;

namespace note.presintance
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NoteTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
