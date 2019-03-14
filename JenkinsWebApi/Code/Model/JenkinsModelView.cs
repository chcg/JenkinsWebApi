using System.Xml.Serialization;

namespace JenkinsWebApi.Model
{
    // hudson.model.View
    public partial class JenkinsModelView
    {
        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("job")]
        public JenkinsModelJob[] Jobs { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("property")]
        public object[] Propertys { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// Jenkins Java class name.
        /// </summary>
        [XmlAttribute("_class")]
        public string Class { get; set; }
    }
}
