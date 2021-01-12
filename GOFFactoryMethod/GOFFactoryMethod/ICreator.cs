namespace factory_method_pattern
{
    public interface ICreator<in TSource, out TDestination>
        where TSource : class
        where TDestination : class
    {
        TDestination Create(TSource source);
    }
}