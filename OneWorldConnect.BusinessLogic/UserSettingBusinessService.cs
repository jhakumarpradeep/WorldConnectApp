using OneWordConnect.DataAccess;
using OneWorldConnect.DomainModel;

namespace OneWorldConnect.BusinessLogic
{
    public class UserSettingBusinessService : IUserSettingBusinessService
    {
        private readonly IUserSettingRepository _userSettingRepository;
        public UserSettingBusinessService(IUserSettingRepository userSettingRepository)
        {
            _userSettingRepository = userSettingRepository;
        }
        public int SaveUerSetting(string ConfigFilePath, UserSetting changeAppSetting)
        {
            return _userSettingRepository.SaveUerSetting(ConfigFilePath, changeAppSetting);
        }
    }
}
