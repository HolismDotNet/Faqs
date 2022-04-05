namespace Faqs;

public class Question : IEntity
{
    public Question()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Text { get; set; }

    public dynamic RelatedItems { get; set; }
}
