using AspNetMvcBlog.Models.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMvcBlog.Data.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            ToTable("PostsComments"); // Nome da tabela no banco
            HasKey(x => x.Id); // PK

            Property(x => x.Author)
                .HasMaxLength(100)
                .IsVariableLength()
                .IsRequired();

            Property(x => x.Email)
                .HasMaxLength(100)
                .IsVariableLength()
                .IsRequired();

            Property(x => x.Content)
                .IsMaxLength()
                .IsVariableLength()
                .IsRequired();

            HasRequired(x => x.Post)
                .WithMany(x => x.Comments);
        }
    }
}