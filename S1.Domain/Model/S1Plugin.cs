using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace S1.Domain
{
    public class S1Plugin
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Vendor { get; set; }

        /// <summary>
        /// Get plugins from pluginsettings.settings
        /// </summary>
        /// <param name="pluginsSettings"></param>
        /// <returns></returns>
        public static S1Plugin[] GetS1Plugins(string pluginsSettings)
        {
            var ser = new XmlSerializer(typeof(Settings));
            Settings plugins;
            var pluginList = new List<S1Plugin>();
            using (XmlReader reader = XmlReader.Create(pluginsSettings))
            {
                plugins = (Settings)ser.Deserialize(reader);

                foreach (var item in plugins.Section.Where(x => x.Attributes.List != null))
                {
                    try
                    {
                        foreach (var plugin in item.Attributes.List.ClassDescription)
                        {
                            pluginList.Add(new S1Plugin
                            {
                                Id = plugin.classID,
                                Category = plugin.category,
                                SubCategory = plugin.subCategory,
                                Name = plugin.name,
                                Vendor = item.Attributes.Version.vendor
                            });
                        }
                    }
                    catch { }
                }
            }

            return pluginList.ToArray();
        }

        public override string ToString() => $"{Name} - {Category}";
    }
}
