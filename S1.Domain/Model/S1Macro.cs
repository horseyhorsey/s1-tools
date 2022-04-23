using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace S1.Domain
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Macro
    {

        private MacroCommandElement[] commandElementField;

        private string titleField;

        private string groupField;

        private string descriptionField;

        public override string ToString() => $"{group} - {title}";

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandElement")]
        public MacroCommandElement[] CommandElement
        {
            get
            {
                return this.commandElementField;
            }
            set
            {
                this.commandElementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        public static Macro[] GetS1Macros(string s1DataDir)
        {
            var path = Path.Combine(s1DataDir, "Macros");
            var files = Directory.GetFiles(path, "*.studioonemacro");
            var macros = new List<Macro>();
            foreach (var file in files)
            {
                using (var fs = File.OpenRead(file))
                {
                    var ser = new XmlSerializer(typeof(Macro));
                    using (XmlReader reader = XmlReader.Create(fs))
                    {
                        macros.Add((Macro)ser.Deserialize(reader));
                    }
                }
            }

            return macros.ToArray();
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MacroCommandElement
    {

        private MacroCommandElementCommandArgument[] commandArgumentField;

        private string categoryField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandArgument")]
        public MacroCommandElementCommandArgument[] CommandArgument
        {
            get
            {
                return this.commandArgumentField;
            }
            set
            {
                this.commandArgumentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MacroCommandElementCommandArgument
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
