﻿#region Using Statements
using MarkLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
#endregion

namespace Marklight.DevTools.Source
{
    /// <summary>
    /// Contains data about a view, data-type or method.
    /// </summary>
    public class DocData
    {
        public string TypeName;
        public string FullTypeName;
        public string FileName;
        public string HtmlTypeName;
        public bool IsView;
        public bool IsType;
        public bool IsField;
        public bool IsMethod;
        public string Summary;
        public string Description;
        public string DocContent;
        public string ActionDataType;
        public Dictionary<string, string> FieldSummaries = new Dictionary<string, string>();
        public Dictionary<string, string> FieldDescriptions = new Dictionary<string, string>();
        public Dictionary<string, string> FieldActionData = new Dictionary<string, string>();
        public HashSet<string> MappedFields = new HashSet<string>();

        public string GetFieldSummary(string viewField)
        {
            return FieldSummaries.ContainsKey(viewField) ? FieldSummaries[viewField] : String.Empty;
        }

        public string GetFieldDescription(string viewField)
        {
            return FieldDescriptions.ContainsKey(viewField) ? FieldDescriptions[viewField] : String.Empty;
        }

        public string GetFieldActionData(string viewField)
        {
            return FieldActionData.ContainsKey(viewField) ? FieldActionData[viewField] : String.Empty;
        }
    }
}
