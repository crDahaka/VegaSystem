namespace VegaSystem.Resources
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using VegaSystem.Entities;

    public class MakeResource : KeyValuePairResource
    {
        public ICollection<KeyValuePairResource> Models { get; set; }

        public MakeResource()
        {
            Models = new Collection<KeyValuePairResource>();
        }
    }
}