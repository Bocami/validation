namespace Bocami.Practices.Validation
{
    public sealed class NullValidator<T> : IValidator<T> 
        where T : class
    {
        public void Validate(T t)
        {
        }
    }
}
