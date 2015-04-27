using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;

namespace DomFinderLibrary
{
    public class DomFinder
    {
        private Find _find;

        public DomFinder(string htmlText)
        {
            HtmlTreeBuilder treeBuilder = new HtmlTreeBuilder();
            var domRoot = treeBuilder.BuildDomTree(htmlText, true);

            BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance;
            _find = Activator.CreateInstance(typeof(Find), flags, null, new object[] { domRoot }, null) as Find;
        }

        public Find Find
        {
            get { return _find; }
        }
    }
}
