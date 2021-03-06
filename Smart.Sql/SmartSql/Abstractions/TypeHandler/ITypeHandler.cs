﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartSql.Abstractions.TypeHandler
{
    public interface ITypeHandler
    {
        void SetParameter(IDataParameter dataParameter, object parameterValue);
        object GetValue(IDataReader dataReader, string columnName,Type targetType);
        object GetValue(IDataReader dataReader, int columnIndex, Type targetType);

        object ToParameterValue(object value);
    }
}
