using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace COM.Domain
{
    public class PermissionUser
    {
        public PermissionUser(XElement userDataXml, XElement roleDataXml, XElement menuDataXml)
        {
            this.UserDataXml = userDataXml;
            this.RoleDataXml = roleDataXml;
            this.MenuDataXml = menuDataXml;
        }
        public XElement UserDataXml{get;set;}
        public XElement RoleDataXml { get; set; }
        public XElement MenuDataXml { get; set; }
        public virtual XElement PermissionDataXML
        {
            get
            {
                var element = new XElement("v",
                                new XAttribute("u", this.UserDataXml),
                                new XAttribute("r",this.RoleDataXml),
                                new XAttribute("m",this.MenuDataXml)
                                );
                return element;
            }
        }
    }
}
