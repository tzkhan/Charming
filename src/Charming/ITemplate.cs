namespace Charming
{
    using System.Collections.Generic;

    public interface ITemplate
    {
        string Schema { get; set; }

        string ContentVersion { get; set; }

        IList<IResource> Resources { get; }

        IList<Output> Outputs { get; }
    }
}
