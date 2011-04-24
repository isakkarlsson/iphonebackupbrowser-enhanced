﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using IDevice.IPhone;
using IDevice.Managers;

namespace IDevice.Plugins.Browsers
{
    public class AbstractBrowsable : Form, IBrowsable
    {
        private string prefix;
        private SelectionModel _selectionModel;
        private FileManager _fileManager;

        protected AbstractBrowsable(string prefix)
        {
            this.prefix = prefix;
            _fileManager = new FileManager();
        }

        public AbstractBrowsable() : this("*******************") { }

        protected SelectionModel SelectionModel
        {
            get { return _selectionModel; }
        }

        protected virtual IPhoneFile[] SelectedFiles
        {
            get { return _selectionModel.Files; }
        }

        protected virtual IPhoneBackup SelectedBackup
        {
            get { return _selectionModel.Backup; }
        }

        protected virtual FileManager FileManager
        {
            get { return _fileManager; }
        }

        /// <summary>
        /// Default to a modal window
        /// </summary>
        public virtual bool IsModal { get { return true; } }

        protected virtual void PreOpen()
        {

        }

        public virtual Form Open()
        {
            PreOpen();
            return this;
        }

        public virtual ToolStripMenuItem GetMenu()
        {
            return null;
        }


        public virtual string Prefix
        {
            get { return this.prefix; }
        }


        public void SetModel(SelectionModel model)
        {
            _selectionModel = model;
        }

        public virtual string PluginAuthor
        {
            get { return "none"; }
        }

        public virtual string PluginDescription
        {
            get { return "none"; }
        }

        public virtual string PluginName
        {
            get { return "none"; }
        }

        public override int GetHashCode()
        {
            return PluginName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is IPlugin))
                return false;

            return CompareTo(obj as IPlugin) == 0;
        }

        public int CompareTo(IPlugin other)
        {
            return PluginName.CompareTo(other.PluginName);
        }
    }
}
