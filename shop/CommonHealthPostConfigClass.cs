using Meropasal;
//namespace MedicareHealthPost.ClassFiles
//{

public  static class CommonHealthPostConfigClass 
    {

        //public static string ServerSettingsXMLFilePath = @"SettingsXMLFiles\ServerSettings.xml";
        public static string CompanyCode;
        public static string CompanyName;
        public static string CompanyAddress;
        public static string CompanyPhoneNum;
        public static string CompanyFinYear;
        public static string LoginedUserName;
        public static string LoginedUserId;
    public static CommonDBClass MainHealthPostDatabase = new CommonDBClass()
    {


        ServerNameAddress = "database.heartsun.com.np,2155",
        ServerLoginUID = "Maskey",
    ServerLoginPassword = "Maskey",
        CompanyDatabase = "MeroPasal"

        //ServerNameAddress = AllFunctionsCommomnClass.GetXmlDocumentNodeValue(FilePath:ServerSettingsXMLFilePath,TagName:"ServerNameAddress"),
        //ServerLoginUID = AllFunctionsCommomnClass.GetXmlDocumentNodeValue(FilePath: ServerSettingsXMLFilePath,TagName:"ServerLoginUID"),
        //ServerLoginPassword = AllFunctionsCommomnClass.GetXmlDocumentNodeValue(FilePath: ServerSettingsXMLFilePath,TagName:"ServerLoginPassword"),
        //CompanyDatabase = "master"

    };


}
//}
