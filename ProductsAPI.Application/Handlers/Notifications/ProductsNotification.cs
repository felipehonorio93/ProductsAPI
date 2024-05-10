﻿using MediatR;
using ProductsAPI.Application.Models.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAPI.Application.Handlers.Notifications
{
    /// <summary>
    /// Modelo de dados da notification de produtos
    /// </summary>
    public class ProductsNotification : INotification
    {
        public ActionNotification? Action { get; set; }
        public ProductsDTO? ProductsDTO { get; set; }
    }

    public enum ActionNotification
    {
        Created,
        Updated,
        Deleted
    }
}
