using Entities.LinkModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Entities.Models
{
    /// <summary>
    /// Entity
    /// </summary>
    public class Entity : DynamicObject, IXmlSerializable, IDictionary<string, object>
    {
        private readonly string _root = "Entity";
        private readonly IDictionary<string, object> _expando = null;

        /// <summary>
        /// ctor
        /// </summary>
        public Entity()
        {
            _expando = new ExpandoObject();
        }

        /// <summary>
        /// Try Get Member
        /// </summary>
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (_expando.TryGetValue(binder.Name, out object value))
            {
                result = value;
                return true;
            }

            return base.TryGetMember(binder, out result);
        }

        /// <summary>
        /// Try Set Member
        /// </summary>
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _expando[binder.Name] = value;

            return true;
        }

        /// <summary>
        /// Get Schema
        /// </summary>
        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Read Xml
        /// </summary>
        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement(_root);

            while (!reader.Name.Equals(_root))
            {
                string typeContent;
                Type underlyingType;
                var name = reader.Name;

                reader.MoveToAttribute("type");
                typeContent = reader.ReadContentAsString();
                underlyingType = Type.GetType(typeContent);
                reader.MoveToContent();
                _expando[name] = reader.ReadElementContentAs(underlyingType, null);
            }
        }

        /// <summary>
        /// Write Xml
        /// </summary>
        public void WriteXml(XmlWriter writer)
        {
            foreach (var key in _expando.Keys)
            {
                var value = _expando[key];
                WriteLinksToXml(key, value, writer);
            }
        }

        /// <summary>
        /// Write Links Xml
        /// </summary>
        private void WriteLinksToXml(string key, object value, XmlWriter writer)
        {
            writer.WriteStartElement(key);

            if (value.GetType() == typeof(List<Link>))
            {
                foreach (var val in value as List<Link>)
                {
                    writer.WriteStartElement(nameof(Link));
                    WriteLinksToXml(nameof(val.Href), val.Href, writer);
                    WriteLinksToXml(nameof(val.Method), val.Method, writer);
                    WriteLinksToXml(nameof(val.Rel), val.Rel, writer);
                    writer.WriteEndElement();
                }
            }
            else
            {
                writer.WriteString(value.ToString());
            }

            writer.WriteEndElement();
        }

        /// <summary>
        /// Add
        /// </summary>
        public void Add(string key, object value)
        {
            _expando.Add(key, value);
        }

        /// <summary>
        /// Contains Key
        /// </summary>
        public bool ContainsKey(string key)
        {
            return _expando.ContainsKey(key);
        }

        /// <summary>
        /// Keys
        /// </summary>
        public ICollection<string> Keys
        {
            get { return _expando.Keys; }
        }

        /// <summary>
        /// Remove
        /// </summary>
        public bool Remove(string key)
        {
            return _expando.Remove(key);
        }

        /// <summary>
        /// Try Get Value
        /// </summary>
        public bool TryGetValue(string key, out object value)
        {
            return _expando.TryGetValue(key, out value);
        }

        /// <summary>
        /// Values
        /// </summary>
        public ICollection<object> Values
        {
            get { return _expando.Values; }
        }

        public object this[string key]
        {
            get
            {
                return _expando[key];
            }
            set
            {
                _expando[key] = value;
            }
        }

        /// <summary>
        /// Add
        /// </summary>
        public void Add(KeyValuePair<string, object> item)
        {
            _expando.Add(item);
        }

        /// <summary>
        /// Clear
        /// </summary>
        public void Clear()
        {
            _expando.Clear();
        }

        /// <summary>
        /// Contains
        /// </summary>
        public bool Contains(KeyValuePair<string, object> item)
        {
            return _expando.Contains(item);
        }

        /// <summary>
        /// Copy To
        /// </summary>
        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            _expando.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Count
        /// </summary>
        public int Count
        {
            get { return _expando.Count; }
        }

        /// <summary>
        /// Is Read Only
        /// </summary>
        public bool IsReadOnly
        {
            get { return _expando.IsReadOnly; }
        }

        /// <summary>
        /// Remove
        /// </summary>
        public bool Remove(KeyValuePair<string, object> item)
        {
            return _expando.Remove(item);
        }

        /// <summary>
        /// Get Enumerator
        /// </summary>
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return _expando.GetEnumerator();
        }

        /// <summary>
        /// Get Enumerator
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
