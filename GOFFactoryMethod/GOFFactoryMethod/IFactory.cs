namespace factory_method_pattern
{
    public interface IFactory
    {
        /// <summary>
        /// Creates an instance of type TDestination from an instance of type TSource.
        /// </summary>
        /// <typeparam name="TSource">The type of object from which an instance of TDestination is to be created.</typeparam>
        /// <typeparam name="TDestination">The type of object to be created.</typeparam>
        /// <param name="source"></param>
        /// <exception cref="CreatorNotFoundException">When no suitable creator is found.</exception>
        /// <returns>An instance of type TDestination.</returns>
        TDestination Create<TSource, TDestination>(TSource source)
            where TSource : class
            where TDestination : class;
    }
}