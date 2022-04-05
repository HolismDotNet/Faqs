namespace Faqs;

public class Repository
{
    public static Write<Faqs.AnswerContent> AnswerContent
    {
        get
        {
            return new Write<Faqs.AnswerContent>(new FaqsContext());
        }
    }

    public static Write<Faqs.Question> Question
    {
        get
        {
            return new Write<Faqs.Question>(new FaqsContext());
        }
    }
}
