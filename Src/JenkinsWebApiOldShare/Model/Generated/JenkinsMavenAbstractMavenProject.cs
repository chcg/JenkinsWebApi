using JenkinsWebApi.Internal;
using System.Xml.Serialization;

#pragma warning disable CS1591

namespace JenkinsWebApi.Model
{
    [SerializableClass("hudson.maven.AbstractMavenProject")]
    public partial class JenkinsMavenAbstractMavenProject : JenkinsModelAbstractProject
    {
        // empty
    }
}
