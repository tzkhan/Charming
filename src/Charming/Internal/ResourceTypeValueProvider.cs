namespace Charming.Internal
{
    using Newtonsoft.Json.Serialization;

    internal class ResourceTypeValueProvider : IValueProvider
    {
        public object? GetValue(object target)
        {
            if (!(target is Resource resource))
            {
                return null;
            }

            if (resource.Parent is null)
            {
                return resource.Type;
            }

            return resource.Type.Replace($"{resource.Parent.Type}/", string.Empty);
        }

        public void SetValue(object target, object? value)
        {
            throw new System.NotImplementedException();
        }
    }
}
