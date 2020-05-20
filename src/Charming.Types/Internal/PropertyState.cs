namespace Charming.Types.Internal
{
    using System.Collections.Generic;

    internal class PropertyState
    {
        private List<PropertyBase> _properties = new List<PropertyBase>();

        public PropertyState(PropertyBase property) => Handle(property);

        public void Handle(PropertyBase property)
        {
            property.State = this;
            _properties.Add(property);
        }

        public void Reset()
        {
            _properties.ForEach(x => x.State = null);
            _properties.Clear();
        }
    }
}
