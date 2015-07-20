using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVCSample
{
    public interface IViewMain
    {
        void ShowInvalidState(bool valid);
        
        void Update(IModelMain paramModel);
    }
}
