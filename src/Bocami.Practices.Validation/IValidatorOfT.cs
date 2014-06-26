namespace Bocami.Practices.Validation
{
    public interface IValidator<T> 
        where T : class
    {
        void Validate(T t);
    }
}
