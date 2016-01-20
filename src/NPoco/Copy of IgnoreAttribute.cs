using System;
using System.Data;

namespace NPoco
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class SqlTypeAttribute : Attribute
    {
      public DbType DbType { get; set; }
      public int Length { get; set; }

      public SqlTypeAttribute( DbType dbType ) {
        DbType = dbType;
      }

      public SqlTypeAttribute(DbType dbType, int length)
      {
        DbType = dbType;
        Length = length;
      }
    }
}