namespace SageBooksWinForms
{
    public interface IEditModelForm<T> where T : class
    {
        event EventHandler<T> ModelCreatedEvent;
        event EventHandler<T> ModelUpdatedEvent;
        event EventHandler<T> ModelDeletedEvent;

        bool IsEditMode { get; set; }
    }
}
