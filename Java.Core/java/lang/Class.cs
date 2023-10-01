using java.io;
using java.csharp;

namespace java.lang
{
    public class Class
    {

        private ClassResourceLoader _loader;

        public void setResourceLoader(ClassResourceLoader loader)
        {
            this._loader = loader;
        }

        public InputStream getResourceAsStream(String name)
        {
            if (_loader == null) throw new RuntimeException("ClassResourceLoader not set");
            return _loader.getResourceAsStrea(name);
        }
    }
}
