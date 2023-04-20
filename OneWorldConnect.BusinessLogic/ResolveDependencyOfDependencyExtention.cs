using OneWordConnect.DataAccess;
using Unity;
using Unity.Extension;

namespace OneWorldConnect.BusinessLogic
{
    public class ResolveDependencyOfDependencyExtention : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IPresenterRepository, PresenterRepository>();
            Container.RegisterType<IUserSettingRepository, UserSettingRepository>();
            Container.RegisterType<IDocumentRepository, DocumentRepository>();
        }
    }
}
