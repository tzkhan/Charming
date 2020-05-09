namespace Charming
{
    /// <summary>
    /// Marker interface to represent a template function call.
    /// </summary>
    public interface IFunction
    {
        /// <summary>
        /// Generates a string representing the derived function call.
        /// </summary>
        /// <returns>A string representing the derived function call.</returns>
        string Invoke();
    }
}
