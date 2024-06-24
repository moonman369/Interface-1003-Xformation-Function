/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Interface_1003_Xformation_Function.DTO.Outputs.Enriched
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

    [XmlRoot(ElementName = "todo", Namespace = "http://tempuri.org")]
    public class Todo
    {
        [XmlElement(ElementName = "title", Namespace = "http://tempuri.org")]
        public string Title { get; set; }
        [XmlElement(ElementName = "frequency", Namespace = "http://tempuri.org")]
        public string Frequency { get; set; }
        [XmlAttribute(AttributeName = "priority")]
        public string Priority { get; set; }
    }

    [XmlRoot(ElementName = "todos", Namespace = "http://tempuri.org")]
    public class Todos
    {
        [XmlElement(ElementName = "todo", Namespace = "http://tempuri.org")]
        public List<Todo> Todo { get; set; }
    }

    [XmlRoot(ElementName = "note", Namespace = "http://tempuri.org")]
    public class Note
    {
        [XmlElement(ElementName = "todos", Namespace = "http://tempuri.org")]
        public Todos Todos { get; set; }
    }

    [XmlRoot(ElementName = "TodoResult", Namespace = "http://tempuri.org")]
    public class TodoResult
    {
        [XmlElement(ElementName = "note", Namespace = "http://tempuri.org")]
        public Note Note { get; set; }
    }

    [XmlRoot(ElementName = "EnrichedResponse", Namespace = "http://tempuri.org")]
    public class EnrichedResponse
    {
        [XmlElement(ElementName = "FindPersonResult", Namespace = "http://tempuri.org")]
        public FindPersonResult FindPersonResult { get; set; }
        [XmlElement(ElementName = "AddIntegerResult", Namespace = "http://tempuri.org")]
        public string AddIntegerResult { get; set; }
        [XmlElement(ElementName = "TodoResult", Namespace = "http://tempuri.org")]
        public TodoResult TodoResult { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Body
    {
        [XmlElement(ElementName = "EnrichedResponse", Namespace = "http://tempuri.org")]
        public EnrichedResponse EnrichedResponse { get; set; }
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
