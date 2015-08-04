using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ids.Common.Idmef
{
    public class IdmefMessage
    {
    }

   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="action-category", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("action-category", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum actioncategory
   {
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("block-installed")]
      blockinstalled,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("notification-sent")]
      notificationsent,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("taken-offline")]
      takenoffline,
      /// 
      other,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="address-category", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("address-category", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum addresscategory
   {
      /// 
      unknown,
      /// 
      atm,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("e-mail")]
      email,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("lotus-notes")]
      lotusnotes,
      /// 
      mac,
      /// 
      sna,
      /// 
      vm,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("ipv4-addr")]
      ipv4addr,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("ipv4-addr-hex")]
      ipv4addrhex,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("ipv4-net")]
      ipv4net,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("ipv4-net-mask")]
      ipv4netmask,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("ipv6-addr")]
      ipv6addr,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("ipv6-addr-hex")]
      ipv6addrhex,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("ipv6-net")]
      ipv6net,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("ipv6-net-mask")]
      ipv6netmask,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="impact-severity", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("impact-severity", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum impactseverity
   {
      /// 
      info,
      /// 
      low,
      /// 
      medium,
      /// 
      high,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="impact-completion", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("impact-completion", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum impactcompletion
   {
      /// 
      failed,
      /// 
      succeeded,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="impact-type", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("impact-type", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum impacttype
   {
      /// 
      admin,
      /// 
      dos,
      /// 
      file,
      /// 
      recon,
      /// 
      user,
      /// 
      other,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="file-category", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("file-category", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum filecategory
   {
      /// 
      current,
      /// 
      original,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="file-permission", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("file-permission", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum filepermission
   {
      /// 
      noAccess,
      /// 
      read,
      /// 
      write,
      /// 
      execute,
      /// 
      search,
      /// 
      delete,
      /// 
      executeAs,
      /// 
      changePermissions,
      /// 
      takeOwnership,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="id-type", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("id-type", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum idtype
   {
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("current-user")]
      currentuser,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("original-user")]
      originaluser,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("target-user")]
      targetuser,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("user-privs")]
      userprivs,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("current-group")]
      currentgroup,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("group-privs")]
      groupprivs,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("other-privs")]
      otherprivs,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="linkage-category", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("linkage-category", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum linkagecategory
   {
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("hard-link")]
      hardlink,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("mount-point")]
      mountpoint,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("reparse-point")]
      reparsepoint,
      /// 
      shortcut,
      /// 
      stream,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("symbolic-link")]
      symboliclink,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="checksum-algorithm", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("checksum-algorithm", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum checksumalgorithm
   {
      /// 
      MD4,
      /// 
      MD5,
      /// 
      SHA1,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("SHA2-256")]
      SHA2256,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("SHA2-384")]
      SHA2384,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("SHA2-512")]
      SHA2512,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("CRC-32")]
      CRC32,
      /// 
      Haval,
      /// 
      Tiger,
      /// 
      Gost,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="node-category", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("node-category", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum nodecategory
   {
      /// 
      unknown,
      /// 
      ads,
      /// 
      afs,
      /// 
      coda,
      /// 
      dfs,
      /// 
      dns,
      /// 
      hosts,
      /// 
      kerberos,
      /// 
      nds,
      /// 
      nis,
      /// 
      nisplus,
      /// 
      nt,
      /// 
      wfw,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="reference-origin", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("reference-origin", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum referenceorigin
   {
      /// 
      unknown,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("vendor-specific")]
      vendorspecific,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("user-specific")]
      userspecific,
      /// 
      bugtraqid,
      /// 
      cve,
      /// 
      osvdb,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="confidence-rating", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("confidence-rating", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum confidencerating
   {
      /// 
      low,
      /// 
      medium,
      /// 
      high,
      /// 
      numeric,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="user-category", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("user-category", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum usercategory
   {
      /// 
      unknown,
      /// 
      application,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("os-device")]
      osdevice,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="additionaldata-type", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("additionaldata-type", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum additionaldatatype
   {
      /// 
      boolean,
      /// 
      @byte,
      /// 
      character,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("date-time")]
      datetime,
      /// 
      integer,
      /// 
      ntpstamp,
      /// 
      portlist,
      /// 
      real,
      /// 
      @string,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("byte-string")]
      bytestring,
      /// 
      xml,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="yes-no-type", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("yes-no-type", Namespace="http://iana.org/idmef", IsNullable=false)]
   public enum yesnotype
   {
      /// 
      unknown,
      /// 
      yes,
      /// 
      no,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="IDMEF-Message", Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute("IDMEF-Message", Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class IDMEFMessage
   {
      private object[] itemsField;
      private decimal versionField;
      private bool versionFieldSpecified;
      public IDMEFMessage()
      {
         this.versionField = ((decimal)(1.0m));
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("Alert", typeof(Alert))]
      [System.Xml.Serialization.XmlElementAttribute("Heartbeat", typeof(Heartbeat))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal version
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
      /// 
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool versionSpecified
      {
         get
         {
            return this.versionFieldSpecified;
         }
         set
         {
            this.versionFieldSpecified = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Alert
   {
      private Analyzer analyzerField;
      private TimeWithNtpstamp createTimeField;
      private TimeWithNtpstamp detectTimeField;
      private TimeWithNtpstamp analyzerTimeField;
      private Source[] sourceField;
      private Target[] targetField;
      private Classification classificationField;
      private Assessment assessmentField;
      private object itemField;
      private AdditionalData[] additionalDataField;
      private string messageidField;
      public Alert()
      {
         this.messageidField = "0";
      }
      /// 
      public Analyzer Analyzer
      {
         get
         {
            return this.analyzerField;
         }
         set
         {
            this.analyzerField = value;
         }
      }
      /// 
      public TimeWithNtpstamp CreateTime
      {
         get
         {
            return this.createTimeField;
         }
         set
         {
            this.createTimeField = value;
         }
      }
      /// 
      public TimeWithNtpstamp DetectTime
      {
         get
         {
            return this.detectTimeField;
         }
         set
         {
            this.detectTimeField = value;
         }
      }
      /// 
      public TimeWithNtpstamp AnalyzerTime
      {
         get
         {
            return this.analyzerTimeField;
         }
         set
         {
            this.analyzerTimeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("Source")]
      public Source[] Source
      {
         get
         {
            return this.sourceField;
         }
         set
         {
            this.sourceField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("Target")]
      public Target[] Target
      {
         get
         {
            return this.targetField;
         }
         set
         {
            this.targetField = value;
         }
      }
      /// 
      public Classification Classification
      {
         get
         {
            return this.classificationField;
         }
         set
         {
            this.classificationField = value;
         }
      }
      /// 
      public Assessment Assessment
      {
         get
         {
            return this.assessmentField;
         }
         set
         {
            this.assessmentField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("CorrelationAlert", typeof(CorrelationAlert))]
      [System.Xml.Serialization.XmlElementAttribute("OverflowAlert", typeof(OverflowAlert))]
      [System.Xml.Serialization.XmlElementAttribute("ToolAlert", typeof(ToolAlert))]
      public object Item
      {
         get
         {
            return this.itemField;
         }
         set
         {
            this.itemField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("AdditionalData")]
      public AdditionalData[] AdditionalData
      {
         get
         {
            return this.additionalDataField;
         }
         set
         {
            this.additionalDataField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string messageid
      {
         get
         {
            return this.messageidField;
         }
         set
         {
            this.messageidField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Analyzer
   {
      private Node nodeField;
      private Process processField;
      private Analyzer analyzer1Field;
      private string analyzeridField;
      private string nameField;
      private string manufacturerField;
      private string modelField;
      private string versionField;
      private string classField;
      private string ostypeField;
      private string osversionField;
      public Analyzer()
      {
         this.analyzeridField = "0";
      }
      /// 
      public Node Node
      {
         get
         {
            return this.nodeField;
         }
         set
         {
            this.nodeField = value;
         }
      }
      /// 
      public Process Process
      {
         get
         {
            return this.processField;
         }
         set
         {
            this.processField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("Analyzer")]
      public Analyzer Analyzer1
      {
         get
         {
            return this.analyzer1Field;
         }
         set
         {
            this.analyzer1Field = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string analyzerid
      {
         get
         {
            return this.analyzeridField;
         }
         set
         {
            this.analyzeridField = value;
         }
      }
      /// 
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
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string manufacturer
      {
         get
         {
            return this.manufacturerField;
         }
         set
         {
            this.manufacturerField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string model
      {
         get
         {
            return this.modelField;
         }
         set
         {
            this.modelField = value;
         }
      }
      /// 
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
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string @class
      {
         get
         {
            return this.classField;
         }
         set
         {
            this.classField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string ostype
      {
         get
         {
            return this.ostypeField;
         }
         set
         {
            this.ostypeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string osversion
      {
         get
         {
            return this.osversionField;
         }
         set
         {
            this.osversionField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Node
   {
      private string locationField;
      private object itemField;
      private Address[] addressField;
      private string identField;
      private nodecategory categoryField;
      public Node()
      {
         this.identField = "0";
         this.categoryField = nodecategory.unknown;
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute(Order=0)]
      public string location
      {
         get
         {
            return this.locationField;
         }
         set
         {
            this.locationField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("Address", typeof(Address), Order=1)]
      [System.Xml.Serialization.XmlElementAttribute("name", typeof(string), Order=1)]
      public object Item
      {
         get
         {
            return this.itemField;
         }
         set
         {
            this.itemField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("Address", Order=2)]
      public Address[] Address
      {
         get
         {
            return this.addressField;
         }
         set
         {
            this.addressField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string ident
      {
         get
         {
            return this.identField;
         }
         set
         {
            this.identField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(nodecategory.unknown)]
      public nodecategory category
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
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Address
   {
      private string addressField;
      private string netmaskField;
      private string identField;
      private addresscategory categoryField;
      private string vlannameField;
      private string vlannumField;
      public Address()
      {
         this.identField = "0";
         this.categoryField = addresscategory.unknown;
      }
      /// 
      public string address
      {
         get
         {
            return this.addressField;
         }
         set
         {
            this.addressField = value;
         }
      }
      /// 
      public string netmask
      {
         get
         {
            return this.netmaskField;
         }
         set
         {
            this.netmaskField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string ident
      {
         get
         {
            return this.identField;
         }
         set
         {
            this.identField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(addresscategory.unknown)]
      public addresscategory category
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
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute("vlan-name")]
      public string vlanname
      {
         get
         {
            return this.vlannameField;
         }
         set
         {
            this.vlannameField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute("vlan-num")]
      public string vlannum
      {
         get
         {
            return this.vlannumField;
         }
         set
         {
            this.vlannumField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Process
   {
      private string nameField;
      private string pidField;
      private string pathField;
      private string[] argField;
      private string[] envField;
      private string identField;
      public Process()
      {
         this.identField = "0";
      }
      /// 
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
      /// 
      [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
      public string pid
      {
         get
         {
            return this.pidField;
         }
         set
         {
            this.pidField = value;
         }
      }
      /// 
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
      /// 
      [System.Xml.Serialization.XmlElementAttribute("arg")]
      public string[] arg
      {
         get
         {
            return this.argField;
         }
         set
         {
            this.argField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("env")]
      public string[] env
      {
         get
         {
            return this.envField;
         }
         set
         {
            this.envField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string ident
      {
         get
         {
            return this.identField;
         }
         set
         {
            this.identField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class TimeWithNtpstamp
   {
      private string ntpstampField;
      private System.DateTime valueField;
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string ntpstamp
      {
         get
         {
            return this.ntpstampField;
         }
         set
         {
            this.ntpstampField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlTextAttribute()]
      public System.DateTime Value
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
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Source
   {
      private Node nodeField;
      private User userField;
      private Process processField;
      private Service serviceField;
      private string identField;
      private yesnotype spoofedField;
      private string interfaceField;
      public Source()
      {
         this.identField = "0";
         this.spoofedField = yesnotype.unknown;
      }
      /// 
      public Node Node
      {
         get
         {
            return this.nodeField;
         }
         set
         {
            this.nodeField = value;
         }
      }
      /// 
      public User User
      {
         get
         {
            return this.userField;
         }
         set
         {
            this.userField = value;
         }
      }
      /// 
      public Process Process
      {
         get
         {
            return this.processField;
         }
         set
         {
            this.processField = value;
         }
      }
      /// 
      public Service Service
      {
         get
         {
            return this.serviceField;
         }
         set
         {
            this.serviceField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string ident
      {
         get
         {
            return this.identField;
         }
         set
         {
            this.identField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(yesnotype.unknown)]
      public yesnotype spoofed
      {
         get
         {
            return this.spoofedField;
         }
         set
         {
            this.spoofedField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string @interface
      {
         get
         {
            return this.interfaceField;
         }
         set
         {
            this.interfaceField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class User
   {
      private UserId[] userIdField;
      private string identField;
      private usercategory categoryField;
      public User()
      {
         this.identField = "0";
         this.categoryField = usercategory.unknown;
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("UserId")]
      public UserId[] UserId
      {
         get
         {
            return this.userIdField;
         }
         set
         {
            this.userIdField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string ident
      {
         get
         {
            return this.identField;
         }
         set
         {
            this.identField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(usercategory.unknown)]
      public usercategory category
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
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class UserId
   {
      private string[] itemsField;
      private ItemsChoiceType[] itemsElementNameField;
      private string identField;
      private idtype typeField;
      private string ttyField;
      public UserId()
      {
         this.identField = "0";
         this.typeField = idtype.originaluser;
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("number", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public string[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string ident
      {
         get
         {
            return this.identField;
         }
         set
         {
            this.identField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(idtype.originaluser)]
      public idtype type
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
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string tty
      {
         get
         {
            return this.ttyField;
         }
         set
         {
            this.ttyField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef", IncludeInSchema=false)]
   public enum ItemsChoiceType
   {
      /// 
      name,
      /// 
      number,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Service
   {
      private string[] itemsField;
      private ItemsChoiceType1[] itemsElementNameField;
      private string protocolField;
      private SNMPService sNMPServiceField;
      private WebService webServiceField;
      private string identField;
      private string ip_versionField;
      private string iana_protocol_numberField;
      private string iana_protocol_nameField;
      public Service()
      {
         this.identField = "0";
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("port", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("portlist", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public string[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType1[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// 
      public string protocol
      {
         get
         {
            return this.protocolField;
         }
         set
         {
            this.protocolField = value;
         }
      }
      /// 
      public SNMPService SNMPService
      {
         get
         {
            return this.sNMPServiceField;
         }
         set
         {
            this.sNMPServiceField = value;
         }
      }
      /// 
      public WebService WebService
      {
         get
         {
            return this.webServiceField;
         }
         set
         {
            this.webServiceField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string ident
      {
         get
         {
            return this.identField;
         }
         set
         {
            this.identField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
      public string ip_version
      {
         get
         {
            return this.ip_versionField;
         }
         set
         {
            this.ip_versionField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
      public string iana_protocol_number
      {
         get
         {
            return this.iana_protocol_numberField;
         }
         set
         {
            this.iana_protocol_numberField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string iana_protocol_name
      {
         get
         {
            return this.iana_protocol_nameField;
         }
         set
         {
            this.iana_protocol_nameField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef", IncludeInSchema=false)]
   public enum ItemsChoiceType1
   {
      /// 
      name,
      /// 
      port,
      /// 
      portlist,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class SNMPService
   {
      private string oidField;
      private string messageProcessingModelField;
      private string securityModelField;
      private string securityNameField;
      private string securityLevelField;
      private string contextNameField;
      private string contextEngineIDField;
      private string commandField;
      /// 
      public string oid
      {
         get
         {
            return this.oidField;
         }
         set
         {
            this.oidField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
      public string messageProcessingModel
      {
         get
         {
            return this.messageProcessingModelField;
         }
         set
         {
            this.messageProcessingModelField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
      public string securityModel
      {
         get
         {
            return this.securityModelField;
         }
         set
         {
            this.securityModelField = value;
         }
      }
      /// 
      public string securityName
      {
         get
         {
            return this.securityNameField;
         }
         set
         {
            this.securityNameField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
      public string securityLevel
      {
         get
         {
            return this.securityLevelField;
         }
         set
         {
            this.securityLevelField = value;
         }
      }
      /// 
      public string contextName
      {
         get
         {
            return this.contextNameField;
         }
         set
         {
            this.contextNameField = value;
         }
      }
      /// 
      public string contextEngineID
      {
         get
         {
            return this.contextEngineIDField;
         }
         set
         {
            this.contextEngineIDField = value;
         }
      }
      /// 
      public string command
      {
         get
         {
            return this.commandField;
         }
         set
         {
            this.commandField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class WebService
   {
      private string urlField;
      private string cgiField;
      private string httpmethodField;
      private string[] argField;
      /// 
      [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
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
      /// 
      public string cgi
      {
         get
         {
            return this.cgiField;
         }
         set
         {
            this.cgiField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("http-method")]
      public string httpmethod
      {
         get
         {
            return this.httpmethodField;
         }
         set
         {
            this.httpmethodField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("arg")]
      public string[] arg
      {
         get
         {
            return this.argField;
         }
         set
         {
            this.argField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Target
   {
      private Node nodeField;
      private User userField;
      private Process processField;
      private Service serviceField;
      private File[] fileField;
      private string identField;
      private yesnotype decoyField;
      private string interfaceField;
      public Target()
      {
         this.identField = "0";
         this.decoyField = yesnotype.unknown;
      }
      /// 
      public Node Node
      {
         get
         {
            return this.nodeField;
         }
         set
         {
            this.nodeField = value;
         }
      }
      /// 
      public User User
      {
         get
         {
            return this.userField;
         }
         set
         {
            this.userField = value;
         }
      }
      /// 
      public Process Process
      {
         get
         {
            return this.processField;
         }
         set
         {
            this.processField = value;
         }
      }
      /// 
      public Service Service
      {
         get
         {
            return this.serviceField;
         }
         set
         {
            this.serviceField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("File")]
      public File[] File
      {
         get
         {
            return this.fileField;
         }
         set
         {
            this.fileField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string ident
      {
         get
         {
            return this.identField;
         }
         set
         {
            this.identField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(yesnotype.unknown)]
      public yesnotype decoy
      {
         get
         {
            return this.decoyField;
         }
         set
         {
            this.decoyField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string @interface
      {
         get
         {
            return this.interfaceField;
         }
         set
         {
            this.interfaceField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class File
   {
      private string nameField;
      private string pathField;
      private System.DateTime createtimeField;
      private bool createtimeFieldSpecified;
      private System.DateTime modifytimeField;
      private bool modifytimeFieldSpecified;
      private System.DateTime accesstimeField;
      private bool accesstimeFieldSpecified;
      private string datasizeField;
      private string disksizeField;
      private FileAccess[] fileAccessField;
      private Linkage[] linkageField;
      private Inode inodeField;
      private Checksum[] checksumField;
      private string identField;
      private filecategory categoryField;
      private string fstypeField;
      private string filetypeField;
      public File()
      {
         this.identField = "0";
      }
      /// 
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
      /// 
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
      /// 
      [System.Xml.Serialization.XmlElementAttribute("create-time")]
      public System.DateTime createtime
      {
         get
         {
            return this.createtimeField;
         }
         set
         {
            this.createtimeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool createtimeSpecified
      {
         get
         {
            return this.createtimeFieldSpecified;
         }
         set
         {
            this.createtimeFieldSpecified = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("modify-time")]
      public System.DateTime modifytime
      {
         get
         {
            return this.modifytimeField;
         }
         set
         {
            this.modifytimeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool modifytimeSpecified
      {
         get
         {
            return this.modifytimeFieldSpecified;
         }
         set
         {
            this.modifytimeFieldSpecified = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("access-time")]
      public System.DateTime accesstime
      {
         get
         {
            return this.accesstimeField;
         }
         set
         {
            this.accesstimeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool accesstimeSpecified
      {
         get
         {
            return this.accesstimeFieldSpecified;
         }
         set
         {
            this.accesstimeFieldSpecified = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("data-size", DataType="integer")]
      public string datasize
      {
         get
         {
            return this.datasizeField;
         }
         set
         {
            this.datasizeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("disk-size", DataType="integer")]
      public string disksize
      {
         get
         {
            return this.disksizeField;
         }
         set
         {
            this.disksizeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("FileAccess")]
      public FileAccess[] FileAccess
      {
         get
         {
            return this.fileAccessField;
         }
         set
         {
            this.fileAccessField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("Linkage")]
      public Linkage[] Linkage
      {
         get
         {
            return this.linkageField;
         }
         set
         {
            this.linkageField = value;
         }
      }
      /// 
      public Inode Inode
      {
         get
         {
            return this.inodeField;
         }
         set
         {
            this.inodeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("Checksum")]
      public Checksum[] Checksum
      {
         get
         {
            return this.checksumField;
         }
         set
         {
            this.checksumField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string ident
      {
         get
         {
            return this.identField;
         }
         set
         {
            this.identField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public filecategory category
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
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string fstype
      {
         get
         {
            return this.fstypeField;
         }
         set
         {
            this.fstypeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute("file-type")]
      public string filetype
      {
         get
         {
            return this.filetypeField;
         }
         set
         {
            this.filetypeField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class FileAccess
   {
      private UserId userIdField;
      private Permission[] permissionField;
      /// 
      public UserId UserId
      {
         get
         {
            return this.userIdField;
         }
         set
         {
            this.userIdField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("permission")]
      public Permission[] permission
      {
         get
         {
            return this.permissionField;
         }
         set
         {
            this.permissionField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Permission
   {
      private filepermission permsField;
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public filepermission perms
      {
         get
         {
            return this.permsField;
         }
         set
         {
            this.permsField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Linkage
   {
      private object[] itemsField;
      private ItemsChoiceType2[] itemsElementNameField;
      private linkagecategory categoryField;
      /// 
      [System.Xml.Serialization.XmlElementAttribute("File", typeof(File))]
      [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("path", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType2[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public linkagecategory category
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
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef", IncludeInSchema=false)]
   public enum ItemsChoiceType2
   {
      /// 
      File,
      /// 
      name,
      /// 
      path,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Inode
   {
      private string changetimeField;
      private string numberField;
      private string majordeviceField;
      private string minordeviceField;
      private string cmajordeviceField;
      private string cminordeviceField;
      /// 
      [System.Xml.Serialization.XmlElementAttribute("change-time")]
      public string changetime
      {
         get
         {
            return this.changetimeField;
         }
         set
         {
            this.changetimeField = value;
         }
      }
      /// 
      public string number
      {
         get
         {
            return this.numberField;
         }
         set
         {
            this.numberField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("major-device")]
      public string majordevice
      {
         get
         {
            return this.majordeviceField;
         }
         set
         {
            this.majordeviceField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("minor-device")]
      public string minordevice
      {
         get
         {
            return this.minordeviceField;
         }
         set
         {
            this.minordeviceField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("c-major-device")]
      public string cmajordevice
      {
         get
         {
            return this.cmajordeviceField;
         }
         set
         {
            this.cmajordeviceField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("c-minor-device")]
      public string cminordevice
      {
         get
         {
            return this.cminordeviceField;
         }
         set
         {
            this.cminordeviceField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Checksum
   {
      private string valueField;
      private string keyField;
      private checksumalgorithm algorithmField;
      /// 
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
      /// 
      public string key
      {
         get
         {
            return this.keyField;
         }
         set
         {
            this.keyField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public checksumalgorithm algorithm
      {
         get
         {
            return this.algorithmField;
         }
         set
         {
            this.algorithmField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Classification
   {
      private Reference[] referenceField;
      private string identField;
      private string textField;
      public Classification()
      {
         this.identField = "0";
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("Reference")]
      public Reference[] Reference
      {
         get
         {
            return this.referenceField;
         }
         set
         {
            this.referenceField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string ident
      {
         get
         {
            return this.identField;
         }
         set
         {
            this.identField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string text
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
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Reference
   {
      private string nameField;
      private string urlField;
      private referenceorigin originField;
      private string meaningField;
      public Reference()
      {
         this.originField = referenceorigin.unknown;
      }
      /// 
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
      /// 
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
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(referenceorigin.unknown)]
      public referenceorigin origin
      {
         get
         {
            return this.originField;
         }
         set
         {
            this.originField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string meaning
      {
         get
         {
            return this.meaningField;
         }
         set
         {
            this.meaningField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Assessment
   {
      private Impact impactField;
      private Action[] actionField;
      private Confidence confidenceField;
      /// 
      public Impact Impact
      {
         get
         {
            return this.impactField;
         }
         set
         {
            this.impactField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("Action")]
      public Action[] Action
      {
         get
         {
            return this.actionField;
         }
         set
         {
            this.actionField = value;
         }
      }
      /// 
      public Confidence Confidence
      {
         get
         {
            return this.confidenceField;
         }
         set
         {
            this.confidenceField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Impact
   {
      private impactseverity severityField;
      private bool severityFieldSpecified;
      private impactcompletion completionField;
      private bool completionFieldSpecified;
      private impacttype typeField;
      private string valueField;
      public Impact()
      {
         this.typeField = impacttype.other;
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public impactseverity severity
      {
         get
         {
            return this.severityField;
         }
         set
         {
            this.severityField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool severitySpecified
      {
         get
         {
            return this.severityFieldSpecified;
         }
         set
         {
            this.severityFieldSpecified = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public impactcompletion completion
      {
         get
         {
            return this.completionField;
         }
         set
         {
            this.completionField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool completionSpecified
      {
         get
         {
            return this.completionFieldSpecified;
         }
         set
         {
            this.completionFieldSpecified = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(impacttype.other)]
      public impacttype type
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
      /// 
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
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Action
   {
      private actioncategory categoryField;
      private string valueField;
      public Action()
      {
         this.categoryField = actioncategory.other;
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(actioncategory.other)]
      public actioncategory category
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
      /// 
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
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Confidence
   {
      private confidencerating ratingField;
      private string valueField;
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public confidencerating rating
      {
         get
         {
            return this.ratingField;
         }
         set
         {
            this.ratingField = value;
         }
      }
      /// 
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
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class CorrelationAlert
   {
      private string nameField;
      private Alertident[] alertidentField;
      /// 
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
      /// 
      [System.Xml.Serialization.XmlElementAttribute("alertident")]
      public Alertident[] alertident
      {
         get
         {
            return this.alertidentField;
         }
         set
         {
            this.alertidentField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Alertident
   {
      private string analyzeridField;
      private string valueField;
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string analyzerid
      {
         get
         {
            return this.analyzeridField;
         }
         set
         {
            this.analyzeridField = value;
         }
      }
      /// 
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
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class OverflowAlert
   {
      private string programField;
      private string sizeField;
      private byte[] bufferField;
      /// 
      public string program
      {
         get
         {
            return this.programField;
         }
         set
         {
            this.programField = value;
         }
      }
      /// 
      public string size
      {
         get
         {
            return this.sizeField;
         }
         set
         {
            this.sizeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary")]
      public byte[] buffer
      {
         get
         {
            return this.bufferField;
         }
         set
         {
            this.bufferField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class ToolAlert
   {
      private string nameField;
      private string commandField;
      private Alertident[] alertidentField;
      /// 
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
      /// 
      public string command
      {
         get
         {
            return this.commandField;
         }
         set
         {
            this.commandField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("alertident")]
      public Alertident[] alertident
      {
         get
         {
            return this.alertidentField;
         }
         set
         {
            this.alertidentField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class AdditionalData
   {
      private object itemField;
      private ItemChoiceType itemElementNameField;
      private additionaldatatype typeField;
      private bool typeFieldSpecified;
      private string meaningField;
      /// 
      [System.Xml.Serialization.XmlElementAttribute("boolean", typeof(bool))]
      [System.Xml.Serialization.XmlElementAttribute("byte", typeof(sbyte))]
      [System.Xml.Serialization.XmlElementAttribute("byte-string", typeof(byte[]), DataType="hexBinary")]
      [System.Xml.Serialization.XmlElementAttribute("character", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("date-time", typeof(System.DateTime))]
      [System.Xml.Serialization.XmlElementAttribute("integer", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("ntpstamp", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("portlist", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("real", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("string", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("xml", typeof(xmltext))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
      public object Item
      {
         get
         {
            return this.itemField;
         }
         set
         {
            this.itemField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemChoiceType ItemElementName
      {
         get
         {
            return this.itemElementNameField;
         }
         set
         {
            this.itemElementNameField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public additionaldatatype type
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
      /// 
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool typeSpecified
      {
         get
         {
            return this.typeFieldSpecified;
         }
         set
         {
            this.typeFieldSpecified = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string meaning
      {
         get
         {
            return this.meaningField;
         }
         set
         {
            this.meaningField = value;
         }
      }
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class xmltext
   {
      private string[] textField;
      /// 
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
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef", IncludeInSchema=false)]
   public enum ItemChoiceType
   {
      /// 
      boolean,
      /// 
      @byte,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("byte-string")]
      bytestring,
      /// 
      character,
      /// 
      [System.Xml.Serialization.XmlEnumAttribute("date-time")]
      datetime,
      /// 
      integer,
      /// 
      ntpstamp,
      /// 
      portlist,
      /// 
      real,
      /// 
      @string,
      /// 
      xml,
   }
   /// 
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iana.org/idmef")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://iana.org/idmef", IsNullable=true)]
   public partial class Heartbeat
   {
      private Analyzer analyzerField;
      private TimeWithNtpstamp createTimeField;
      private string heartbeatIntervalField;
      private TimeWithNtpstamp analyzerTimeField;
      private AdditionalData[] additionalDataField;
      private string messageidField;
      public Heartbeat()
      {
         this.messageidField = "0";
      }
      /// 
      public Analyzer Analyzer
      {
         get
         {
            return this.analyzerField;
         }
         set
         {
            this.analyzerField = value;
         }
      }
      /// 
      public TimeWithNtpstamp CreateTime
      {
         get
         {
            return this.createTimeField;
         }
         set
         {
            this.createTimeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
      public string HeartbeatInterval
      {
         get
         {
            return this.heartbeatIntervalField;
         }
         set
         {
            this.heartbeatIntervalField = value;
         }
      }
      /// 
      public TimeWithNtpstamp AnalyzerTime
      {
         get
         {
            return this.analyzerTimeField;
         }
         set
         {
            this.analyzerTimeField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlElementAttribute("AdditionalData")]
      public AdditionalData[] AdditionalData
      {
         get
         {
            return this.additionalDataField;
         }
         set
         {
            this.additionalDataField = value;
         }
      }
      /// 
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute("0")]
      public string messageid
      {
         get
         {
            return this.messageidField;
         }
         set
         {
            this.messageidField = value;
         }
      }
   }
}
