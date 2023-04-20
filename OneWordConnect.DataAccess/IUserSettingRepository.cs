using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWordConnect.DataAccess
{
    public interface IUserSettingRepository
    {
        int SaveUerSetting(string ConfigFilePath, UserSetting changeAppSetting);
    }
}