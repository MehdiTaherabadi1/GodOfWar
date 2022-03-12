using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UOM.Tests.Acceptance.Hooks
{
    [Binding]
    public class HostingHook
    {
        [BeforeTestRun]
        public static void BeforeTestSuiteRun()
        {

        }

        [AfterTestRun]
        public static void AfterTestSuiteRun()
        {

        }
    }
}
