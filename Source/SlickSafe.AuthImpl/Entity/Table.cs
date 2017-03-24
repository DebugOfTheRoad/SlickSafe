﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlickSafe.AuthImpl.Entity
{
    /// <summary>
    /// mapped entity to table
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Class, Inherited = false, AllowMultiple = false), Serializable]
    public class Table : System.Attribute
    {
        public string TableName;
        public Table(string tblName)
        {
            TableName = tblName;
        }
    }
}
