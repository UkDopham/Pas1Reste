﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Roberta.Models
{
    public class Recipe
    {
        protected string _name;
        protected string _description;
        protected DateTime _lastCooked;
        protected int _count;
        protected string _path;
        protected List<Product> _products;

        public List<Product> Products
        {
            get
            {
                return this._products;
            }
            set
            {
                this._products = value;
            }
        }
        public string Path
        {
            get
            {
                return this._path;
            }
        }

        public int Count
        {
            get
            {
                return this._count;
            }
            set
            {
                this._count = value;
            }
        }

        public DateTime LastCooked
        {
            get
            {
                return this._lastCooked;
            }
            set
            {
                this._lastCooked = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public string Description
        {
            get
            {
                return this._description;
            }
        }

        public Recipe(string name, 
            string description,
            DateTime lastCooked,
            string path,
            List<Product> products,
            int count = 0)
        {
            this._name = name;
            this._description = description;
            this._lastCooked = lastCooked;
            this._products = products;
            this._path = path;
            this._count = count;
        }
    }
}
