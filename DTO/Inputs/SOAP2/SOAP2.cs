/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System.Xml.Serialization;

namespace Interface_1003_Xformation_Function.DTO.Inputs.SOAP2
{
    [XmlRoot(ElementName = "Home", Namespace = "http://tempuri.org")]
    public class Home
    {
        [XmlElement(ElementName = "Street", Namespace = "http://tempuri.org")]
        public string Street { get; set; }
        [XmlElement(ElementName = "City", Namespace = "http://tempuri.org")]
        public string City { get; set; }
        [XmlElement(ElementName = "State", Namespace = "http://tempuri.org")]
        public string State { get; set; }
        [XmlElement(ElementName = "Zip", Namespace = "http://tempuri.org")]
        public string Zip { get; set; }
    }

    [XmlRoot(ElementName = "Office", Namespace = "http://tempuri.org")]
    public class Office
    {
        [XmlElement(ElementName = "Street", Namespace = "http://tempuri.org")]
        public string Street { get; set; }
        [XmlElement(ElementName = "City", Namespace = "http://tempuri.org")]
        public string City { get; set; }
        [XmlElement(ElementName = "State", Namespace = "http://tempuri.org")]
        public string State { get; set; }
        [XmlElement(ElementName = "Zip", Namespace = "http://tempuri.org")]
        public string Zip { get; set; }
    }

    [XmlRoot(ElementName = "FavoriteColors", Namespace = "http://tempuri.org")]
    public class FavoriteColors
    {
        [XmlElement(ElementName = "FavoriteColorsItem", Namespace = "http://tempuri.org")]
        public string FavoriteColorsItem { get; set; }
    }

    [XmlRoot(ElementName = "FindPersonResult", Namespace = "http://tempuri.org")]
    public class FindPersonResult
    {
        [XmlElement(ElementName = "Name", Namespace = "http://tempuri.org")]
        public string Name { get; set; }
        [XmlElement(ElementName = "SSN", Namespace = "http://tempuri.org")]
        public string SSN { get; set; }
        [XmlElement(ElementName = "DOB", Namespace = "http://tempuri.org")]
        public string DOB { get; set; }
        [XmlElement(ElementName = "Home", Namespace = "http://tempuri.org")]
        public Home Home { get; set; }
        [XmlElement(ElementName = "Office", Namespace = "http://tempuri.org")]
        public Office Office { get; set; }
        [XmlElement(ElementName = "FavoriteColors", Namespace = "http://tempuri.org")]
        public FavoriteColors FavoriteColors { get; set; }
        [XmlElement(ElementName = "Age", Namespace = "http://tempuri.org")]
        public string Age { get; set; }
    }

    [XmlRoot(ElementName = "FindPersonResponse", Namespace = "http://tempuri.org")]
    public class FindPersonResponse
    {
        [XmlElement(ElementName = "FindPersonResult", Namespace = "http://tempuri.org")]
        public FindPersonResult FindPersonResult { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Body
    {
        [XmlElement(ElementName = "FindPersonResponse", Namespace = "http://tempuri.org")]
        public FindPersonResponse FindPersonResponse { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }
        [XmlAttribute(AttributeName = "SOAP-ENV", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string SOAPENV { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string S { get; set; }
    }

}
