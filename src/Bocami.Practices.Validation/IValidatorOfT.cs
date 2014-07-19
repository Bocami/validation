namespace Bocami.Practices.Validation
{
    public interface IValidator<in T>
    {
        void Validate(T t);
    }
}
