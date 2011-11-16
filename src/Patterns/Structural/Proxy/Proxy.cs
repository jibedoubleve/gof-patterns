
namespace Design.Patterns.Structural.Proxy
{
    public class Proxy
    {
        private Feature feature;
        public Proxy(Feature feature)
        {
            this.feature = feature;
        }
        public string GetHello()
        {
            return feature.GetHello();
        }
    }
}
