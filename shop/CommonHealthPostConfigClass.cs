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


        ServerNameAddress = "SULAV\\SQLEXPRESS",
        ServerLoginUID = "sulav",
    ServerLoginPassword = "12345",
        CompanyDatabase = "MeroPasal"

        //ServerNameAddress = AllFunctionsCommomnClass.GetXmlDocumentNodeValue(FilePath:ServerSettingsXMLFilePath,TagName:"ServerNameAddress"),
        //ServerLoginUID = AllFunctionsCommomnClass.GetXmlDocumentNodeValue(FilePath: ServerSettingsXMLFilePath,TagName:"ServerLoginUID"),
        //ServerLoginPassword = AllFunctionsCommomnClass.GetXmlDocumentNodeValue(FilePath: ServerSettingsXMLFilePath,TagName:"ServerLoginPassword"),
        //CompanyDatabase = "master"

    };


}
//}
