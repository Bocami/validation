namespace Bocami.Practices.Validation
{
    public class NullValidator<T> : IValidator<T> 
        where T : class
    {
        public void Validate(T t)
        {
        }
    }
}
