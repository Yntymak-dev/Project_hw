using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using notes.domain;

namespace note.presintance.EntityTypeConfiguration
{
    public class NoteTypeConfiguration : IEntityTypeConfiguration<Note> 
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(note => note.ID);
            builder.HasIndex(note => note.ID).IsUnique();
            builder.Property(note => note.Title).HasMaxLength(250);
        }
    }
}
    