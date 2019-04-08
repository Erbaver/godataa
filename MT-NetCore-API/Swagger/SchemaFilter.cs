﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MT_NetCore_API.Swagger
{
    public class SchemaFilter : ISchemaFilter
    {

        public void Apply(Schema schema, SchemaFilterContext context)
        {
            if (schema.Properties == null)
            {
                return;
            }

            foreach (PropertyInfo propertyInfo in context.SystemType.GetProperties())
            {

                // Look for class attributes that have been decorated with "[DefaultAttribute(...)]".
                DefaultValueAttribute defaultAttribute = propertyInfo
                    .GetCustomAttribute<DefaultValueAttribute>();

                if (defaultAttribute != null)
                {
                    foreach (KeyValuePair<string, Schema> property in schema.Properties)
                    {

                        // Only assign default value to the proper element.
                        if (propertyInfo.Name.ToLower() == property.Key.Replace("_", "").ToLower())
                        {
                            property.Value.Example = defaultAttribute.Value;
                            break;
                        }
                    }
                }
            }
        }

        private string ToCamelCase(string name)
        {
            return char.ToLowerInvariant(name[0]) + name.Substring(1);
        }
    }
}
