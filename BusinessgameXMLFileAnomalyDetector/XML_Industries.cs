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
    public partial class industries
    {

        private industry[] industryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("industry")]
        public industry[] industry
        {
            get
            {
                return this.industryField;
            }
            set
            {
                this.industryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class industry
    {

        private string nameField;

        private decimal priceField;

        private industryCosts costsField;

        private industryRevenue revenueField;

        private industryProduct[] machineryField;

        private industryProduct[] inputField;

        private industryProduct[] outputField;

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
        public industryCosts costs
        {
            get
            {
                return this.costsField;
            }
            set
            {
                this.costsField = value;
            }
        }

        /// <remarks/>
        public industryRevenue revenue
        {
            get
            {
                return this.revenueField;
            }
            set
            {
                this.revenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("product", IsNullable = false)]
        public industryProduct[] machinery
        {
            get
            {
                return this.machineryField;
            }
            set
            {
                this.machineryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("product", IsNullable = false)]
        public industryProduct[] input
        {
            get
            {
                return this.inputField;
            }
            set
            {
                this.inputField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("product", IsNullable = false)]
        public industryProduct[] output
        {
            get
            {
                return this.outputField;
            }
            set
            {
                this.outputField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class industryCosts
    {

        private decimal employeesField;

        private decimal maintenanceField;

        /// <remarks/>
        public decimal employees
        {
            get
            {
                return this.employeesField;
            }
            set
            {
                this.employeesField = value;
            }
        }

        /// <remarks/>
        public decimal maintenance
        {
            get
            {
                return this.maintenanceField;
            }
            set
            {
                this.maintenanceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class industryRevenue
    {

        private decimal salesField;

        /// <remarks/>
        public decimal sales
        {
            get
            {
                return this.salesField;
            }
            set
            {
                this.salesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class industryProduct
    {

        private string nameField;

        private double amountField;

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
