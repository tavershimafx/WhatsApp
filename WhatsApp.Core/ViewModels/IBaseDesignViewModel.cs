namespace WhatsApp.Core
{
    public interface IBaseDesignViewModel<Model> where Model : class
    {
        static Model Instance { get; set; }
    }
}