using JenkinsWebApi.Internal;
using System.Xml.Serialization;

#pragma warning disable CS1591

namespace JenkinsWebApi.Model
{
    [SerializableClass("org.jenkinsci.plugins.categorizedview.CategorizedJobsView")]
    [XmlRoot("categorizedJobsView")]
    public partial class JenkinsJenkinsciCategorizedJobsView : JenkinsModelListView
    {
        // empty
    }
}
