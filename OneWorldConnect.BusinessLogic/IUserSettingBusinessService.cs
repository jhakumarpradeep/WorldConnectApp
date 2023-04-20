using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorldConnect.BusinessLogic
{
    public interface IUserSettingBusinessService
    {
        int SaveUerSetting(string ConfigFilePath, UserSetting changeAppSetting);
    }
}
