using Sitecore.Data;

namespace Tanasuk
{
    public struct Items
    {
        public struct Base
        {
            public static ID TemplateID = ID.Parse("{7C15C1CB-26BB-4BF2-B57A-CB8FD79BCF94}");

            public struct Fields
            {
                public static ID Title = ID.Parse("{3093D42E-4E43-4816-A055-5B50212235F4}");
                public static string Title_FieldName = "Title";
                public static ID Description = ID.Parse("{93A8344A-7489-43C7-ACF1-60B57EB7133C}");
                public static string Description_FieldName = "Description";
                public static ID Banner = ID.Parse("{784A0F02-A048-4197-9A14-52DACD48ECD1}");
                public static string Banner_FieldName = "Banner";
                public static ID IncludeInNavigation = ID.Parse("{D728EFD2-8F40-4476-BCC1-04CE9D159A03}");
                public static string IncludeInNavigation_FieldName = "IncludeInNavigation";
            }
        }
        public struct HomePage
        {
            public static ID TemplateID = ID.Parse("{2BFA853C-85A2-4181-8BB6-5E3B9E08A005}");

            public struct Fields
            {
                public static ID Logo = ID.Parse("{8E87DB10-3C10-4C55-9E88-B87D227FB3BC}");
                public static string Logo_FieldName = "Logo";
                public static ID Title = ID.Parse("{9C291DFE-207F-47D5-9B15-CD7493479802}");
                public static string Title_FieldName = "Title";
                public static ID CopyRights = ID.Parse("{2B4CEE9C-3100-466F-AEE5-B33957E9E554}");
                public static string CopyRights_FieldName = "CopyRights";
            }
        }
        public struct InnerPage
        {
            public static ID TemplateID = ID.Parse("{5090C6F2-F2F4-4222-AF96-D1467C94461B}");

            public struct Fields
            {
                public static ID Thumbnail = ID.Parse("{20DC8CFD-4577-4D03-9DA8-7FB01E1E58C4}");
                public static string Thumbnail_FieldName = "Thumbnail";
                public static ID Link = ID.Parse("{5E9C826E-D0A9-4F16-A82B-3C97D6F1068E}");
                public static string Link_FieldName = "Link";
                public static ID Type = ID.Parse("{6AFC3FCC-05DF-4EE4-A16F-AE9C0AB13561}");
                public static string Type_FieldName = "Type";
            }
        }
    }
}