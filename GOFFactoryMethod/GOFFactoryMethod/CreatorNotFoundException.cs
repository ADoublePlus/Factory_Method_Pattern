namespace factory_method_pattern
{
    using System;

    public class CreatorNotFoundException : Exception
    {
        public CreatorNotFoundException(string message) : base(message) { }
    }
}