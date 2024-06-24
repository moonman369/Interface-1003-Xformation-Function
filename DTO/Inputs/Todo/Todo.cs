/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System.Xml.Serialization;

namespace Interface_1003_Xformation_Function.DTO.Inputs.Todo
{
	[XmlRoot(ElementName = "todo")]
	public class Todo
	{
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "frequency")]
		public string Frequency { get; set; }
		[XmlAttribute(AttributeName = "priority")]
		public string Priority { get; set; }
	}

	[XmlRoot(ElementName = "todos")]
	public class Todos
	{
		[XmlElement(ElementName = "todo")]
		public List<Todo> Todo { get; set; }
	}

	[XmlRoot(ElementName = "note")]
	public class Note
	{
		[XmlElement(ElementName = "todos")]
		public Todos Todos { get; set; }
	}

}
