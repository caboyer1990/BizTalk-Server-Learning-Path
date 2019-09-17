namespace BizTalk.CallingExternalAssemblyFromInlineXSLT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.CallingExternalAssemblyFromInlineXSLT.CarsOnSale",@"CarsOnSale")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CarsOnSale"})]
    public sealed class CarsOnSale : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.CallingExternalAssemblyFromInlineXSLT.CarsOnSale"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk.CallingExternalAssemblyFromInlineXSLT.CarsOnSale"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CarsOnSale"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Car"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Brand"" type=""xs:string"" />
              <xs:element name=""Model"" type=""xs:string"" />
              <xs:element name=""Year"" type=""xs:string"" />
              <xs:element name=""TechnicalInfo"" type=""xs:string"" />
              <xs:element name=""Price"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""PriceMarket"" type=""xs:string"" />
                    <xs:element name=""PriceOwner"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""OwnerInfo"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Name"" type=""xs:string"" />
                    <xs:element name=""Address"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CarsOnSale() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CarsOnSale";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
