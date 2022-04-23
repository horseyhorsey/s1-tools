[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]

public partial class Settings
{

    private SettingsSection[] sectionField;

    private string nameField;

    private byte versionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Section")]
    public SettingsSection[] Section
    {
        get
        {
            return this.sectionField;
        }
        set
        {
            this.sectionField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SettingsSection
{

    private SettingsSectionAttributes attributesField;

    private string pathField;

    /// <remarks/>
    public SettingsSectionAttributes Attributes
    {
        get
        {
            return this.attributesField;
        }
        set
        {
            this.attributesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string path
    {
        get
        {
            return this.pathField;
        }
        set
        {
            this.pathField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SettingsSectionAttributes
{

    private SettingsSectionAttributesUrl[] urlField;

    private SettingsSectionAttributesDateTime dateTimeField;

    private SettingsSectionAttributesVersion versionField;

    private SettingsSectionAttributesList listField;

    private byte numClassesField;

    private bool numClassesFieldSpecified;

    private byte discardableField;

    private bool discardableFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Url")]
    public SettingsSectionAttributesUrl[] Url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    public SettingsSectionAttributesDateTime DateTime
    {
        get
        {
            return this.dateTimeField;
        }
        set
        {
            this.dateTimeField = value;
        }
    }

    /// <remarks/>
    public SettingsSectionAttributesVersion Version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    public SettingsSectionAttributesList List
    {
        get
        {
            return this.listField;
        }
        set
        {
            this.listField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte numClasses
    {
        get
        {
            return this.numClassesField;
        }
        set
        {
            this.numClassesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool numClassesSpecified
    {
        get
        {
            return this.numClassesFieldSpecified;
        }
        set
        {
            this.numClassesFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte discardable
    {
        get
        {
            return this.discardableField;
        }
        set
        {
            this.discardableField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool discardableSpecified
    {
        get
        {
            return this.discardableFieldSpecified;
        }
        set
        {
            this.discardableFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SettingsSectionAttributesUrl
{

    private byte typeField;

    private string urlField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SettingsSectionAttributesDateTime
{

    private string idField;

    private string timeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "https://www.presonus.software/xml/ccl")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string time
    {
        get
        {
            return this.timeField;
        }
        set
        {
            this.timeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SettingsSectionAttributesVersion
{

    private string idField;

    private string vendorField;

    private string urlField;

    private string versionField;

    private string nameField;

    private string copyrightField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "https://www.presonus.software/xml/ccl")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string vendor
    {
        get
        {
            return this.vendorField;
        }
        set
        {
            this.vendorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string copyright
    {
        get
        {
            return this.copyrightField;
        }
        set
        {
            this.copyrightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SettingsSectionAttributesList
{

    private SettingsSectionAttributesListClassDescription[] classDescriptionField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ClassDescription")]
    public SettingsSectionAttributesListClassDescription[] ClassDescription
    {
        get
        {
            return this.classDescriptionField;
        }
        set
        {
            this.classDescriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "https://www.presonus.software/xml/ccl")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SettingsSectionAttributesListClassDescription
{

    private SettingsSectionAttributesListClassDescriptionPersistentAttributes persistentAttributesField;

    private string classIDField;

    private string categoryField;

    private string nameField;

    private string subCategoryField;

    private string descriptionField;

    /// <remarks/>
    public SettingsSectionAttributesListClassDescriptionPersistentAttributes PersistentAttributes
    {
        get
        {
            return this.persistentAttributesField;
        }
        set
        {
            this.persistentAttributesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classID
    {
        get
        {
            return this.classIDField;
        }
        set
        {
            this.classIDField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string subCategory
    {
        get
        {
            return this.subCategoryField;
        }
        set
        {
            this.subCategoryField = value;
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SettingsSectionAttributesListClassDescriptionPersistentAttributes
{

    private SettingsSectionAttributesListClassDescriptionPersistentAttributesAttribute[] attributeField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Attribute")]
    public SettingsSectionAttributesListClassDescriptionPersistentAttributesAttribute[] Attribute
    {
        get
        {
            return this.attributeField;
        }
        set
        {
            this.attributeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "https://www.presonus.software/xml/ccl")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SettingsSectionAttributesListClassDescriptionPersistentAttributesAttribute
{

    private string idField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
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

