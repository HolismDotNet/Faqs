namespace Faqs;

public class FaqsContext : DatabaseContext
{
    public override string ConnectionStringName => "Faqs";

    public DbSet<Faqs.AnswerContent> AnswerContents { get; set; }

    public DbSet<Faqs.Question> Questions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
