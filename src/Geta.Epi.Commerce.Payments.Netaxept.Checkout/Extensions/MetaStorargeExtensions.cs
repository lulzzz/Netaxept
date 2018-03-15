﻿using System.Collections;
using EPiServer.Commerce.Order;
using EPiServer.Commerce.Storage;
using Mediachase.Commerce.Storage;

namespace Geta.Epi.Commerce.Payments.Netaxept.Checkout.Extensions
{
    public static class MetaStorageExtensions
    {
        public static string GetStringValue(this Hashtable item, string fieldName)
        {
            return item.GetStringValue(fieldName, string.Empty);
        }

        public static string GetStringValue(this Hashtable item, string fieldName, string defaultValue)
        {
            return item[fieldName] != null ? item[fieldName].ToString() : defaultValue;
        }

        public static decimal GetDecimalValue(this Hashtable item, string fieldName, decimal defaultValue)
        {
            if (item[fieldName] != null)
            {
                decimal value;

                if (decimal.TryParse(item[fieldName].ToString(), out value))
                {
                    return value;
                }
            }

            return defaultValue;
        }
    }
}
