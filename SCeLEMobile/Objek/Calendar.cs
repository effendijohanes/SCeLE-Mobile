using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Object
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RESPONSE
    {

        private RESPONSEKEY[] sINGLEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("KEY", IsNullable = false)]
        public RESPONSEKEY[] SINGLE
        {
            get
            {
                return this.sINGLEField;
            }
            set
            {
                this.sINGLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RESPONSEKEY
    {

        private RESPONSEKEYMULTIPLE mULTIPLEField;

        private string nameField;

        /// <remarks/>
        public RESPONSEKEYMULTIPLE MULTIPLE
        {
            get
            {
                return this.mULTIPLEField;
            }
            set
            {
                this.mULTIPLEField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RESPONSEKEYMULTIPLE
    {

        private RESPONSEKEYMULTIPLEKEY[] sINGLEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("KEY", IsNullable = false)]
        public RESPONSEKEYMULTIPLEKEY[] SINGLE
        {
            get
            {
                return this.sINGLEField;
            }
            set
            {
                this.sINGLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RESPONSEKEYMULTIPLEKEY
    {

        private RESPONSEKEYMULTIPLEKEYVALUE vALUEField;

        private string nameField;

        /// <remarks/>
        public RESPONSEKEYMULTIPLEKEYVALUE VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RESPONSEKEYMULTIPLEKEYVALUE
    {

        private string nullField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
