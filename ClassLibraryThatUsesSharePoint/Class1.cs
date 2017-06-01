using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryThatUsesSharePoint
{
    using Microsoft.SharePoint;

    public class Class1
    {
        //This method has been added to 'force' VS to include the SharePoint assemblies in the output folder - it's not actually called
        private void OpenImportXmlFile(Guid siteId, string relativeUrl, string fileUrl)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate ()
            {
                using (SPSite site = new SPSite(siteId))
                {
                    using (SPWeb web = site.OpenWeb(relativeUrl))
                    {
                        try
                        {
                            var file = web.GetFile(fileUrl);
                            //OpenImportXmlFile(file.OpenBinaryStream());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                    }
                }
            });
        }
    }
}
