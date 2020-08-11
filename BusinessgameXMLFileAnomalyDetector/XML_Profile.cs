
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
    public partial class profile
    {

        private string usernameField;

        private int rankField;

        private string donatorField;

        private profileStorage storageField;

        private profileProduct[] inventoryField;

        private profileIndustry[] industriesField;

        /// <remarks/>
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        public int rank
        {
            get
            {
                return this.rankField;
            }
            set
            {
                this.rankField = value;
            }
        }

        /// <remarks/>
        public string donator
        {
            get
            {
                return this.donatorField;
            }
            set
            {
                this.donatorField = value;
            }
        }

        /// <remarks/>
        public profileStorage storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("product", IsNullable = false)]
        public profileProduct[] inventory
        {
            get
            {
                return this.inventoryField;
            }
            set
            {
                this.inventoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("industry", IsNullable = false)]
        public profileIndustry[] industries
        {
            get
            {
                return this.industriesField;
            }
            set
            {
                this.industriesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class profileStorage
    {

        private double storageSizeField;

        private double warehousesField;

        private double shippingSpeedField;

        private double docksField;

        /// <remarks/>
        public double storageSize
        {
            get
            {
                return this.storageSizeField;
            }
            set
            {
                this.storageSizeField = value;
            }
        }

        /// <remarks/>
        public double warehouses
        {
            get
            {
                return this.warehousesField;
            }
            set
            {
                this.warehousesField = value;
            }
        }

        /// <remarks/>
        public double shippingSpeed
        {
            get
            {
                return this.shippingSpeedField;
            }
            set
            {
                this.shippingSpeedField = value;
            }
        }

        /// <remarks/>
        public double docks
        {
            get
            {
                return this.docksField;
            }
            set
            {
                this.docksField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class profileProduct
    {

        private int idField;

        private string nameField;

        private double amountField;

        /// <remarks/>
        public int id
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
        public double amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class profileIndustry
    {

        private int idField;

        private string nameField;

        private double amountField;

        /// <remarks/>
        public int id
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
        public double amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }


}
