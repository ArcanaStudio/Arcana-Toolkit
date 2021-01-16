namespace ArcanaStudio.Toolkit.Functional
{
    public class Option<T>
    {
        public static implicit operator Option<T>(T value) => new Some<T>(value);

        public static implicit operator Option<T>(None none) => new None<T>();
    }
}
