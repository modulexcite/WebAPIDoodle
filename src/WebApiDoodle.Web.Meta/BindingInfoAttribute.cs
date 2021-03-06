﻿using System;

namespace WebApiDoodle.Web.Meta {

    /// <summary>
    /// Provides the binding information for the properties of the complex type action parameters.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class BindingInfoAttribute : Attribute {

        private bool _noBinding = false;

        public bool NoBinding {
            get {
                return _noBinding;
            }
            set {
                _noBinding = value;
            }
        }
    }
}