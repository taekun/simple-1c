﻿using Simple1C.Impl.Sql.Translation;

namespace Simple1C.Impl.Sql.SqlAccess.Syntax
{
    internal class ValueLiteralExpression : ISqlElement
    {
        public string Value { get; set; }

        public ISqlElement Accept(SqlVisitor visitor)
        {
            return visitor.VisitValueLiteral(this);
        }
    }
}