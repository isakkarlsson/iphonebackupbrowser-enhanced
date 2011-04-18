﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDevice.Browsers.Browsers
{
    public class BrowseHandler
    {
        private static BrowseHandler _handler;
        public static BrowseHandler Current
        {
            get
            {
                if (_handler == null)
                    _handler = new BrowseHandler();
                return _handler;
            }
        }
        private Dictionary<string, IBrowsable> _browsers;
        private BrowseHandler()
        {
            _browsers = new Dictionary<string, IBrowsable> 
            {
                { ".db", new SQL.SQLiteBrowser() }
            };
        }

        public void Add(string prefix, IBrowsable browser)
        {
            _browsers.Add(prefix, browser);
        }

        public IBrowsable Get(string prefix)
        {
            IBrowsable browsable = _browsers[prefix];
            return browsable != null ? browsable : new DefaultHandler();
        }

        public bool CanHandle(string prefix)
        {
            return _browsers.ContainsKey(prefix) && _browsers[prefix] != null;
        }

    }
}
