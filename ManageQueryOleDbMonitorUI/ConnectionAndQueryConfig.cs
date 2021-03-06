﻿using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ManageQueryOleDbMonitorUI
{
    [Serializable, XmlType(AnonymousType = true), XmlRoot(Namespace = "", IsNullable = false)]
    public class ConnectionAndQueryConfig
    {
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string TemplateIdString { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Instance { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string UniqueID { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Database { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Query { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string MetricType { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PrincipalName { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string RunAsAccount { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ConnectionString { get; set; }
    }
}