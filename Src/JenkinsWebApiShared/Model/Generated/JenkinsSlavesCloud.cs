using JenkinsWebApi.Internal;
using System.Xml.Serialization;

#pragma warning disable CS1591

namespace JenkinsWebApi.Model
{
    [SerializableClass("hudson.slaves.Cloud")]
    public partial class JenkinsSlavesCloud : JenkinsModelActionable
    {
        // empty
    }
}
