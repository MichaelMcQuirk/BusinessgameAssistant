using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessgameAssistant.ObjectTypes
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class products
    {

        private product[] productField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("product")]
        public product[] product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class product
    {

        private string nameField;

        private decimal priceField;

        private decimal minimumField;

        private decimal maximumField;

        private productHistory historyField;

        /// <remarks/>
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
        public decimal price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public decimal minimum
        {
            get
            {
                return this.minimumField;
            }
            set
            {
                this.minimumField = value;
            }
        }

        /// <remarks/>
        public decimal maximum
        {
            get
            {
                return this.maximumField;
            }
            set
            {
                this.maximumField = value;
            }
        }

        /// <remarks/>
        public productHistory history
        {
            get
            {
                return this.historyField;
            }
            set
            {
                this.historyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class productHistory
    {

        private decimal[] priceField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("price")]
        public decimal[] price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }


}
