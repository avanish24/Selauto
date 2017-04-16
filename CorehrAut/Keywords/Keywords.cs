using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using System.Threading;
using CorehrAut.Interfaces;
using CorehrAut.Configuration;
using System.IO;
using System.Configuration;
using CorehrAut;
namespace CorehrAut
{
   public class Keywords
    {
        
        
        public const string usernameHook = ".aut-input-username";
        public const string passwordHook = ".aut-input-password";
        public const string loginButtonhook = ".aut-button-login";
        public static string coreHrPeoplePageAreaHook = ".aut-area-coreHr";
        public static string addButtonHook = ".aut-button-add";
        public static string employeeFirstNameHook = ".aut-input-xFirstName";
        public static string employeeLastNameHook = ".aut-input-xLastName";
        public static string employeeEmailHook = ".aut-input-xEmail";
        public static string employeeNumberHook = ".aut-input-xEmployeeNumber";
        public static string employementStatusLookupHook = ".aut-input-xEmploymentStatusLookup";
        public static string employeeStartDateHook = ".aut-input-xStartDate";
        public static string employeePositionLookupHook = ".aut-input-xPositionLookup";
        public static string employeeLocationLookupHook = ".aut-input-xLocationLookup";
        public static string employeeRecordStatusLookupHook = ".aut-dropdown-xEmployee-xRecordStatus";
        public static string saveButtonHook = ".aut-button-save";
        public static string activeOptionHook = ".aut-button-activeOption";
        public static string employeeEditHook = ".aut-button-edit";

    }

}
