using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCapstoneBGS
{
    public struct LabelStruct
    {

        //LIST OF MESSAGES
        public struct Administrator_Message
        {
            public const string M_AdministratorHomepage = "";
            public const string M_Submitted = "Submitted";
            public const string M_Accepted = "Accepted";
            public const string M_InProgress = "In Progress";
            public const string M_Completed = "Completed";
            public const string M_Rejected = "Rejected";
            public const string M_MonthlyReports = "Monthly Reports";
            public const string M_YearlyReports = "Yearly Reports";
            public const string M_Twitter = "Twitter";
            public const string M_Volunteers = "Volunteers";
        }

        public struct CommunityUser_Message
        {
            public const string M_CommunityUserHomepage = "Community User";
            public const string M_SubmitReport = "Submit Report";
            public const string M_ViewStatus = "View Status";
            public const string M_Achievements = "Achievements";
        }

        //LIST OF TITLE TAGS
        public struct Administrator
        {
            public const string AdministratorHomepage = "Administrator";
            public const string Submitted = "Submitted";
            public const string Accepted = "Accepted";
            public const string InProgress = "In Progress";
            public const string Completed = "Completed";
            public const string Rejected = "Rejected";
            public const string MonthlyReports = "Monthly Reports";
            public const string YearlyReports = "Yearly Reports";
            public const string Twitter = "Twitter";
            public const string Volunteers = "Volunteers";
        }

        public struct CommunityUser
        {
            public const string CommunityUserHomepage = "Community User";
            public const string SubmitReport = "Submit Report";
            public const string ViewStatus = "View Status";
            public const string Achievements = "Achievements";
        }

        public struct Others
        {
            public const string Leaderboards = "Leaderboards";
        }


    }
}