using Bright.Serialization;
using Sirenix.OdinInspector;

namespace Bright.Config
{
    public abstract class BeanBase : SerializedScriptableObject, ITypeId
    {
        public abstract int GetTypeId();
    }
}
