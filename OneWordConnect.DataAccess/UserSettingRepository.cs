using OneWorldConnect.DomainModel;
using System;
using System.Text;
using System.Xml;

namespace OneWordConnect.DataAccess
{
    public class UserSettingRepository : IUserSettingRepository
    {
        public int SaveUerSetting(string ConfigFilePath, UserSetting changeAppSetting)
        {
            try
            {
                System.Xml.Linq.XElement xElement = System.Xml.Linq.XElement.Load(ConfigFilePath);
                var CompanyLogoImagePath = xElement.Element("CompanyLogoImagePath");
                var BackGroundShowImagePath = xElement.Element("BackGroundShowImagePath");
            
                var LoginImagePath = xElement.Element("LoginImagePath");

                BackGroundShowImagePath.Value = changeAppSetting?.UserBackGroundShowImagePath?? BackGroundShowImagePath.Value;
                CompanyLogoImagePath.Value = changeAppSetting?.UserLogoImagePath?? CompanyLogoImagePath.Value;
                LoginImagePath.Value = changeAppSetting?.UserBackgroundLoginImagePath?? LoginImagePath.Value;
                xElement.Save(ConfigFilePath);
            }
            catch(Exception)
            {
                return 0;
            }
            return 1;
        }
    }
}
