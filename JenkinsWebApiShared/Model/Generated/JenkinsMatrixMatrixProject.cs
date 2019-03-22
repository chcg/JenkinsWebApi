using System.Xml.Serialization;

#pragma warning disable CS1591

namespace JenkinsWebApi.Model
{
    // hudson.matrix.MatrixProject
    [XmlRoot("matrixProject")]
    public partial class JenkinsMatrixMatrixProject : JenkinsModelAbstractProject
    {
        [XmlElement("activeConfiguration")]
        public JenkinsMatrixMatrixConfiguration[] ActiveConfigurations { get; set; }

    }
}
