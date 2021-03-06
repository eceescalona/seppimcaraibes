﻿namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;

    internal class C_Product : IDisposable
    {
        private readonly Data.ORM.SeppimCaraibesLocalEntities _context;
        private readonly Model.Product _mProduct;


        #region Ctor
        public C_Product()
        {
            _mProduct = new Model.Product();
            _context = new Data.ORM.SeppimCaraibesLocalEntities();
        }

        public C_Product(Data.ORM.SeppimCaraibesLocalEntities context)
        {
            _context = context;
            _mProduct = new Model.Product();
        }
        #endregion


        #region IDisposable
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion


        private bool Validate(Data.ORM.Product product, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string field;
            string message;

            if (string.IsNullOrWhiteSpace(product.ProductId))
            {
                flag = false;
                field = "codeTE";
                message = "El Campo Código no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(product.ProductName))
            {
                flag = false;
                field = "nameME";
                message = "El Campo Nombre no puede ser vacío.";
                fields.Add(field, message);
            }

            if (product.Providers == null)
            {
                flag = false;
                field = "providersGridC";
                message = "El Campo Proveedor no puede ser vacío.";
                fields.Add(field, message);
            }

            if (product.ProductsOrigins == null)
            {
                flag = false;
                field = "originsSLUE";
                message = "El Campo País no puede ser vacío.";
                fields.Add(field, message);
            }
            return flag;
        }


        public Data.ORM.SeppimCaraibesLocalEntities GetContext()
        {
            return _context;
        }

        public string GetEnumDescription(Enum value)
        {
            FieldInfo fielInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] descriptionAttributes = (DescriptionAttribute[])fielInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (descriptionAttributes != null && descriptionAttributes.Length > 0)
            {
                return descriptionAttributes[0].Description;
            }
            else
            {
                return string.Empty;
            }
        }

        public T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);

            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", "description");
        }


        #region ProductManage
        public BindingList<Data.POCO.ProductsOrders> FillProductsOrders()
        {
            return _mProduct.GetProductsOrders(_context);
        }

        public void AddProduct(IAddEditProduct addEditProduct, Data.ORM.Product product)
        {
            string message = string.Format("El producto {0} ha sido registrado satisfactoriamente.", product.ProductName);

            if (Validate(product, out Dictionary<string, string> fields))
            {
                _mProduct.AddProduct(_context, product);

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

                addEditProduct.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditProduct.ShowFieldsWithError(fields);
            }
        }

        public async void EditProduct(IAddEditProduct addEditProduct, string code)
        {
            var product = await _mProduct.GetProduct(_context, code);
            addEditProduct.EditProduct(product);
        }

        public void EditProduct(IAddEditProduct addEditProduct, Data.ORM.Product product)
        {
            string message = string.Format("Los atributos del producto {0} han sido modificados satisfactoriamente.", product.ProductName);

            if (Validate(product, out Dictionary<string, string> fields))
            {
                _mProduct.EditProduct(_context, product);

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

                addEditProduct.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditProduct.ShowFieldsWithError(fields);
            }
        }

        public void DeleteProduct(IListProducts listProducts, string code)
        {
            string message = string.Format("El producto con código {0} ha sido eliminado satisfactoriamente.", code);

            _mProduct.DeleteProduct(_context, code);

            C_Log _cLog = new C_Log();
            _cLog.Write(message, ETypeOfMessage.Information);

            listProducts.ShowMessage(ETypeOfMessage.Information, message);
            listProducts.RefreshView();
        }
        #endregion
    }
}
