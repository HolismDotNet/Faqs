namespace Faqs;

public class AnswerContent : IEntity
{
    public AnswerContent()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Content { get; set; }

    public dynamic RelatedItems { get; set; }
}
