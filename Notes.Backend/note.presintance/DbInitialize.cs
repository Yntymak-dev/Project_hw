using System;
using System.Collections.Generic;
using System.Text;

namespace note.presintance
{
    public class DbInitialize
    {
        public static void Initialize(NotesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
