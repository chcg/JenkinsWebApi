using JenkinsWebApi.Internal;
using System.Xml.Serialization;

#pragma warning disable CS1591

namespace JenkinsWebApi.Model
{
    [SerializableClass("hudson.tasks.test.TestResult")]
    public partial class JenkinsTasksTestTestResult : JenkinsTasksTestTestObject
    {
        // empty
    }
}
