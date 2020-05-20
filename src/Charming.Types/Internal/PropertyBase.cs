namespace Charming.Types.Internal
{
    using System;

    public abstract class PropertyBase
    {
        internal PropertyState State { get; set; }

        internal static void SetProperties<T>(Action<T> setter, T properties)
            where T : PropertyBase
        {
            var state = new PropertyState(properties);

            setter?.Invoke(properties);

            state.Reset();
        }

        protected internal T Get<T>(T property)
            where T : new()
        {
            if (State is { } && property is null)
            {
                property = new T();

                if (property is PropertyBase propertyBase)
                {
                    State.Handle(propertyBase);
                }
            }

            return property;
        }
    }
}
