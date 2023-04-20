using OneWorldConnect.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWordConnectApp
{
    public static class Initiator
    {
        public static void Init()
        {
            DependencyInjector.Register<IPresenterBusinessLogic, PresenterBusinessLogic>();
            DependencyInjector.Register<IUserSettingBusinessService, UserSettingBusinessService>();
            DependencyInjector.Register<IDocumentBusinesssService, DocumentBusinesssService>();
            DependencyInjector.AddExtension<ResolveDependencyOfDependencyExtention>();
        }
    }
}
